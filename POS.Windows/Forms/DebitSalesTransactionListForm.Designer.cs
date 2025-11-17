namespace POS.Windows.Forms
{
    partial class DebitSalesTransactionListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnAddForProvider = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            tsbtnPrint = new ToolStripButton();
            cmbPayStatusId = new ComboBox();
            label1 = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            label2 = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            btnGetData = new Button();
            grdVoucherList = new DataGridView();
            lblTotalAmount = new Label();
            label3 = new Label();
            colSale_Transaction_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_No = new DataGridViewTextBoxColumn();
            colTeller_ID = new DataGridViewTextBoxColumn();
            colTeller_Name = new DataGridViewTextBoxColumn();
            colCustomer_ID = new DataGridViewTextBoxColumn();
            colCustomer_Name = new DataGridViewTextBoxColumn();
            colDelevery_Transaction_No = new DataGridViewTextBoxColumn();
            colTransaction_Date = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDelevery_Place = new DataGridViewTextBoxColumn();
            colDelevery_Fees = new DataGridViewTextBoxColumn();
            colTotal_Amount = new DataGridViewTextBoxColumn();
            colRemainAmount = new DataGridViewTextBoxColumn();
            colTransaction_Notes = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnAddForProvider, tsbtnDetails, tsbtnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1041, 39);
            toolStrip1.TabIndex = 27;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            tsbtnAdd.Image = Properties.Resources.icons8_cash_receipt_50;
            tsbtnAdd.ImageTransparentColor = Color.Magenta;
            tsbtnAdd.Name = "tsbtnAdd";
            tsbtnAdd.Size = new Size(112, 36);
            tsbtnAdd.Text = "قبض جديد";
            tsbtnAdd.Click += tsbtnAdd_Click;
            // 
            // tsbtnAddForProvider
            // 
            tsbtnAddForProvider.Image = Properties.Resources.icons8_cash_receipt_50;
            tsbtnAddForProvider.ImageTransparentColor = Color.Magenta;
            tsbtnAddForProvider.Name = "tsbtnAddForProvider";
            tsbtnAddForProvider.Size = new Size(155, 36);
            tsbtnAddForProvider.Text = "قائمة المقبوضات";
            tsbtnAddForProvider.Click += tsbtnAddForProvider_Click;
            // 
            // tsbtnDetails
            // 
            tsbtnDetails.Image = Properties.Resources.view_details;
            tsbtnDetails.ImageTransparentColor = Color.Magenta;
            tsbtnDetails.Name = "tsbtnDetails";
            tsbtnDetails.Size = new Size(92, 36);
            tsbtnDetails.Text = "تفاصيل";
            tsbtnDetails.Click += tsbtnDetails_Click;
            // 
            // tsbtnPrint
            // 
            tsbtnPrint.Image = Properties.Resources.print;
            tsbtnPrint.ImageTransparentColor = Color.Magenta;
            tsbtnPrint.Name = "tsbtnPrint";
            tsbtnPrint.Size = new Size(84, 36);
            tsbtnPrint.Text = "طباعة";
            // 
            // cmbPayStatusId
            // 
            cmbPayStatusId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayStatusId.FormattingEnabled = true;
            cmbPayStatusId.Items.AddRange(new object[] { "الجميع", "غير المسدد", "المسدد" });
            cmbPayStatusId.Location = new Point(392, 45);
            cmbPayStatusId.Name = "cmbPayStatusId";
            cmbPayStatusId.Size = new Size(151, 28);
            cmbPayStatusId.TabIndex = 35;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(725, 43);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 33;
            label1.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.Checked = false;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(563, 43);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(154, 27);
            txtTo_Trans_Date.TabIndex = 34;
            txtTo_Trans_Date.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(945, 43);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 31;
            label2.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(776, 43);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(154, 27);
            txtFrom_Trans_Date.TabIndex = 32;
            txtFrom_Trans_Date.TabStop = false;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(289, 43);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 30;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // grdVoucherList
            // 
            grdVoucherList.AllowUserToAddRows = false;
            grdVoucherList.AllowUserToDeleteRows = false;
            grdVoucherList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVoucherList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVoucherList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVoucherList.Columns.AddRange(new DataGridViewColumn[] { colSale_Transaction_ID, colSale_Transaction_No, colTeller_ID, colTeller_Name, colCustomer_ID, colCustomer_Name, colDelevery_Transaction_No, colTransaction_Date, colAmount, colDelevery_Place, colDelevery_Fees, colTotal_Amount, colRemainAmount, colTransaction_Notes });
            grdVoucherList.Location = new Point(15, 82);
            grdVoucherList.Margin = new Padding(3, 4, 3, 4);
            grdVoucherList.Name = "grdVoucherList";
            grdVoucherList.ReadOnly = true;
            grdVoucherList.RowHeadersWidth = 51;
            grdVoucherList.RowTemplate.Height = 25;
            grdVoucherList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVoucherList.Size = new Size(1017, 534);
            grdVoucherList.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalAmount.BackColor = Color.White;
            lblTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            lblTotalAmount.Location = new Point(829, 637);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(117, 34);
            lblTotalAmount.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(965, 637);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 37;
            label3.Text = "المجموع";
            // 
            // colSale_Transaction_ID
            // 
            colSale_Transaction_ID.DataPropertyName = "Sale_Transaction_ID";
            colSale_Transaction_ID.HeaderText = "Sale_Transaction_ID";
            colSale_Transaction_ID.MinimumWidth = 6;
            colSale_Transaction_ID.Name = "colSale_Transaction_ID";
            colSale_Transaction_ID.ReadOnly = true;
            colSale_Transaction_ID.Visible = false;
            colSale_Transaction_ID.Width = 125;
            // 
            // colSale_Transaction_No
            // 
            colSale_Transaction_No.DataPropertyName = "Sale_Transaction_No";
            colSale_Transaction_No.HeaderText = "Sale_Transaction_No";
            colSale_Transaction_No.MinimumWidth = 6;
            colSale_Transaction_No.Name = "colSale_Transaction_No";
            colSale_Transaction_No.ReadOnly = true;
            colSale_Transaction_No.Visible = false;
            colSale_Transaction_No.Width = 125;
            // 
            // colTeller_ID
            // 
            colTeller_ID.DataPropertyName = "Teller_ID";
            colTeller_ID.HeaderText = "Teller_ID";
            colTeller_ID.MinimumWidth = 6;
            colTeller_ID.Name = "colTeller_ID";
            colTeller_ID.ReadOnly = true;
            colTeller_ID.Visible = false;
            colTeller_ID.Width = 125;
            // 
            // colTeller_Name
            // 
            colTeller_Name.DataPropertyName = "Teller_Name";
            colTeller_Name.HeaderText = "Teller_Name";
            colTeller_Name.MinimumWidth = 6;
            colTeller_Name.Name = "colTeller_Name";
            colTeller_Name.ReadOnly = true;
            colTeller_Name.Visible = false;
            colTeller_Name.Width = 125;
            // 
            // colCustomer_ID
            // 
            colCustomer_ID.DataPropertyName = "Customer_ID";
            colCustomer_ID.HeaderText = "Customer_ID";
            colCustomer_ID.MinimumWidth = 6;
            colCustomer_ID.Name = "colCustomer_ID";
            colCustomer_ID.ReadOnly = true;
            colCustomer_ID.Visible = false;
            colCustomer_ID.Width = 125;
            // 
            // colCustomer_Name
            // 
            colCustomer_Name.DataPropertyName = "Customer_Name";
            colCustomer_Name.HeaderText = "الزبون";
            colCustomer_Name.MinimumWidth = 6;
            colCustomer_Name.Name = "colCustomer_Name";
            colCustomer_Name.ReadOnly = true;
            colCustomer_Name.Width = 200;
            // 
            // colDelevery_Transaction_No
            // 
            colDelevery_Transaction_No.DataPropertyName = "Delevery_Transaction_No";
            colDelevery_Transaction_No.HeaderText = "رقم البوليصة";
            colDelevery_Transaction_No.MinimumWidth = 6;
            colDelevery_Transaction_No.Name = "colDelevery_Transaction_No";
            colDelevery_Transaction_No.ReadOnly = true;
            colDelevery_Transaction_No.Visible = false;
            colDelevery_Transaction_No.Width = 125;
            // 
            // colTransaction_Date
            // 
            colTransaction_Date.DataPropertyName = "Transaction_Date";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colTransaction_Date.DefaultCellStyle = dataGridViewCellStyle2;
            colTransaction_Date.HeaderText = "التاريخ";
            colTransaction_Date.MinimumWidth = 6;
            colTransaction_Date.Name = "colTransaction_Date";
            colTransaction_Date.ReadOnly = true;
            colTransaction_Date.Width = 125;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            colAmount.HeaderText = "المبلغ";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 125;
            // 
            // colDelevery_Place
            // 
            colDelevery_Place.DataPropertyName = "Delevery_Place";
            colDelevery_Place.HeaderText = "مكان التوصيل";
            colDelevery_Place.MinimumWidth = 6;
            colDelevery_Place.Name = "colDelevery_Place";
            colDelevery_Place.ReadOnly = true;
            colDelevery_Place.Visible = false;
            colDelevery_Place.Width = 125;
            // 
            // colDelevery_Fees
            // 
            colDelevery_Fees.DataPropertyName = "Delevery_Fees";
            colDelevery_Fees.HeaderText = "اجرة التوصيل";
            colDelevery_Fees.MinimumWidth = 6;
            colDelevery_Fees.Name = "colDelevery_Fees";
            colDelevery_Fees.ReadOnly = true;
            colDelevery_Fees.Visible = false;
            colDelevery_Fees.Width = 125;
            // 
            // colTotal_Amount
            // 
            colTotal_Amount.DataPropertyName = "Total_Amount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colTotal_Amount.DefaultCellStyle = dataGridViewCellStyle3;
            colTotal_Amount.HeaderText = "المجموع";
            colTotal_Amount.MinimumWidth = 6;
            colTotal_Amount.Name = "colTotal_Amount";
            colTotal_Amount.ReadOnly = true;
            colTotal_Amount.Visible = false;
            colTotal_Amount.Width = 125;
            // 
            // colRemainAmount
            // 
            colRemainAmount.DataPropertyName = "RemainAmount";
            colRemainAmount.HeaderText = "المتبقي";
            colRemainAmount.MinimumWidth = 6;
            colRemainAmount.Name = "colRemainAmount";
            colRemainAmount.ReadOnly = true;
            colRemainAmount.Width = 125;
            // 
            // colTransaction_Notes
            // 
            colTransaction_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTransaction_Notes.DataPropertyName = "Transaction_Notes";
            colTransaction_Notes.HeaderText = "ملاحظات";
            colTransaction_Notes.MinimumWidth = 6;
            colTransaction_Notes.Name = "colTransaction_Notes";
            colTransaction_Notes.ReadOnly = true;
            // 
            // DebitSalesTransactionListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 680);
            Controls.Add(lblTotalAmount);
            Controls.Add(label3);
            Controls.Add(grdVoucherList);
            Controls.Add(cmbPayStatusId);
            Controls.Add(label1);
            Controls.Add(txtTo_Trans_Date);
            Controls.Add(label2);
            Controls.Add(txtFrom_Trans_Date);
            Controls.Add(btnGetData);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Name = "DebitSalesTransactionListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مبيعات الذمم";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnAddForProvider;
        private ToolStripButton tsbtnDetails;
        private ToolStripButton tsbtnPrint;
        private ComboBox cmbPayStatusId;
        private Label label1;
        private DateTimePicker txtTo_Trans_Date;
        private Label label2;
        private DateTimePicker txtFrom_Trans_Date;
        private Button btnGetData;
        private DataGridView grdVoucherList;
        private Label lblTotalAmount;
        private Label label3;
        private DataGridViewTextBoxColumn colSale_Transaction_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_No;
        private DataGridViewTextBoxColumn colTeller_ID;
        private DataGridViewTextBoxColumn colTeller_Name;
        private DataGridViewTextBoxColumn colCustomer_ID;
        private DataGridViewTextBoxColumn colCustomer_Name;
        private DataGridViewTextBoxColumn colDelevery_Transaction_No;
        private DataGridViewTextBoxColumn colTransaction_Date;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDelevery_Place;
        private DataGridViewTextBoxColumn colDelevery_Fees;
        private DataGridViewTextBoxColumn colTotal_Amount;
        private DataGridViewTextBoxColumn colRemainAmount;
        private DataGridViewTextBoxColumn colTransaction_Notes;
    }
}