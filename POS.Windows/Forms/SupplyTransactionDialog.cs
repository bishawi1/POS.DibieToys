using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.LOVs;
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
    public partial class SupplyTransactionDialog : Form
    {
        private bool newTransaction = false;
        private int supplyTransactionId = 0;
        public bool Accepted = false;
        public SupplyTransactionDialog()
        {
            InitializeComponent();
        }
        private void initBranch()
        {
            cmbBranch_ID.ValueMember = "Branch_ID";
            cmbBranch_ID.DisplayMember = "Branch_Name";
            cmbBranch_ID.DataSource = General.BranchesDatatable;
            cmbBranch_ID.SelectedIndex = 0;
        }
        public void initForm()
        {
            newTransaction = true;
            initBranch();
        }
        private async void showData()
        {
            ResultModel result = await Client.SupplyTransactionRepository.geTransaction(supplyTransactionId);
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    vSupply_TransactionModel model = (vSupply_TransactionModel)result.Data;
                    if (model != null)
                    {
                        txtItem_Desc.Text = model.Item_Desc;
                        txtItem_Unit_ID.Text = model.Item_Unit_ID.ToString();
                        txtQNT.Text = model.QNT.ToString();
                        txtSource_ID.Text = model.Source_ID.ToString();
                        txtSource_Name.Text = model.Book_Source_Desc;
                        txtSupply_Transaction_ID.Text = model.Supply_Transaction_ID.ToString();
                        txtTransaction_Date.Value = model.Transaction_Date;
                        txtTransaction_Notes.Text = model.Transaction_Notes;
                    }
                }
            }
        }
        public void initForm(int supplyTransactionId)
        {
            initBranch();
            this.supplyTransactionId = supplyTransactionId;
            newTransaction = false;
            showData();
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
                txtItem_Unit_ID.Focus();
            }
        }
        private void btnShow_Book_Source_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Source_ID_LOV();
        }
        private bool validateTransaction()
        {
            bool isValid = true;
            return isValid;
        }
        private void clearScreen()
        {
            txtBarcode.Text = string.Empty;
            txtQNT.Text = string.Empty;
            txtTransaction_Notes.Text = string.Empty;
            txtSource_ID.Text = string.Empty;
            txtSource_Name.Text = string.Empty;
            txtItem_Unit_ID.Text = string.Empty;
            txtItem_Desc.Text = string.Empty;
            txtBarcode.Focus();
            newTransaction = false;
        }
        private async Task<bool> editTransaction()
        {
            bool boolSaved = false;
            try
            {
                UpdateSupply_TransactionRequestDto requestDto = new UpdateSupply_TransactionRequestDto();
                requestDto.Branch_ID = Convert.ToByte(cmbBranch_ID.SelectedValue);
                requestDto.QNT = Convert.ToInt32(txtQNT.Text);
                requestDto.Transaction_Notes = txtTransaction_Notes.Text.Trim();
                requestDto.Transaction_Date = txtTransaction_Date.Value;
                requestDto.Supply_Transaction_ID = Convert.ToInt32(txtSupply_Transaction_ID.Text);
                requestDto.Source_ID = Convert.ToInt16(txtSource_ID.Text);
                requestDto.Item_Unit_ID = Convert.ToInt32(txtItem_Unit_ID.Text);
                requestDto.IsActive = true;
                requestDto.User_Name = General.userSession.UserName;
                ResultModel result = await Client.SupplyTransactionRepository.update(requestDto);
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
        private async Task<bool> addTransaction()
        {
            bool boolSaved = false;
            try
            {
                AddSupply_TransactionRequestDto requestDto = new AddSupply_TransactionRequestDto();
                requestDto.Branch_ID = Convert.ToByte(cmbBranch_ID.SelectedValue);
                requestDto.QNT = Convert.ToInt32(txtQNT.Text);
                requestDto.Transaction_Notes = txtTransaction_Notes.Text.Trim();
                requestDto.Transaction_Date = txtTransaction_Date.Value;
                requestDto.Source_ID = Convert.ToInt16(txtSource_ID.Text);
                requestDto.Item_Unit_ID = Convert.ToInt32(txtItem_Unit_ID.Text);
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

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (validateTransaction())
            {
                if (newTransaction == true)
                {
                    if (await addTransaction())
                    {
                        clearScreen();
                        //Accepted = true;
                        //this.Hide();
                    }
                }
                else
                {
                    if (await editTransaction())
                    {
                        Accepted = true;
                        this.Hide();
                    }
                }
            }
        }

        private void btnShow_Item_Unit_ID_LOV_Click(object sender, EventArgs e)
        {
            SearchForItemDialog frm = new SearchForItemDialog();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                txtItem_Unit_ID.Text = frm.getSelectedItemUnitId().ToString();
                txtItem_Desc.Text = frm.getSelectedItemName();
            }
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

        private async void showItem()
        {
            try
            {
                vItem_UnitModel model = await searchItem();
                if (model != null)
                {

                    txtItem_Unit_ID.Text = model.Item_Unit_ID.ToString();
                    txtItem_Desc.Text = model.Item_Desc;
                    //lblRemainQNT.Text = model.RemainQNT.ToString();
                    txtSource_ID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            showItem();
        }

        private void btnShow_Item_Group_ID_LOV_Click(object sender, EventArgs e)
        {
            SearchForItemDialog frm = new SearchForItemDialog();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                txtBarcode.Text = frm.getSelectedItemBarcode();
                showItem();
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                showItem();
            }
        }
    }
}
