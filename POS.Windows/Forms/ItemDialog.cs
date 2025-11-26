using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.Reporting.WinForms;
using POS.Client;
using POS.DAL;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.LOVs;
using POS.Windows.Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms
{
    public partial class ItemDialog : Form
    {
        private int mlngItem_ID;
        private int mlngItem_Unit_ID;
        private bool mboolNewRecord = true;
        private bool mboolAccepted = false;
        private bool mboolBarcodeGenerated = false;

        private string defaultUnitId = string.Empty;
        private string defaultUnitDesc = string.Empty;
        private string defaultItemGroupId = string.Empty;
        private string defaultItemGroupDesc = string.Empty;
        private string defaultItemBrandId = string.Empty;
        private string defaultItemBrandName = string.Empty;
        private string defaultSource_ID = string.Empty;
        private string defaultSourceName = string.Empty;

        vItem_UnitModel vItemUnit;
        public ItemDialog()
        {
            InitializeComponent();
            General.initMyControls(this);
        }
        public bool GetAccepted()
        {
            return mboolAccepted;
        }
        private async Task showData()
        {
            try
            {
                ItemQueryRepository repository = new ItemQueryRepository();
                ResultModel result = await repository.getByIdAsync(mlngItem_ID);
                vItem_UnitModel model = (vItem_UnitModel)result.Data;
                //SQLvItem_UnitRepository repository = new(General.dataContext);
                //vItem_UnitModel model = await repository.getByIdAsync((short)mlngItem_ID);
                if (model != null)
                {
                    vItemUnit = model;
                    mlngItem_Unit_ID = model.Item_Unit_ID;
                    mlngItem_ID = model.Item_ID;
                    txtItem_No.Text = model.Item_ID.ToString();
                    txtItem_Desc.Text = model.Item_Desc;
                    txtItem_Group_ID.Text = Convert.ToString(model.Item_Group_ID);
                    txtItem_Group_Desc.Text = model.Item_Group_Desc;
                    vItemUnit.Item_Unit_ID = model.Item_Unit_ID;
                    txtUnit_ID.Text = model.Unit_ID.ToString();
                    txtUnit_Desc.Text = model.Unit_Desc;
                    txtItem_Unit_Price.Text = Convert.ToString(model.Item_Unit_Price);
                    txtItem_Unit_Cost.Text = Convert.ToString(model.Item_Unit_Cost);
                    txtBarcode.Text = model.Barcode;
                    txtNotes.Text = model.Notes;
                    chkQuickAccess.Checked = model.QuickAccess;
                    if (model.Source_ID == null)
                        txtSource_ID.Text = string.Empty;
                    else
                    {
                        txtSource_ID.Text = model.Source_ID.ToString();
                        txtSource_Name.Text = model.Book_Source_Desc;
                    }
                    txtItem_Brand_ID.Text = model.Item_Brand_ID.ToString();
                    txtItem_Brand_Name.Text = model.Item_Brand_Name;
                    if (!string.IsNullOrEmpty(model.FileUrl))
                    {
                        picItemImage.Load($"{Client.Constants.ArchiveBaseUrl}/{model.FileUrl}");
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task<bool> validateBarcode()
        {
            bool validItem = true;
            ItemListCriteriaViewModel criteria = new ItemListCriteriaViewModel();
            if (!string.IsNullOrEmpty(txtBarcode.Text))
                criteria.Barcode = txtBarcode.Text.Trim();

            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = await POS.Client.ItemQueryRepository.getAll(criteria);
            if (result.StatusCode == "200")
            {
                DataTable dt = General.ConvertToDataTable(result.Data);
                if (mboolNewRecord && dt.Rows.Count > 0)
                {
                    MessageBox.Show("تم ادخال الباركود سابقا");
                    validItem = false;
                }
                else
                {
                    if (dt.Rows.Count == 0)
                    {
                        validItem = true;
                    }
                    else
                    {
                        DataRow[] rows = dt.Select($"Item_Unit_ID <> {mlngItem_Unit_ID}");
                        if (rows.Length > 0)
                        {
                            MessageBox.Show("تم ادخال الباركود سابقا");
                            validItem = false;
                        }
                        else
                        {
                            validItem = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(result.ErrorText);
                validItem = false;
            }
            return validItem;
        }
        private async Task<bool> validateItem()
        {
            bool boolValid = true;
            if (string.IsNullOrEmpty(txtBarcode.Text))
            {
                txtBarcode.Focus();
                MessageBox.Show("يرجى ادخال الباركود");
                boolValid = false;
            }
            else if (string.IsNullOrEmpty(txtItem_Desc.Text))
            {
                txtItem_Desc.Focus();
                MessageBox.Show("يرجى ادخال اسم الصنف");
                boolValid = false;
            }
            else if (string.IsNullOrEmpty(txtItem_Group_ID.Text))
            {
                txtItem_Group_ID.Focus();
                MessageBox.Show("يرجى ادخال مجموعة/فئة الصنف");
                boolValid = false;
            }
            else if (string.IsNullOrEmpty(txtUnit_ID.Text))
            {
                txtUnit_ID.Focus();
                MessageBox.Show("يرجى ادخال الوحدة");
                boolValid = false;
            }
            else if (txtItem_Unit_Cost.Value > txtItem_Unit_Price.Value)
            {
                txtItem_Unit_Price.Focus();
                MessageBox.Show("يرجى مراجعة سعر البيع وسعر التكلفة");
                boolValid = false;
            }
            else
            {
                boolValid = await validateBarcode();
            }
            return boolValid;
        }
        private async Task<bool> addTransaction()
        {
            bool boolSaved = false;
            try
            {
                AddSupply_TransactionRequestDto requestDto = new AddSupply_TransactionRequestDto();
                requestDto.Branch_ID = Constants.MainBranchId;// Convert.ToByte(cmbBranch_ID.SelectedValue);
                requestDto.QNT = Constants.DefaultSupplyQnt;// Convert.ToInt32(txtQNT.Text);
                requestDto.Transaction_Notes =string.Empty; //txtTransaction_Notes.Text.Trim();
                requestDto.Transaction_Date = DateTime.Today;// txtTransaction_Date.Value;
                requestDto.Source_ID = 0;// Convert.ToInt16(txtSource_ID.Text);
                requestDto.Item_Unit_ID = 4;// Convert.ToInt32(txtItem_Unit_ID.Text);
                requestDto.IsActive = true;
                requestDto.User_Name = General.userSession.UserName;
                ResultModel result = await Client.SupplyTransactionRepository.add(requestDto);
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        boolSaved = true;
                    }
                }
                else
                {
                    throw new Exception(result.ErrorText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return boolSaved;
        }

        private async Task<bool> addItem()
        {
            bool boolSaved = false;
            AddItemRequestModel model = new AddItemRequestModel();
            model.Item_Desc = txtItem_Desc.Text.Trim();
            model.Barcode = txtBarcode.Text.Trim();
            model.User_Name = "admin";
            model.ItemGroupID = Convert.ToByte(txtItem_Group_ID.Text.ToString().Trim());
            model.Is_Main_Unit = true;
            model.ItemNotes = (txtNotes.Text == null ? string.Empty : txtNotes.Text.Trim());
            model.Item_Unit_Price = txtItem_Unit_Price.Value;
            model.Item_Unit_Cost = txtItem_Unit_Cost.Value;
            model.Default_Unit = true;
            model.UnitID = Convert.ToByte(txtUnit_ID.Text.Trim());
            model.QuickAccess = chkQuickAccess.Checked;
            if (txtItem_Brand_ID.Text.Trim() == string.Empty)
            {
                //model.Item_Brand_ID = null;
            }
            else
            {
                model.Item_Brand_ID = Convert.ToInt32(txtItem_Brand_ID.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtSource_ID.Text.Trim()))
            {
                model.Source_ID = Convert.ToInt16(txtSource_ID.Text);
            }
            try
            {
                //ItemRepository repository = new ItemRepository();
                await ItemRepository.add(model);
                await addTransaction();
                boolSaved = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return boolSaved;
        }
        private async Task<bool> updateItem()
        {
            bool boolSaved = false;
            UpdateItemRequestModel model = new UpdateItemRequestModel();
            model.Item_ID = mlngItem_ID;
            model.Item_Unit_Id = vItemUnit.Item_Unit_ID;
            model.Item_Desc = txtItem_Desc.Text.Trim();
            model.Barcode = txtBarcode.Text.Trim();
            model.User_Name = "admin";
            model.ItemNotes = (txtNotes.Text == null ? string.Empty : txtNotes.Text.Trim());
            model.ItemGroupID = Convert.ToByte(txtItem_Group_ID.Text.ToString().Trim());
            model.Item_Unit_Price = txtItem_Unit_Price.Value;
            model.Item_Unit_Cost = txtItem_Unit_Cost.Value;
            model.UnitID = Convert.ToByte(txtUnit_ID.Text.Trim());
            model.QuickAccess = chkQuickAccess.Checked;
            if (txtItem_Brand_ID.Text.Trim() == string.Empty)
            {
                //model.Item_Brand_ID = null;
            }
            else
            {
                model.Item_Brand_ID = Convert.ToInt32(txtItem_Brand_ID.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtSource_ID.Text.Trim()))
            {
                model.Source_ID = Convert.ToInt16(txtSource_ID.Text);
            }

            try
            {
                ResultModel result = await ItemRepository.update(model);
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        boolSaved = true;
                    }
                }
                else
                {
                    throw new Exception(result.ErrorText);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return boolSaved;
        }
        private async Task<bool> SaveItem()
        {
            bool boolSaved = false;
            if (mboolNewRecord)
                boolSaved = await addItem();
            else
                boolSaved = await updateItem();
            return boolSaved;
        }
        private void clearScreen()
        {
            txtBarcode.Text = string.Empty;
            txtItem_Brand_ID.Text = "0";// string.Empty;
            txtItem_Brand_Name.Text = string.Empty;
            txtItem_Desc.Text = string.Empty;
            txtItem_Group_Desc.Text = string.Empty;
            txtItem_Group_ID.Text = "6";//string.Empty;
            txtItem_Unit_Cost.Text = string.Empty;
            txtItem_Unit_Price.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtUnit_Desc.Text = string.Empty;
            txtUnit_ID.Text = string.Empty;
            txtSource_ID.Text = "0";// string.Empty;
            txtSource_Name.Text = string.Empty;
            chkQuickAccess.Checked = false;
        }
        private void setDefaults()
        {
            if (string.IsNullOrEmpty(defaultUnitId))
            {
                txtUnit_ID.Text = General.defaultUnitId.ToString();
                txtUnit_Desc.Text = General.getUnitDesc(General.defaultUnitId);
            }
            else
            {
                txtUnit_ID.Text = defaultUnitId;
                txtUnit_Desc.Text = defaultUnitDesc;
            }

            //if (!string.IsNullOrEmpty(defaultItemBrandId))
            //{
            //    txtItem_Brand_ID.Text = defaultItemBrandId;
            //    txtItem_Brand_Name.Text = defaultItemBrandName;
            //}
            txtItem_Brand_ID.Text = "0";
            //if (!string.IsNullOrEmpty(defaultItemGroupId))
            //{
            //    txtItem_Group_ID.Text = defaultItemGroupId;
            //    txtItem_Group_Desc.Text = defaultItemGroupDesc;
            //}
            txtItem_Group_ID.Text = "6";
            //if (!string.IsNullOrEmpty(defaultSource_ID))
            //{
            //    txtSource_ID.Text = defaultSource_ID;
            //    txtSource_Name.Text = defaultSourceName;
            //}
            txtSource_ID.Text = "0";
        }
        public void InitForm()
        {
            mboolNewRecord = true;
            tsbtnShowOpeningQntDialog.Visible=false;
            clearScreen();
            setDefaults();
        }
        public void InitForm(int Item_ID)
        {
            mlngItem_ID = Item_ID;
            mboolNewRecord = false;
            showData();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (await validateItem())
            {
                if (await SaveItem())
                {
                    PrintLabelViewModel model = null;
                    if (mboolBarcodeGenerated == true)
                    {
                        model = new PrintLabelViewModel()
                        {
                            Barcode = txtBarcode.Text,
                            Item_Unit_Price = txtItem_Unit_Price.Value,
                            Item_Desc = txtItem_Desc.Text,
                            Item_Unit_ID = mlngItem_ID
                        };
                    }
                    defaultItemBrandId = txtItem_Brand_ID.Text;
                    defaultItemBrandName = txtItem_Brand_Name.Text;
                    defaultItemGroupId = txtItem_Group_ID.Text;
                    defaultItemGroupDesc = txtItem_Group_Desc.Text;
                    defaultUnitId = txtUnit_ID.Text;
                    defaultUnitDesc = txtUnit_Desc.Text;
                    defaultSource_ID = txtSource_ID.Text;
                    defaultSourceName = txtSource_Name.Text;
                    clearScreen();
                    setDefaults();
                    txtBarcode.Focus();
                    mboolNewRecord = true;
                    if (mboolBarcodeGenerated == true)
                    {
                        if (model != null)
                            printLable(model, false);
                    }
                    mboolBarcodeGenerated = false;
                    //mboolAccepted = true;
                    //this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }
        private void Show_ItemGroup_ID_LOV()
        {
            ItemGroupLOV lov = new ItemGroupLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtItem_Group_ID.Text = lov.getSelectedItemGroupID().ToString();
                txtItem_Group_Desc.Text = lov.getSelectedItemGroupDesc();
                txtItem_Unit_Price.Focus();
            }
        }
        private void btnShow_Season_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_ItemGroup_ID_LOV();
        }
        private void Show_Unit_ID_LOV()
        {
            UnitLOV lov = new UnitLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtUnit_ID.Text = lov.getSelectedUnitId().ToString();
                txtUnit_Desc.Text = lov.getSelectedUnitDesc();
                txtItem_Brand_ID.Focus();
            }
        }
        private void btnShow_Unit_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Unit_ID_LOV();
        }

        private void Show_Item_Brand_ID_LOV()
        {
            ItemBrandLOV lov = new();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtItem_Brand_ID.Text = lov.getSelectedItemBrandId().ToString();
                txtItem_Brand_Name.Text = lov.getSelectedItemBrandName();
                txtSource_ID.Focus();
            }
        }

        private void btnShow_Item_Brand_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Item_Brand_ID_LOV();
        }
        private void printLable()
        {
            PrintLabelViewModel model = new PrintLabelViewModel()
            {
                Barcode = txtBarcode.Text,
                Barcode_Image_Path = General.getStartupPath() + @"\myBarcodeResized.jpeg",// txtBarcode.Text,
                Item_Unit_Price = txtItem_Unit_Price.Value,
                Item_Desc = txtItem_Desc.Text,
                Item_Unit_ID = mlngItem_ID
            };//
            //ReportParameter parImagePath = new ReportParameter("parImagePath", new Uri(model.Barcode_Image_Path).AbsoluteUri);
            //ReportParameter[] parameters = { parImagePath };
            General.printLabel(model);
        }
        private void printLable(PrintLabelViewModel model, bool needGenerateBarcode)
        {
            if (needGenerateBarcode)
            {
                // generateBarcode();
            }
            General.printLabel(model);
        }


        private void txtItem_Group_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem_Group_ID.Text))
                Show_ItemGroup_ID_LOV();
        }

        private void txtUnit_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnit_ID.Text))
                Show_Unit_ID_LOV();
        }

        private void txtItem_Brand_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem_Brand_ID.Text))
                Show_Item_Brand_ID_LOV();
        }

        private async void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            bool Cont = true;
            while (Cont)
            {
                ItemQueryRepository repository = new ItemQueryRepository();
                ResultModel result = await repository.GenerateBarcode();
                if (result.StatusCode == "200")
                {
                    txtBarcode.Text = result.Data.ToString();
                    mboolBarcodeGenerated = true;
                    if (Convert.ToInt32(txtBarcode.Text) > 23000)
                    {
                        Cont = false;
                    }
                }
            }
        }
        private void Show_Source_ID_LOV()
        {
            SourceLOV lov = new SourceLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtSource_ID.Text = lov.getSelectedBookSourceId().ToString();
                txtSource_Name.Text = lov.getSelectedBookSourceDesc();
                //getInvoice();
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                General.LoadSources();
                txtNotes.Focus();
            }
        }
        private void btnShow_Book_Source_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Source_ID_LOV();
        }

        private void txtSource_ID_Validating(object sender, CancelEventArgs e)
        {
            if (txtSource_ID.Text.Trim() == "")
            {
                txtSource_Name.Text = string.Empty;
            }
            else
            {
                string name = General.getSourceName(Convert.ToInt16(txtSource_ID.Text));
                if (name == "")
                {
                    txtSource_Name.Text = "";
                    MessageBox.Show("غير معرف");
                    txtSource_ID.Text = "";
                    txtSource_ID.Focus();
                }
                else
                {
                    txtSource_Name.Text = name;
                }
            }
        }

        private void txtItem_Brand_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSource_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource_ID.Text))
                Show_Source_ID_LOV();
        }

        private void ItemDialog_Activated(object sender, EventArgs e)
        {
            if (mlngItem_ID > 0 && string.IsNullOrEmpty(txtItem_Desc.Text.Trim()))
            {
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
            }
        }

        private void txtItem_Group_ID_Validating(object sender, CancelEventArgs e)
        {
            if (txtItem_Group_ID.Text.Trim() == "")
            {
                txtItem_Group_Desc.Text = string.Empty;
            }
            else
            {
                string name = General.getItemGroupDesc(Convert.ToInt16(txtItem_Group_ID.Text));
                if (name == "")
                {
                    txtItem_Group_Desc.Text = "";
                    MessageBox.Show("غير معرف");
                    txtItem_Group_Desc.Text = "";
                    txtItem_Group_ID.Focus();
                }
                else
                {
                    txtItem_Group_Desc.Text = name;
                }
            }
        }

        private void txtUnit_ID_Validating(object sender, CancelEventArgs e)
        {
            if (txtUnit_ID.Text.Trim() == "")
            {
                txtUnit_Desc.Text = string.Empty;
            }
            else
            {
                string name = General.getUnitDesc(Convert.ToByte(txtUnit_ID.Text));
                if (name == "")
                {
                    txtUnit_Desc.Text = "";
                    MessageBox.Show("غير معرف");
                    txtUnit_ID.Text = "";
                    txtUnit_ID.Focus();
                }
                else
                {
                    txtUnit_Desc.Text = name;
                }
            }
        }

        private void txtItem_Brand_ID_Validating(object sender, CancelEventArgs e)
        {
            if (txtItem_Brand_ID.Text.Trim() == "")
            {
                txtItem_Brand_Name.Text = string.Empty;
            }
            else
            {
                string name = General.getItemBrandName(Convert.ToByte(txtItem_Brand_ID.Text));
                if (name == "")
                {
                    txtItem_Brand_Name.Text = "";
                    MessageBox.Show("غير معرف");
                    txtItem_Brand_ID.Text = "";
                    txtItem_Brand_ID.Focus();
                }
                else
                {
                    txtItem_Brand_Name.Text = name;
                }
            }
        }

        private void txtBarcode_Validating(object sender, CancelEventArgs e)
        {

        }

        private async void tsbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("هل تود الاستمرار في الحذ، في حال الاستمرار لا يمكن التراجع!", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (reply == DialogResult.Yes)
            {
                ResultModel result = await ItemRepository.delete(mlngItem_ID);
                if (result != null)
                {
                    if (result.StatusCode == "200")
                    {
                        MessageBox.Show("تم الحذف");
                        mboolAccepted = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorText);
                    }
                }
                ;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //generateBarcode();
            printLable();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.jpg)|*.jpg|PNG files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    //picItemImage.Image = new Bitmap(dlg.FileName);
                    picItemImage.Load(dlg.FileName);
                    try
                    {
                        //General.ResizeImage(dlg.FileName, "output.jpg", 200, 200);

                        Client.ItemRepository.uploadItemFile(mlngItem_ID, dlg.FileName);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        private void tsbtnItemStockDetails_Click(object sender, EventArgs e)
        {
            ItemUnitStockDetailsForm frm = new ItemUnitStockDetailsForm();
            frm.initForm(mlngItem_Unit_ID);
            frm.ShowDialog();
        }

        private void txtItem_Group_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tsbtnShowOpeningQntDialog_Click(object sender, EventArgs e)
        {

            ItemUnitBeginQntDialog frm = new ItemUnitBeginQntDialog();
            frm.MdiParent = this.MdiParent;
            frm.initForm(txtBarcode.Text);
            frm.Show();
        }
    }
}
