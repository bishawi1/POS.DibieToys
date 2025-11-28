namespace POS.Windows.Forms
{
    partial class OnlineSalesTransactionListForm
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
            label1 = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            label2 = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            grdVoucherList = new DataGridView();
            colSale_Transaction_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_No = new DataGridViewTextBoxColumn();
            colTeller_ID = new DataGridViewTextBoxColumn();
            colTeller_Name = new DataGridViewTextBoxColumn();
            colCustomer_ID = new DataGridViewTextBoxColumn();
            colCustomer_Name = new DataGridViewTextBoxColumn();
            colTransaction_Date = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDelevery_Transaction_No = new DataGridViewTextBoxColumn();
            colDelevery_Place = new DataGridViewTextBoxColumn();
            colDelevery_Fees = new DataGridViewTextBoxColumn();
            colTotal_Amount = new DataGridViewTextBoxColumn();
            colRemainAmount = new DataGridViewTextBoxColumn();
            colTransaction_Notes = new DataGridViewTextBoxColumn();
            btnGetData = new Button();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnAddForProvider = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            tsbtnPrint = new ToolStripButton();
            label3 = new Label();
            lblTotalAmount = new Label();
            cmbPayStatusId = new ComboBox();
            cmbSalesType = new ComboBox();
            label4 = new Label();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            lblPerson = new Label();
            label5 = new Label();
            lblRemainAmount = new Label();
            panel1 = new Panel();
            label6 = new Label();
            cmbBranch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(478, 14);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 18;
            label1.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.Checked = false;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(316, 14);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(154, 27);
            txtTo_Trans_Date.TabIndex = 19;
            txtTo_Trans_Date.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(698, 14);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 16;
            label2.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(529, 14);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(154, 27);
            txtFrom_Trans_Date.TabIndex = 17;
            txtFrom_Trans_Date.TabStop = false;
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
            grdVoucherList.Columns.AddRange(new DataGridViewColumn[] { colSale_Transaction_ID, colSale_Transaction_No, colTeller_ID, colTeller_Name, colCustomer_ID, colCustomer_Name, colTransaction_Date, colAmount, colDelevery_Transaction_No, colDelevery_Place, colDelevery_Fees, colTotal_Amount, colRemainAmount, colTransaction_Notes });
            grdVoucherList.Location = new Point(12, 166);
            grdVoucherList.Margin = new Padding(3, 4, 3, 4);
            grdVoucherList.Name = "grdVoucherList";
            grdVoucherList.ReadOnly = true;
            grdVoucherList.RowHeadersWidth = 51;
            grdVoucherList.RowTemplate.Height = 25;
            grdVoucherList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVoucherList.Size = new Size(1017, 463);
            grdVoucherList.TabIndex = 15;
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
            colCustomer_Name.Visible = false;
            colCustomer_Name.Width = 125;
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
            // colDelevery_Transaction_No
            // 
            colDelevery_Transaction_No.DataPropertyName = "Delevery_Transaction_No";
            colDelevery_Transaction_No.HeaderText = "رقم البوليصة";
            colDelevery_Transaction_No.MinimumWidth = 6;
            colDelevery_Transaction_No.Name = "colDelevery_Transaction_No";
            colDelevery_Transaction_No.ReadOnly = true;
            colDelevery_Transaction_No.Width = 125;
            // 
            // colDelevery_Place
            // 
            colDelevery_Place.DataPropertyName = "Delevery_Place";
            colDelevery_Place.HeaderText = "مكان التوصيل";
            colDelevery_Place.MinimumWidth = 6;
            colDelevery_Place.Name = "colDelevery_Place";
            colDelevery_Place.ReadOnly = true;
            colDelevery_Place.Width = 125;
            // 
            // colDelevery_Fees
            // 
            colDelevery_Fees.DataPropertyName = "Delevery_Fees";
            colDelevery_Fees.HeaderText = "اجرة التوصيل";
            colDelevery_Fees.MinimumWidth = 6;
            colDelevery_Fees.Name = "colDelevery_Fees";
            colDelevery_Fees.ReadOnly = true;
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
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(42, 14);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 14;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnAddForProvider, tsbtnDetails, tsbtnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1041, 39);
            toolStrip1.TabIndex = 26;
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
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(846, 637);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 27;
            label3.Text = "المجموع";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalAmount.BackColor = Color.White;
            lblTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            lblTotalAmount.Location = new Point(710, 637);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(117, 34);
            lblTotalAmount.TabIndex = 28;
            // 
            // cmbPayStatusId
            // 
            cmbPayStatusId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPayStatusId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayStatusId.FormattingEnabled = true;
            cmbPayStatusId.Items.AddRange(new object[] { "الجميع", "غير المسدد", "المسدد" });
            cmbPayStatusId.Location = new Point(147, 16);
            cmbPayStatusId.Name = "cmbPayStatusId";
            cmbPayStatusId.Size = new Size(151, 28);
            cmbPayStatusId.TabIndex = 29;
            // 
            // cmbSalesType
            // 
            cmbSalesType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSalesType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalesType.FormattingEnabled = true;
            cmbSalesType.Items.AddRange(new object[] { "الجميع", "اون لاين", "ذمم", "نقدي" });
            cmbSalesType.Location = new Point(534, 48);
            cmbSalesType.Name = "cmbSalesType";
            cmbSalesType.Size = new Size(151, 28);
            cmbSalesType.TabIndex = 30;
            cmbSalesType.SelectedIndexChanged += cmbSalesType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(689, 48);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 31;
            label4.Text = "نوع الحركة";
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(56, 53);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 34;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(83, 57);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 33;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(3, 53);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(47, 27);
            lblPerson_Name.TabIndex = 35;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(30, 60);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(47, 20);
            lblPerson.TabIndex = 32;
            lblPerson.Text = "الزبون";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(392, 637);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 36;
            label5.Text = "المبلغ المتبقي";
            // 
            // lblRemainAmount
            // 
            lblRemainAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRemainAmount.BackColor = Color.White;
            lblRemainAmount.BorderStyle = BorderStyle.FixedSingle;
            lblRemainAmount.Location = new Point(269, 637);
            lblRemainAmount.Name = "lblRemainAmount";
            lblRemainAmount.Size = new Size(117, 34);
            lblRemainAmount.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbBranch);
            panel1.Controls.Add(btnShow_Person_ID_LOV);
            panel1.Controls.Add(txtPerson_No);
            panel1.Controls.Add(lblPerson_Name);
            panel1.Controls.Add(lblPerson);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbSalesType);
            panel1.Controls.Add(cmbPayStatusId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTo_Trans_Date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFrom_Trans_Date);
            panel1.Controls.Add(btnGetData);
            panel1.Location = new Point(223, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 102);
            panel1.TabIndex = 38;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(478, 48);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 37;
            label6.Text = "الفرع";
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(248, 48);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(222, 28);
            cmbBranch.TabIndex = 36;
            // 
            // OnlineSalesTransactionListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 680);
            Controls.Add(panel1);
            Controls.Add(lblRemainAmount);
            Controls.Add(label5);
            Controls.Add(lblTotalAmount);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(grdVoucherList);
            KeyPreview = true;
            Name = "OnlineSalesTransactionListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة المبيعات";
            Load += OnlineSalesTransactionListForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker txtTo_Trans_Date;
        private Label label2;
        private DateTimePicker txtFrom_Trans_Date;
        private DataGridView grdVoucherList;
        private Button btnGetData;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnAddForProvider;
        private ToolStripButton tsbtnDetails;
        private ToolStripButton tsbtnPrint;
        private DataGridViewTextBoxColumn colVoucher_ID;
        private DataGridViewTextBoxColumn colvoucher_Type_ID;
        private DataGridViewTextBoxColumn colVoucher_Type_Desc;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colPerson_Name;
        private DataGridViewTextBoxColumn colDebit_Amount;
        private DataGridViewTextBoxColumn colCredit_Amount;
        private DataGridViewTextBoxColumn colVoucher_Currency_ID;
        private DataGridViewTextBoxColumn colCurrency_Name;
        private DataGridViewTextBoxColumn colVoucher_Details;
        private DataGridViewTextBoxColumn colBank_Name;
        private DataGridViewTextBoxColumn colCheque_No;
        private DataGridViewTextBoxColumn colCheque_Due_Date;
        private DataGridViewTextBoxColumn colVoucher_Currency_Rate;
        private DataGridViewTextBoxColumn colPay_Way_Id;
        private DataGridViewTextBoxColumn colPay_Way_Desc;
        private DataGridViewTextBoxColumn colVoucher_Date;
        private Label label3;
        private Label lblTotalAmount;
        private Label label4;
        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private DataGridViewTextBoxColumn colSale_Transaction_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_No;
        private DataGridViewTextBoxColumn colTeller_ID;
        private DataGridViewTextBoxColumn colTeller_Name;
        private DataGridViewTextBoxColumn colCustomer_ID;
        private DataGridViewTextBoxColumn colCustomer_Name;
        private DataGridViewTextBoxColumn colTransaction_Date;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDelevery_Transaction_No;
        private DataGridViewTextBoxColumn colDelevery_Place;
        private DataGridViewTextBoxColumn colDelevery_Fees;
        private DataGridViewTextBoxColumn colTotal_Amount;
        private DataGridViewTextBoxColumn colRemainAmount;
        private DataGridViewTextBoxColumn colTransaction_Notes;
        private Label label5;
        private Label lblRemainAmount;
        public ComboBox cmbSalesType;
        public ComboBox cmbPayStatusId;
        private Panel panel1;
        private Label label6;
        private ComboBox cmbBranch;
    }
}