namespace POS.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuFiles = new ToolStripMenuItem();
            mnuItemLIst = new ToolStripMenuItem();
            mnuItemBeginQnt = new ToolStripMenuItem();
            mnuPOS = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbtnItemList = new ToolStripButton();
            tsbtnBookList = new ToolStripButton();
            tsbtnCustomerIndex = new ToolStripButton();
            tsbtnProviders = new ToolStripButton();
            tsbtnPartnerList = new ToolStripButton();
            tsbtnStatementOfAccount = new ToolStripButton();
            tsbtnSalesTransactionList = new ToolStripButton();
            tsbtnVoucherListForm = new ToolStripButton();
            tsbtnSupplyTransactionList = new ToolStripButton();
            tsbtnQabdVoucherList = new ToolStripButton();
            tsbtnOnlineSalesList = new ToolStripButton();
            tsbtnSalesInvoiceList = new ToolStripButton();
            tsbtnPurchaseList = new ToolStripButton();
            tsbtnExpenses = new ToolStripButton();
            tsbtnDashboard = new ToolStripButton();
            tsbtnTicketList = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFiles, mnuPOS });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFiles
            // 
            mnuFiles.DropDownItems.AddRange(new ToolStripItem[] { mnuItemLIst, mnuItemBeginQnt });
            mnuFiles.Name = "mnuFiles";
            mnuFiles.Size = new Size(63, 24);
            mnuFiles.Text = "ملفات";
            // 
            // mnuItemLIst
            // 
            mnuItemLIst.Name = "mnuItemLIst";
            mnuItemLIst.Size = new Size(202, 26);
            mnuItemLIst.Text = "الاصناف";
            mnuItemLIst.Click += mnuItemLIst_Click;
            // 
            // mnuItemBeginQnt
            // 
            mnuItemBeginQnt.Name = "mnuItemBeginQnt";
            mnuItemBeginQnt.Size = new Size(202, 26);
            mnuItemBeginQnt.Text = "الكميات الافتتاحية";
            mnuItemBeginQnt.Click += mnuItemBeginQnt_Click;
            // 
            // mnuPOS
            // 
            mnuPOS.Name = "mnuPOS";
            mnuPOS.Size = new Size(89, 24);
            mnuPOS.Text = "نقطة البيع";
            mnuPOS.Visible = false;
            mnuPOS.Click += mnuPOS_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnItemList, tsbtnBookList, tsbtnCustomerIndex, tsbtnProviders, tsbtnPartnerList, tsbtnStatementOfAccount, tsbtnSalesTransactionList, tsbtnVoucherListForm, tsbtnSupplyTransactionList, tsbtnTicketList, tsbtnQabdVoucherList, tsbtnOnlineSalesList, tsbtnSalesInvoiceList, tsbtnPurchaseList, tsbtnExpenses, tsbtnDashboard });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            toolStrip1.Location = new Point(766, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(148, 570);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnItemList
            // 
            tsbtnItemList.Image = Properties.Resources.ItemList;
            tsbtnItemList.ImageTransparentColor = Color.Magenta;
            tsbtnItemList.Name = "tsbtnItemList";
            tsbtnItemList.Size = new Size(135, 36);
            tsbtnItemList.Text = "قائمة الاصناف";
            tsbtnItemList.TextAlign = ContentAlignment.MiddleLeft;
            tsbtnItemList.Click += tsbtnItemList_Click;
            // 
            // tsbtnBookList
            // 
            tsbtnBookList.ImageTransparentColor = Color.Magenta;
            tsbtnBookList.Name = "tsbtnBookList";
            tsbtnBookList.Size = new Size(87, 24);
            tsbtnBookList.Text = "قائمة الكتب";
            tsbtnBookList.Visible = false;
            tsbtnBookList.Click += tsbtnBookList_Click;
            // 
            // tsbtnCustomerIndex
            // 
            tsbtnCustomerIndex.Image = Properties.Resources.Customer;
            tsbtnCustomerIndex.ImageTransparentColor = Color.Magenta;
            tsbtnCustomerIndex.Name = "tsbtnCustomerIndex";
            tsbtnCustomerIndex.Size = new Size(84, 36);
            tsbtnCustomerIndex.Text = "الزبائن";
            tsbtnCustomerIndex.TextAlign = ContentAlignment.MiddleLeft;
            tsbtnCustomerIndex.Click += tsbtnCustomerIndex_Click;
            // 
            // tsbtnProviders
            // 
            tsbtnProviders.Image = Properties.Resources.icons8_supplier_50;
            tsbtnProviders.ImageTransparentColor = Color.Magenta;
            tsbtnProviders.Name = "tsbtnProviders";
            tsbtnProviders.Size = new Size(99, 36);
            tsbtnProviders.Text = "الموردين";
            tsbtnProviders.Click += tsbtnProviders_Click;
            // 
            // tsbtnPartnerList
            // 
            tsbtnPartnerList.Image = Properties.Resources.stockbroker;
            tsbtnPartnerList.ImageTransparentColor = Color.Magenta;
            tsbtnPartnerList.Name = "tsbtnPartnerList";
            tsbtnPartnerList.Size = new Size(88, 36);
            tsbtnPartnerList.Text = "الشركاء";
            tsbtnPartnerList.Click += tsbtnOwnerList_Click;
            // 
            // tsbtnStatementOfAccount
            // 
            tsbtnStatementOfAccount.Image = Properties.Resources.statement_order1;
            tsbtnStatementOfAccount.ImageTransparentColor = Color.Magenta;
            tsbtnStatementOfAccount.Name = "tsbtnStatementOfAccount";
            tsbtnStatementOfAccount.Size = new Size(125, 36);
            tsbtnStatementOfAccount.Text = "كشف حساب";
            tsbtnStatementOfAccount.Visible = false;
            tsbtnStatementOfAccount.Click += tsbtnStatementOfAccount_Click;
            // 
            // tsbtnSalesTransactionList
            // 
            tsbtnSalesTransactionList.ImageTransparentColor = Color.Magenta;
            tsbtnSalesTransactionList.Name = "tsbtnSalesTransactionList";
            tsbtnSalesTransactionList.Size = new Size(85, 24);
            tsbtnSalesTransactionList.Text = "حركات البيع";
            tsbtnSalesTransactionList.TextAlign = ContentAlignment.MiddleLeft;
            tsbtnSalesTransactionList.Visible = false;
            tsbtnSalesTransactionList.Click += tsbtnSalesTransactionList_Click;
            // 
            // tsbtnVoucherListForm
            // 
            tsbtnVoucherListForm.ImageTransparentColor = Color.Magenta;
            tsbtnVoucherListForm.Name = "tsbtnVoucherListForm";
            tsbtnVoucherListForm.Size = new Size(144, 24);
            tsbtnVoucherListForm.Text = "قائمة الحركات المالية";
            tsbtnVoucherListForm.TextAlign = ContentAlignment.MiddleLeft;
            tsbtnVoucherListForm.Visible = false;
            tsbtnVoucherListForm.Click += tsbtnVoucherListForm_Click;
            // 
            // tsbtnSupplyTransactionList
            // 
            tsbtnSupplyTransactionList.Image = Properties.Resources.icons8_supply_chain_50;
            tsbtnSupplyTransactionList.ImageTransparentColor = Color.Magenta;
            tsbtnSupplyTransactionList.Name = "tsbtnSupplyTransactionList";
            tsbtnSupplyTransactionList.Size = new Size(134, 36);
            tsbtnSupplyTransactionList.Text = "توريد الاصناف";
            tsbtnSupplyTransactionList.Click += tsbtnSupplyTransactionList_Click;
            // 
            // tsbtnQabdVoucherList
            // 
            tsbtnQabdVoucherList.ImageTransparentColor = Color.Magenta;
            tsbtnQabdVoucherList.Name = "tsbtnQabdVoucherList";
            tsbtnQabdVoucherList.Size = new Size(123, 24);
            tsbtnQabdVoucherList.Text = "قائمة المقبوضات";
            tsbtnQabdVoucherList.Visible = false;
            tsbtnQabdVoucherList.Click += tsbtnQabdVoucherList_Click;
            // 
            // tsbtnOnlineSalesList
            // 
            tsbtnOnlineSalesList.Image = Properties.Resources.icons8_sales_50;
            tsbtnOnlineSalesList.ImageTransparentColor = Color.Magenta;
            tsbtnOnlineSalesList.Name = "tsbtnOnlineSalesList";
            tsbtnOnlineSalesList.Size = new Size(100, 36);
            tsbtnOnlineSalesList.Text = "المبيعات";
            tsbtnOnlineSalesList.Click += tsbtnOnlineSalesList_Click;
            // 
            // tsbtnSalesInvoiceList
            // 
            tsbtnSalesInvoiceList.ImageTransparentColor = Color.Magenta;
            tsbtnSalesInvoiceList.Name = "tsbtnSalesInvoiceList";
            tsbtnSalesInvoiceList.Size = new Size(146, 24);
            tsbtnSalesInvoiceList.Text = "قائمة فواتير المبيعات";
            tsbtnSalesInvoiceList.Visible = false;
            tsbtnSalesInvoiceList.Click += tsbtnSalesInvoiceList_Click;
            // 
            // tsbtnPurchaseList
            // 
            tsbtnPurchaseList.Image = Properties.Resources.icons8_invoice_50;
            tsbtnPurchaseList.ImageTransparentColor = Color.Magenta;
            tsbtnPurchaseList.Name = "tsbtnPurchaseList";
            tsbtnPurchaseList.Size = new Size(142, 36);
            tsbtnPurchaseList.Text = "فواتير مشتريات";
            tsbtnPurchaseList.Click += tsbtnPurchaseList_Click;
            // 
            // tsbtnExpenses
            // 
            tsbtnExpenses.Image = Properties.Resources.icons8_expenses_50;
            tsbtnExpenses.ImageTransparentColor = Color.Magenta;
            tsbtnExpenses.Name = "tsbtnExpenses";
            tsbtnExpenses.Size = new Size(147, 36);
            tsbtnExpenses.Text = "قائمة المصاريف";
            tsbtnExpenses.Click += tsbtnExpenses_Click;
            // 
            // tsbtnDashboard
            // 
            tsbtnDashboard.Image = Properties.Resources.icons8_cash_receipt_50;
            tsbtnDashboard.ImageTransparentColor = Color.Magenta;
            tsbtnDashboard.Name = "tsbtnDashboard";
            tsbtnDashboard.Size = new Size(137, 36);
            tsbtnDashboard.Text = "ملخص الاعمال";
            tsbtnDashboard.Click += tsbtnDashboard_Click;
            // 
            // tsbtnTicketList
            // 
            tsbtnTicketList.Image = Properties.Resources.ticket;
            tsbtnTicketList.ImageTransparentColor = Color.Magenta;
            tsbtnTicketList.Name = "tsbtnTicketList";
            tsbtnTicketList.Size = new Size(85, 36);
            tsbtnTicketList.Text = "التذاكر";
            tsbtnTicketList.Click += tsbtnTicketList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الدبعي للالعاب";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFiles;
        private ToolStripMenuItem mnuPOS;
        private ToolStripMenuItem mnuItemLIst;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnItemList;
        private ToolStripButton tsbtnCustomerIndex;
        private ToolStripButton tsbtnVoucherListForm;
        private ToolStripButton tsbtnSalesTransactionList;
        private ToolStripMenuItem mnuItemBeginQnt;
        private ToolStripButton tsbtnExpenses;
        private ToolStripButton tsbtnSalesInvoiceList;
        private ToolStripButton tsbtnQabdVoucherList;
        private ToolStripButton tsbtnPurchaseList;
        private ToolStripButton tsbtnStatementOfAccount;
        private ToolStripButton tsbtnProviders;
        private ToolStripButton tsbtnPartnerList;
        private ToolStripButton tsbtnOnlineSalesList;
        private ToolStripButton tsbtnDebitSalesList;
        private ToolStripButton tsbtnDashboard;
        private ToolStripButton tsbtnSupplyTransactionList;
        private ToolStripButton tsbtnBookList;
        private ToolStripButton tsbtnTicketList;
    }
}
