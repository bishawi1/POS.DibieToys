using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class SupplyTransactionBranchDialog : Form
    {
        private bool newTransaction = false;
        private int supplyTransactionId = 0;
        public bool Accepted = false;

        private int mlngItem_Unit_ID = 0;
        private decimal itemUnitPrice = 0;

        public SupplyTransactionBranchDialog()
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
        private void clearScreen()
        {
            txtBarcode.Text = string.Empty;
            txtItem_Desc.Text = string.Empty;
            txtItem_Group_Desc.Text = string.Empty;
            txtItem_Group_ID.Text = string.Empty;
            txtQNT.Text = string.Empty;
            txtUnit_Desc.Text = string.Empty;
            txtUnit_ID.Text = string.Empty;
            txtBarcode.Focus();
        }
        private async void showData()
        {
            try
            {
                vItem_UnitModel model = await searchItem();
                if (model != null)
                {
                    mlngItem_Unit_ID = model.Item_Unit_ID;
                    itemUnitPrice = model.Item_Unit_Price;
                    txtItem_Desc.Text = model.Item_Desc;
                    txtItem_Group_ID.Text = Convert.ToString(model.Item_Group_ID);
                    txtItem_Group_Desc.Text = model.Item_Group_Desc;
                    txtUnit_ID.Text = model.Unit_ID.ToString();
                    txtUnit_Desc.Text = model.Unit_Desc;
                    txtQNT.Text = string.Empty;
                    txtQNT.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        public void initForm(byte branchId)
        {
            newTransaction = true;
            initBranch();
            cmbBranch_ID.SelectedValue = branchId;
        }
        public void initForm(string barcode)
        {
            newTransaction = false;
            initBranch();
            txtBarcode.Text = barcode;
            showData();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            showData();
        }
        private bool validateTransaction()
        {
            bool isValid = true;
            return isValid;
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
                requestDto.Source_ID = Convert.ToInt16("0");
                requestDto.Item_Unit_ID = mlngItem_Unit_ID;// Convert.ToInt32(txtItem_Unit_ID.Text);
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
        private async Task<bool> editTransaction()
        {
            bool boolSaved = false;
            try
            {
                UpdateSupply_TransactionRequestDto requestDto = new UpdateSupply_TransactionRequestDto();
                requestDto.Branch_ID = (byte)cmbBranch_ID.SelectedValue;
                requestDto.QNT = Convert.ToInt32(txtQNT.Text);
                requestDto.Transaction_Notes = txtTransaction_Notes.Text.Trim();
                requestDto.Transaction_Date = txtTransaction_Date.Value;
                requestDto.Supply_Transaction_ID = supplyTransactionId;// Convert.ToInt32(txtSupply_Transaction_ID.Text);
                requestDto.Source_ID = Convert.ToInt16("0");
                requestDto.Item_Unit_ID = mlngItem_Unit_ID;// Convert.ToInt32(txtItem_Unit_ID.Text);
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

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accepted = false;
            this.Hide();
        }

        private void btnShow_Item_Group_ID_LOV_Click(object sender, EventArgs e)
        {
            SearchForItemDialog frm = new SearchForItemDialog();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                txtBarcode.Text = frm.getSelectedItemBarcode();
                showData();
            }
        }
    }
}
