using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
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
    public partial class ItemUnitBeginQntDialog : Form
    {
        private int mlngItem_Unit_ID = 0;
        private decimal itemUnitPrice = 0;
        public ItemUnitBeginQntDialog()
        {
            InitializeComponent();
        }
        private async Task<vItem_UnitModel> searchItem()
        {
            //applySearch();
            vItem_UnitModel model = null;
            ItemListCriteriaViewModel criteria = new ItemListCriteriaViewModel();
            if (!string.IsNullOrEmpty(txtBarcode.Text))
                criteria.Barcode = txtBarcode.Text.Trim();

            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = await POS.Client.ItemQueryRepository.getAll(criteria);
            if (result.StatusCode == "200")
            {
                if (result.Data != null)
                {
                    List<vItem_UnitModel> list;
                    list = (List<vItem_UnitModel>)result.Data;
                    if (list != null)
                    {
                        if (list.Count > 0)
                        {
                            model = list[0];
                        }
                    }
                }
                return model;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
                return null;
            }

        }
        public void initForm()
        {

        }
        public void initForm(string barcode)
        {
            txtBarcode.Text = barcode;
            showData();
        }
        private async void showData()
        {
            try
            {
                vItem_UnitModel model = await searchItem();
                if (model != null)
                {
                    mlngItem_Unit_ID = model.Item_Unit_ID;
                    itemUnitPrice=model.Item_Unit_Price;
                    txtItem_Desc.Text = model.Item_Desc;
                    txtItem_Group_ID.Text = Convert.ToString(model.Item_Group_ID);
                    txtItem_Group_Desc.Text = model.Item_Group_Desc;
                    txtUnit_ID.Text = model.Unit_ID.ToString();
                    txtUnit_Desc.Text = model.Unit_Desc;
                    txtQNt.Text=string.Empty;
                    txtQNt.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task<bool> addQnt()
        {
            bool boolSaved = false;
            AddItemUnitBeginQntRequestDto model = new AddItemUnitBeginQntRequestDto();
            model.Qnt = Convert.ToInt32(txtQNt.Text.Trim());
            model.Item_Unit_ID = mlngItem_Unit_ID;
            model.User_Name = "admin";
            try
            {
                //ItemRepository repository = new ItemRepository();
                ResultModel result = await ItemRepository.addBeginQnt(model);
                if (result != null)
                {
                    if (result.Data != null)
                    {
                        if (result.StatusCode == "200")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(result.ErrorText);
                        }

                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
                boolSaved = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return boolSaved;
        }
        private void clearScreen()
        {
            txtBarcode.Text=string.Empty;
            txtItem_Desc.Text=string.Empty;
            txtItem_Group_Desc.Text= string.Empty;
            txtItem_Group_ID.Text= string.Empty;
            txtQNt.Text = string.Empty;
            txtUnit_Desc.Text= string.Empty;
            txtUnit_ID.Text= string.Empty;

        }
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (await addQnt())
            {
                    if (chkPrintLableAfterSave.Checked == true)
                    {
                        string bookDesc = txtItem_Desc.Text;
                        PrintLabelViewModel model = new PrintLabelViewModel()
                        {
                            Barcode = txtBarcode.Text,
                            //Barcode_Image_Path = General.getStartupPath() + @"\myBarcodeResized.jpeg",// txtBarcode.Text,
                            Item_Unit_Price =itemUnitPrice,
                            Item_Desc = bookDesc,
                            Item_Unit_ID = mlngItem_Unit_ID
                        };
                        General.printLabel(model);
                    }
                    clearScreen();
                    txtBarcode.Focus();
                }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
