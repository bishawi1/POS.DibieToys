using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Identity.Client;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.Win32;
using POS.Shared;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Teller.ViewModel;
using POS.Windows.Components.ViewModels;
using POS.Windows.Forms;
using POS.Windows.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Components
{
    public partial class SoldItemListComponent : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public byte Branch_ID { get; set; } = 1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsBacked { get; set; } = false;

        private DataTable moDataTable;
        vSales_TransactonModel moInvoiceModel = new vSales_TransactonModel();

        private int mintSaleTransactionID = 0;

        private int itemCount = 0;
        private decimal totalAmount = 0;
        private decimal netAmount = 0;
        private decimal discount = 0;
        private PayWayEnum payWay = PayWayEnum.Cash;
        private short customerId = Client.Constants.CashCustomer_ID;
        private string transactionNotes = string.Empty;
        private byte chequeBankNo = 0;
        private string chequeNo = string.Empty;
        private DateTime chequeDueDate = DateTime.MinValue;
        private string paymentNotes = string.Empty;
        private decimal paidAmount = 0;
        private List<int> deletedItems = new List<int>();

        private decimal delevery_Fees = 0;
        private string delevery_Place = string.Empty;
        private string delevery_Transaction_No = string.Empty;
        private bool newINvoice = true;
        public event EventHandler OnInvoiceCancelClick;
        public event EventHandler OnInvoiceSaved;
        public event EventHandler OnItemChanged;
        public event EventHandler OnPayWayChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FirstInvoice { get; set; } = true;
        public async void EditSalesTransaction(int saleTransactionID)
        {
            newINvoice = false;
            DataTable dt = new DataTable();
            InvoiceReportCriteriaViewModel criteria = new InvoiceReportCriteriaViewModel();
            criteria.Sale_Transaction_ID = saleTransactionID;
            ResultModel result = await Client.SaleTransactionRepository.getInvoiceReportData(criteria);
            if (result.StatusCode == "200")
            {
                List<vInvoiceReportModel> transactionItems = (List<vInvoiceReportModel>)result.Data;
                if (transactionItems.Count > 0)
                {
                    mintSaleTransactionID = transactionItems[0].Sale_Transaction_ID;
                    moInvoiceModel.Sale_Transaction_ID = transactionItems[0].Sale_Transaction_ID;
                    moInvoiceModel.Sale_Transaction_No = transactionItems[0].Sale_Transaction_No;
                    moInvoiceModel.Transaction_Date = transactionItems[0].Transaction_Date;
                    moInvoiceModel.Amount = transactionItems[0].Amount;
                    moInvoiceModel.Customer_Name = transactionItems[0].Customer_Name;
                    moInvoiceModel.Customer_ID = transactionItems[0].Customer_ID;
                    moInvoiceModel.Delevery_Fees = transactionItems[0].Delevery_Fees;
                    moInvoiceModel.Delevery_Place = transactionItems[0].Delevery_Place;
                    moInvoiceModel.Delevery_Transaction_No = transactionItems[0].Delevery_Transaction_No;
                    moInvoiceModel.PaidAmountSum = transactionItems[0].PaidAmountSum;
                    moInvoiceModel.RemainAmount = transactionItems[0].RemainAmount;
                    moInvoiceModel.Teller_ID = transactionItems[0].Teller_ID;
                    moInvoiceModel.Teller_Name = transactionItems[0].Teller_Name;
                    moInvoiceModel.Total_Amount = transactionItems[0].Total_Amount;
                    moInvoiceModel.Transaction_Notes = transactionItems[0].Transaction_Notes;
                }
                foreach (vInvoiceReportModel transactionItem in transactionItems)
                {
                    SoldItemViewModel item = new SoldItemViewModel()
                    {
                        Sale_Transaction_Item_ID = transactionItem.Sale_Transaction_Item_ID,
                        Item_Unit_ID = (short)transactionItem.Item_Unit_ID,
                        Item_Desc = transactionItem.Item_Desc,
                        //Item_ID = transactionItem.Item_ID,
                        Item_Unit_Cost = transactionItem.Item_Unit_Cost,
                        Item_Unit_Price = transactionItem.Item_Unit_Price,
                        QNT = transactionItem.QNT,
                        Unit_ID = transactionItem.Unit_ID,
                        Unit_Desc = transactionItem.Unit_Desc,
                        TotalAmount = transactionItem.QNT * transactionItem.Item_Unit_Price,
                    };
                    AddItem(item);
                }
                //                dt = General.ConvertToDataTable(result.Data);
            }

        }
        public void AddItem(SoldItemViewModel item)
        {
            if (moDataTable == null)
            {
                List<SoldItemViewModel> soldItems = new List<SoldItemViewModel>();
                soldItems.Add(item);
                moDataTable = General.ConvertToDataTable(soldItems);
                moDataTable.Rows[0][colTotalAmount.DataPropertyName] = (Convert.ToDecimal(moDataTable.Rows[0][colQnt.DataPropertyName]) * Convert.ToDecimal(moDataTable.Rows[0][colItem_Unit_Price.DataPropertyName]));
                moDataTable.AcceptChanges();
            }
            else
            {
                //DataGridViewRow newRow = new DataGridViewRow();
                //newRow.
                DataRow row = moDataTable.NewRow();
                row[colItem_Desc.DataPropertyName] = item.Item_Desc;
                row[colQnt.DataPropertyName] = item.QNT;
                row[colItem_ID.DataPropertyName] = item.Item_ID;
                row[colItem_Unit_Cost.DataPropertyName] = item.Item_Unit_Cost;
                row[colItem_Unit_ID.DataPropertyName] = item.Item_Unit_ID;
                row[colItem_Unit_Price.DataPropertyName] = item.Item_Unit_Price;
                row[colTotalAmount.DataPropertyName] = (item.QNT * item.Item_Unit_Price);
                row[colUnit_ID.DataPropertyName] = item.Unit_ID;
                row[colUnit_Desc.DataPropertyName] = item.Unit_Desc;
                row[colSale_Transaction_Item_ID.DataPropertyName] = item.Sale_Transaction_Item_ID;
                //row[colIncrease.DataPropertyName] = "+";
                //row[colDescrease.DataPropertyName] = "-";
                moDataTable.Rows.Add(row);
            }
            calcTotalAmount();
            grdItemList.AutoGenerateColumns = false;
            grdItemList.DataSource = moDataTable;
            var uniqueObjects = moDataTable.AsEnumerable().Select(x => x.Field<Int64>("Item_ID")).Distinct().ToList();
            lblItemCount.Text = uniqueObjects.Count().ToString();
            //// Fix for CS7036: Ensure the required parameters 'sender' and 'EventArgs' are passed when invoking the event.
            //if (OnItemChanged != null)
            //{
            //    OnItemChanged.Invoke(this, EventArgs.Empty); // Pass 'this' as sender and 'EventArgs.Empty' as the event arguments.
            //}

            // Fix for IDE1005: Simplify delegate invocation.
            txtBarcode.Focus();
            grdItemList.CurrentCell = grdItemList.Rows[grdItemList.Rows.Count - 1].Cells[colItem_Desc.Name];
            OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.

        }
        public decimal getTotalAmount()
        {
            return Convert.ToDecimal(lblTotalAmount.Text);
        }
        public decimal getNetAmount()
        {
            return Convert.ToDecimal(lblNetAmount.Text);
        }
        private decimal calcTotalAmount()
        {
            decimal itemPriceTotal = 0;
            decimal discountAmount = Convert.ToDecimal((string.IsNullOrEmpty(lblDiscount.Text) ? 0 : lblDiscount.Text));
            int itemCount = 0;

            decimal totalAmount = 0;
            if (moDataTable == null || moDataTable.Rows.Count == 0)
            {
                lblTotalAmount.Text = "0";
                lblNetAmount.Text = "0";
                lblDiscount.Text = "0";
                return 0;
            }
            moDataTable.AcceptChanges();
            foreach (DataRow band in moDataTable.Rows)
            {
                itemPriceTotal += Convert.ToDecimal(band[colTotalAmount.DataPropertyName]);
                //creditAmount += Convert.ToDecimal(band[colCredit_Voucher_Detail_Amount.DataPropertyName]);
                itemCount += 1;
            }
            totalAmount = itemPriceTotal;
            discount = discountAmount;

            lblTotalAmount.Text = itemPriceTotal.ToString();
            totalAmount = Math.Abs(itemPriceTotal - discountAmount - paidAmount);
            lblNetAmount.Text = totalAmount.ToString();
            netAmount = totalAmount;
            lblDiscount.Text = discount.ToString();

            calcDiscountPercent();


            return totalAmount;
        }

        private void initGrid()
        {
            //DataGridViewRow row = this.grdItemList.RowTemplate;
            ////row.DefaultCellStyle.BackColor = Color.Bisque;
            //row.DefaultCellStyle.BackColor = Color.White;
            //row.DefaultCellStyle.Font = new Font(grdItemList.DefaultCellStyle.Font.FontFamily, 15);
            //row.Height = 70;
            //row.MinimumHeight = 20;
            //grdItemList.BorderStyle = BorderStyle.None;
            //grdItemList.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            //grdItemList.DefaultCellStyle.SelectionBackColor = Color.White;
            //grdItemList.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        public SoldItemListComponent()
        {
            InitializeComponent();
            initGrid();
            //grdItemList.Columns.Insert(0, new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.Undo,
            //    Width = 50,
            //    Name = "colUndo",
            //    HeaderText = ""
            //});
            //grdItemList.Columns.Insert(colQnt.Index + 1, new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.icons8_minus_50,
            //    Width = 50,
            //    Name = "colDecrease",
            //    HeaderText = ""
            //});
            //grdItemList.Columns.Insert(colQnt.Index - 1, new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.icons8_add_50,
            //    Width = 50,
            //    Name = "colIncrease",
            //    HeaderText = ""
            //});

        }



        private void reCalculateItemPrice()
        {
            if (grdItemList.CurrentRow != null)
            {
                decimal itemUnitPrice = Convert.ToDecimal(grdItemList.CurrentRow.Cells[colItem_Unit_Price.Name].Value);
                grdItemList.CurrentRow.Cells[colTotalAmount.Name].Value = (Convert.ToInt32(grdItemList.CurrentRow.Cells[colQnt.Name].Value) * itemUnitPrice);
                grdItemList.Update();
                lblNetAmount.Text = calcTotalAmount().ToString();
                calcDiscountPercent();
                txtBarcode.Focus();
            }
            else
            {
                lblTotalAmount.Text = string.Empty;
                lblNetAmount.Text = string.Empty;
                lblDiscountPercent.Text = string.Empty;
                lblItemCount.Text = string.Empty;
                txtBarcode.Focus();

            }

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }
        private void searcUsingBarcode()
        {
            if (txtBarcode.Text.Trim().Length > 0)
            {
                vBranch_Item_UnitModel item = General.retItem(txtBarcode.Text.Trim());
                if (item != null)
                {
                    SoldItemViewModel soldItem = new SoldItemViewModel
                    {
                        Item_Desc = item.Item_Desc,
                        Item_ID = item.Item_ID,
                        Item_Unit_Cost = item.Item_Unit_Cost,
                        Item_Unit_Price = item.Item_Unit_Price,
                        Item_Unit_ID = item.Item_Unit_ID,
                        Unit_Desc = item.Unit_Desc,
                        Unit_ID = item.Unit_ID,
                        QNT = 1,
                    };
                    AddItem(soldItem);
                }
            }
            txtBarcode.Text = string.Empty;
            txtBarcode.Focus();
        }
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searcUsingBarcode();
            }
        }
        private void printInvoice(DataTable invoiceDataTable)
        {
            ReportViewer.PrintToPrinter(invoiceDataTable, General.getStartupPath() + @"\Reports\InvoiceReport.rdlc", null);

            //ReportViewer report = new ReportViewer();
            //report.initForm(invoiceDataTable.Copy(), General.getStartupPath() + @"\Reports\InvoiceReport.rdlc", null);
            //report.Show();

        }
        private void grdItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdItemList.Columns[e.ColumnIndex].Name == "colIncrease")
            {
                if (grdItemList.CurrentRow != null)
                {
                    grdItemList.CurrentRow.Cells[colQnt.Name].Value = Convert.ToInt32(grdItemList.CurrentRow.Cells[colQnt.Name].Value) + 1;
                    grdItemList.Update();
                    reCalculateItemPrice();
                    OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
                }

            }
            else if (grdItemList.Columns[e.ColumnIndex].Name == "colDecrease")// colDescrease.Index
            {
                int qnt = Convert.ToInt32(grdItemList.CurrentRow.Cells[colQnt.Name].Value);
                if (qnt > 1)
                {
                    if (grdItemList.CurrentRow != null)
                    {
                        qnt -= 1;
                        grdItemList.CurrentRow.Cells[colQnt.Name].Value = qnt;
                        grdItemList.Update();
                        reCalculateItemPrice();
                        grdItemList.CurrentCell = null;
                        OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
                    }
                }
            }
            else if (e.ColumnIndex == colItem_Unit_Price.Index)
            {
                NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
                frm.ShowDialog();
                if (frm.Accepted)
                {
                    grdItemList.CurrentRow.Cells[colItem_Unit_Price.Name].Value = Convert.ToDecimal(frm.Result);
                    grdItemList.Update();
                    reCalculateItemPrice();
                    OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
                }
            }
            else if (e.ColumnIndex == colQnt.Index)
            {
                NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
                frm.ShowDialog();
                if (frm.Accepted)
                {
                    grdItemList.CurrentRow.Cells[colQnt.Name].Value = Convert.ToDecimal(frm.Result);
                    grdItemList.Update();
                    reCalculateItemPrice();
                    OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
                }
            }
            else if (grdItemList.Columns[e.ColumnIndex].Name == "colUndo")// colDescrease.Index
            {
                if (grdItemList.Rows[e.RowIndex].Cells[colSale_Transaction_Item_ID.Index].Value != null)
                    deletedItems.Add(Convert.ToInt32(grdItemList.Rows[e.RowIndex].Cells[colSale_Transaction_Item_ID.Index].Value));
                grdItemList.Rows.RemoveAt(e.RowIndex);
                grdItemList.Update();
                reCalculateItemPrice();
                OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
            }
        }
        public void clearScreen()
        {
            moDataTable.Rows.Clear();
            txtBarcode.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblItemCount.Text = string.Empty;
            lblNetAmount.Text = string.Empty;
            lblTotalAmount.Text = string.Empty;
            itemCount = 0;
            totalAmount = 0;
            netAmount = 0;
            discount = 0;
            customerId = Client.Constants.CashCustomer_ID;
            transactionNotes = string.Empty;
            chequeBankNo = 0;
            chequeDueDate = DateTime.MinValue;
            paymentNotes = string.Empty;
            chequeNo = string.Empty;
            paidAmount = 0;
            delevery_Fees = 0;
            delevery_Place = string.Empty;
            delevery_Transaction_No = string.Empty;
            txtBarcode.Focus();
            deletedItems.Clear();
        }
        private async Task<int> addInvoice(List<SaleTransactionPaidAmountDto> amountList=null)
        {
            try
            {
                ModifyTransactionItemRequest modifiedItem;
                List<ModifyTransactionItemRequest> modifyTransactionItems = new List<ModifyTransactionItemRequest>();
                foreach (DataRow row in moDataTable.Rows)
                {
                    modifiedItem = new ModifyTransactionItemRequest()
                    {
                        Discount_Amount = 0,
                        IsActive = true,
                        IsBacked = this.IsBacked,
                        Item_Unit_ID = Convert.ToInt16(row[colItem_Unit_ID.DataPropertyName]),
                        Item_Unit_Price = Convert.ToDecimal(row[colItem_Unit_Price.DataPropertyName]),
                        Item_Unit_Cost = Convert.ToDecimal(row[colItem_Unit_Cost.DataPropertyName]),
                        Item_Unit_Price_After_Discount = Convert.ToDecimal(row[colItem_Unit_Price.DataPropertyName]),
                        QNT = Convert.ToInt32(row[colQnt.DataPropertyName]),
                        Notes = "",
                        User_Name = "Admin",
                        Sale_Transaction_ID = mintSaleTransactionID,
                        Sale_Transaction_Item_ID = Convert.ToInt32(row[colSale_Transaction_Item_ID.DataPropertyName])
                    };
                    modifyTransactionItems.Add(modifiedItem);
                }

                AddSaleTransactionDto model = new AddSaleTransactionDto()
                {
                    IsActive = true,
                    Teller_ID = Convert.ToInt16(General.currentTellerId),
                    Branch_ID = General.branchId,
                    IsBacked = this.IsBacked,
                    Customer_ID = customerId,
                    Transaction_Date = DateTime.Now,
                    Transaction_Notes = transactionNotes,
                    User_Name = "Admin",
                    DiscountAmount = Convert.ToDecimal(string.IsNullOrEmpty(lblDiscount.Text.Trim()) ? "0" : lblDiscount.Text),
                    PayWayId = Convert.ToByte(payWay),
                    PaidAmount = paidAmount,
                    Bank_NO = chequeBankNo,
                    Cheque_No = chequeNo,
                    Cheque_Due_Date = chequeDueDate,
                    PaymentNotes = paymentNotes,
                    Sale_Transaction_ID = mintSaleTransactionID,
                    Delevery_Fees = delevery_Fees,
                    Delevery_Place = delevery_Place,
                    Delevery_Transaction_No = delevery_Transaction_No,
                    items = modifyTransactionItems
                };
                if(amountList != null && amountList.Count > 0)
                {
                    model.PaidAmountList = amountList;
                }
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                ResultModel result = await POS.Client.SaleTransactionRepository.add(model);
                if (result != null)
                {
                    if (result.StatusCode == "200")
                    {
                        Sale_Transaction_Model addedInvoice = (Sale_Transaction_Model)result.Data;
                        mintSaleTransactionID = addedInvoice.Sale_Transaction_ID;// invoiceAdded = true;
                                                                                 //MessageBox.Show("تم الحفظ");
                    }
                }

                return mintSaleTransactionID;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async Task<int> editInvoice()
        {
            try
            {
                ModifyTransactionItemRequest modifiedItem;
                List<ModifyTransactionItemRequest> modifyTransactionItems = new List<ModifyTransactionItemRequest>();
                foreach (DataRow row in moDataTable.Rows)
                {
                    modifiedItem = new ModifyTransactionItemRequest()
                    {
                        Discount_Amount = 0,
                        IsActive = true,
                        IsBacked = false,
                        Item_Unit_ID = Convert.ToInt16(row[colItem_Unit_ID.DataPropertyName]),
                        Item_Unit_Price = Convert.ToDecimal(row[colItem_Unit_Price.DataPropertyName]),
                        Item_Unit_Cost = Convert.ToDecimal(row[colItem_Unit_Cost.DataPropertyName]),
                        Item_Unit_Price_After_Discount = Convert.ToDecimal(row[colItem_Unit_Price.DataPropertyName]),
                        QNT = Convert.ToInt32(row[colQnt.DataPropertyName]),
                        Notes = "",
                        User_Name = "Admin",
                        Sale_Transaction_ID = mintSaleTransactionID,
                        Sale_Transaction_Item_ID = Convert.ToInt32(row[colSale_Transaction_Item_ID.DataPropertyName])
                    };
                    modifyTransactionItems.Add(modifiedItem);
                }

                UpdateSaleTransactionDto model = new UpdateSaleTransactionDto()
                {
                    IsActive = true,
                    Teller_ID = Convert.ToInt16(General.currentTellerId),
                    Branch_ID = General.branchId,
                    Customer_ID = customerId,
                    Transaction_Date = DateTime.Now,
                    Transaction_Notes = transactionNotes,
                    User_Name = "Admin",
                    DiscountAmount = Convert.ToDecimal(string.IsNullOrEmpty(lblDiscount.Text.Trim()) ? "0" : lblDiscount.Text),
                    PayWayId = Convert.ToByte(payWay),
                    Bank_NO = chequeBankNo,
                    Cheque_No = chequeNo,
                    Cheque_Due_Date = chequeDueDate,
                    PaymentNotes = paymentNotes,
                    PaidAmount = paidAmount,
                    Sale_Transaction_ID = mintSaleTransactionID,
                    Delevery_Fees = delevery_Fees,
                    Delevery_Place = delevery_Place,
                    Delevery_Transaction_No = delevery_Transaction_No,
                    items = modifyTransactionItems,
                    DeletedSalesTransactionItems = deletedItems
                };
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                ResultModel result = await POS.Client.SaleTransactionRepository.update(model);
                if (result != null)
                {
                    if (result.StatusCode == "200")
                    {
                        Sale_Transaction_Model addedInvoice = (Sale_Transaction_Model)result.Data;
                        mintSaleTransactionID = addedInvoice.Sale_Transaction_ID;// invoiceAdded = true;
                                                                                 //MessageBox.Show("تم الحفظ");
                    }
                }

                return mintSaleTransactionID;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async Task<int> saveInvoice(List<SaleTransactionPaidAmountDto> PaidAmountList = null)
        {
            //mintSaleTransactionID = 0;
            if (newINvoice == true)
            {
                mintSaleTransactionID = await addInvoice(PaidAmountList);
            }
            else
            {
                mintSaleTransactionID = await editInvoice();
            }

            return mintSaleTransactionID;
        }
        public async void fireSaveInvoice(List<SaleTransactionPaidAmountDto> PaidAmountList=null)
        {
            int saleTransactionId = 0;
            if (moDataTable != null)
            {
                saleTransactionId = await saveInvoice(PaidAmountList);

                if (saleTransactionId > 0)
                    OnInvoiceSaved?.Invoke(this, null);

                DataTable dt = await getInvoiceDataToPrint(saleTransactionId);
                if (dt.Rows.Count > 0)
                {
                    printInvoice(dt);
                }
                clearScreen();
                if (mnuCash.Image != null)
                {
                    // Get the image of the selected menu item
                    Image selectedImage = mnuCash.Image;

                    // Do something with the image (e.g., set it to a button)
                    btnPayWay.Image = selectedImage;
                    payWay = PayWayEnum.Cash;
                }
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            fireSaveInvoice();
        }

        private void grdItemList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //// colDescrease.Index
            //if (e.RowIndex < 0 || (e.ColumnIndex != colIncrease.Index && e.ColumnIndex !=11)) { return; }
            //    if (e.RowIndex < 0 || e.ColumnIndex == colIncrease.Index) 
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    // Load your image
            //    Image img = Properties.Resources.icons8_add_50;// Image.FromFile("your-image-path.png");

            //    // Calculate position
            //    int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
            //    int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

            //    e.Graphics.DrawImage(img, new Point(imgX, imgY));
            //    e.Handled = true;
            //}
            //else if (e.RowIndex < 0 || e.ColumnIndex == 11)// colDescrease.Index
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    // Load your image
            //    Image img = Properties.Resources.icons8_minus_30;// Image.FromFile("your-image-path.png");

            //    // Calculate position
            //    int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
            //    int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

            //    e.Graphics.DrawImage(img, new Point(imgX, imgY));
            //    e.Handled = true;
            //}
        }
        private void calcDiscountPercent()
        {

            lblDiscountPercent.Text = $"{((Convert.ToDecimal(lblDiscount.Text) / Convert.ToDecimal(lblTotalAmount.Text)) * 100).ToString("0.00")} %";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                lblDiscount.Text = Convert.ToString(frm.Result);
                calcDiscountPercent();
                calcTotalAmount();
                OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
            }
        }

        private void grdItemList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
            e.CellStyle.BackColor = Color.White;
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\TabletTip\1.7", "EnableDesktopModeAutoInvoke", 1);
            //Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\Ink\TabTip.exe");

            //NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            //frm.ShowDialog();
            //if (frm.Accepted)
            //{
            //    txtBarcode.Text = Convert.ToString(frm.Result);
            //    searcUsingBarcode();
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnInvoiceCancelClick?.Invoke(this, e);
        }

        private void SoldItemListComponent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalAmount_Paint(object sender, PaintEventArgs e)
        {
        }
        public async void fireSaveInvoiceWithoutPrint()
        {
            if (grdItemList.Rows.Count == 0)
            {
                MessageBox.Show("الفاتوؤة غير مكتملة، لا يوجد اصناف مباعة!");
            }
            else
            {
                if (await saveInvoice() > 0)
                {
                    OnInvoiceSaved?.Invoke(this, null);

                    clearScreen();

                    if (mnuCash.Image != null)
                    {
                        // Get the image of the selected menu item
                        Image selectedImage = mnuCash.Image;

                        // Do something with the image (e.g., set it to a button)
                        btnPayWay.Image = selectedImage;
                        payWay = PayWayEnum.Cash;
                    }
                    //MessageBox.Show("تم الحفظ");
                }
                ;
            }
        }

        public async void fireCancelInvoice()
        {

        }
        private async void btnSaveWithoutPrint_Click(object sender, EventArgs e)
        {
            fireSaveInvoiceWithoutPrint();
        }


        private void btnPayWay_Click(object sender, EventArgs e)
        {
            // Get the button's position
            Point ptLowerLeft = new Point(0, btnPayWay.Height);
            ptLowerLeft = btnPayWay.PointToScreen(ptLowerLeft);

            // Show the context menu at the button's position
            cmnuPayWay.Show(ptLowerLeft);

        }

        private void mnuCash_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            if (selectedItem != null)
            {
                // Get the image of the selected menu item
                Image selectedImage = selectedItem.Image;

                // Do something with the image (e.g., set it to a button)
                btnPayWay.Image = selectedImage;
                payWay = PayWayEnum.Cash;
            }
            customerId = Client.Constants.CashCustomer_ID;
            txtBarcode.Focus();

        }

        private void mnuDebits_Click(object sender, EventArgs e)
        {
            DebitSalesDialog frm = new DebitSalesDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
                if (selectedItem != null)
                {
                    // Get the image of the selected menu item
                    Image selectedImage = selectedItem.Image;

                    // Do something with the image (e.g., set it to a button)
                    btnPayWay.Image = selectedImage;
                    payWay = PayWayEnum.Debits;
                    customerId = Convert.ToInt16(frm.txtPerson_No.Text);
                    paymentNotes = frm.txtTrans_Details.Text.Trim();
                    paidAmount = frm.txtAmount.Value;
                    reCalculateItemPrice();
                }
            }
            txtBarcode.Focus();
        }
        private void mnuCheques_Click(object sender, EventArgs e)
        {
            PayWithChequeDialog frm = new PayWithChequeDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
                if (selectedItem != null)
                {
                    // Get the image of the selected menu item
                    Image selectedImage = selectedItem.Image;

                    // Do something with the image (e.g., set it to a button)
                    btnPayWay.Image = selectedImage;
                    payWay = PayWayEnum.Cheque;
                    chequeNo = frm.txtCheque_No.Text;
                    chequeBankNo = Convert.ToByte(frm.txtBank_ID.Text);
                    chequeDueDate = frm.txtCheque_Due_Date.Value;
                    paymentNotes = frm.txtTrans_Details.Text;
                }
            }
            txtBarcode.Focus();
        }
        private void mnuMoneyTransfere_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            if (selectedItem != null)
            {
                // Get the image of the selected menu item
                Image selectedImage = selectedItem.Image;

                // Do something with the image (e.g., set it to a button)
                btnPayWay.Image = selectedImage;
                payWay = PayWayEnum.Transfere;
            }
            txtBarcode.Focus();
        }

        private void mnuCreditCard_Click(object sender, EventArgs e)
        {
            PayByCreditCardDialog frm = new PayByCreditCardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
                if (selectedItem != null)
                {
                    // Get the image of the selected menu item
                    Image selectedImage = selectedItem.Image;
                    // Do something with the image (e.g., set it to a button)
                    PayWayViewModel pay = new PayWayViewModel()
                    {
                        PayWayID = Convert.ToByte(PayWayEnum.Visa),
                        Amount = frm.Amount
                    };
                    OnPayWayChanged?.Invoke( pay , EventArgs.Empty); // This is the simplified version of the above code.
                    btnPayWay.Image = selectedImage;
                    payWay = PayWayEnum.Visa;
                }
            }
            txtBarcode.Focus();
        }

        private void mnuOnlineSales_Click(object sender, EventArgs e)
        {
            OnlineSaleDialog frm = new OnlineSaleDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
                if (selectedItem != null)
                {
                    // Get the image of the selected menu item
                    Image selectedImage = selectedItem.Image;

                    // Do something with the image (e.g., set it to a button)
                    btnPayWay.Image = selectedImage;
                    customerId = Client.Constants.OnlineCustomer_ID;
                    payWay = PayWayEnum.Debits;
                }
                transactionNotes = frm.txtNotes.Text.Trim();
                delevery_Fees = Convert.ToDecimal(frm.txtDelevery_Fees.Text.Trim());
                delevery_Place = frm.cmbDelevery_Place.Text.Trim();
                delevery_Transaction_No = frm.txtDelevery_Transaction_No.Text.Trim();
            }
            txtBarcode.Focus();
        }
        private async Task<DataTable> getInvoiceDataToPrint(int saleTransactionID)
        {
            DataTable dt = new DataTable();
            InvoiceReportCriteriaViewModel criteria = new InvoiceReportCriteriaViewModel();
            criteria.Sale_Transaction_ID = saleTransactionID;
            ResultModel result = await Client.SaleTransactionRepository.getInvoiceReportData(criteria);
            if (result.StatusCode == "200")
            {
                dt = General.ConvertToDataTable(result.Data);
            }
            return dt;
        }
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            DataTable dt = new ReportsDataset.vInvoiceReportDataTable();
            if (moDataTable != null)
            {
                foreach (DataRow row in moDataTable.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["Sale_Transaction_Item_ID"] = 1;
                    dr["Sale_Transaction_ID"] = 1;
                    dr["Transaction_Date"] = DateTime.Today;
                    //dr["Time_Stamp"] = DateTime.Now;
                    //dr["IsBacked"] = false;


                    dr["Item_Unit_ID"] = Convert.ToInt32(row["Item_Unit_ID"]);
                    dr["QNT"] = Convert.ToInt32(row["QNT"]);
                    dr["Amount"] = Convert.ToDecimal(row["TotalAmount"]);
                    dr["Item_Unit_Price"] = Convert.ToDecimal(row["Item_Unit_Price"]);
                    dr["Discount_Amount"] = 0;
                    dr["Item_Unit_Price_After_Discount"] = 0;
                    dr["Item_Desc"] = Convert.ToString(row["Item_Desc"]);
                    dr["Unit_Desc"] = Convert.ToString(row["Unit_Desc"]);
                    dr["Teller_Name"] = "teller Name";
                    dr["Transaction_Notes"] = "";
                    dr["Customer_Name"] = "";
                    dr["User_Name"] = "admin";

                    dt.Rows.Add(dr);

                }
                printInvoice(dt);
            }
        }

        private void txtBarcode_MouseClick(object sender, MouseEventArgs e)
        {
            //NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            //frm.ShowDialog();
            //if (frm.Accepted)
            //{
            //    txtBarcode.Text = Convert.ToString(frm.Result);
            //    searcUsingBarcode();
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searcUsingBarcode();
        }

        private void btnBarcodeNumericCalc_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.initForm(false);
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtBarcode.Text = Convert.ToString(frm.Result);
                searcUsingBarcode();
            }
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            SearchForItemDialog frm = new SearchForItemDialog();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                txtBarcode.Text = frm.getSelectedItemBarcode();
                searcUsingBarcode();
            }
        }

        private void btnItem_Unit_Price_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                grdItemList.CurrentRow.Cells[colItem_Unit_Price.Name].Value = Convert.ToDecimal(frm.Result);
                grdItemList.Update();
                reCalculateItemPrice();
            }
        }

        private void btnAdjust_Item_QNT_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                grdItemList.CurrentRow.Cells[colQnt.Name].Value = Convert.ToDecimal(frm.Result);
                grdItemList.Update();
                reCalculateItemPrice();
                OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.

            }

        }

        private void btnDiscountPercent_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                decimal discountPercent = Convert.ToDecimal(frm.Result);
                decimal discountAmount = (Convert.ToDecimal(lblTotalAmount.Text) * discountPercent) / 100;
                lblDiscount.Text=discountAmount.ToString("0.00");
                calcDiscountPercent();
                calcTotalAmount();
                OnItemChanged?.Invoke(this, EventArgs.Empty); // This is the simplified version of the above code.
            }
        }
    }
}
