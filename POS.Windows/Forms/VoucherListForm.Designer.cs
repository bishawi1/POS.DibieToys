namespace POS.Windows.Forms
{
    partial class VoucherListForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnGetData = new Button();
            grdVoucherList = new DataGridView();
            colVoucher_ID = new DataGridViewTextBoxColumn();
            colvoucher_Type_ID = new DataGridViewTextBoxColumn();
            colVoucher_Type_Desc = new DataGridViewTextBoxColumn();
            colPerson_ID = new DataGridViewTextBoxColumn();
            colVoucher_Date = new DataGridViewTextBoxColumn();
            colPerson_Name = new DataGridViewTextBoxColumn();
            colDebit_Amount = new DataGridViewTextBoxColumn();
            colCredit_Amount = new DataGridViewTextBoxColumn();
            colVoucher_Currency_ID = new DataGridViewTextBoxColumn();
            colCurrency_Name = new DataGridViewTextBoxColumn();
            colVoucher_Details = new DataGridViewTextBoxColumn();
            colBank_Name = new DataGridViewTextBoxColumn();
            colCheque_No = new DataGridViewTextBoxColumn();
            colCheque_Due_Date = new DataGridViewTextBoxColumn();
            colVoucher_Currency_Rate = new DataGridViewTextBoxColumn();
            colPay_Way_Id = new DataGridViewTextBoxColumn();
            colPay_Way_Desc = new DataGridViewTextBoxColumn();
            colManual_Voucher_No = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnuChangeVoucherType = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            tsbtnPrint = new ToolStripButton();
            label2 = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            label1 = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            lblPerson = new Label();
            label3 = new Label();
            cmbPay_Way_Id = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(146, 52);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 0;
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
            grdVoucherList.Columns.AddRange(new DataGridViewColumn[] { colVoucher_ID, colvoucher_Type_ID, colVoucher_Type_Desc, colPerson_ID, colVoucher_Date, colPerson_Name, colDebit_Amount, colCredit_Amount, colVoucher_Currency_ID, colCurrency_Name, colVoucher_Details, colBank_Name, colCheque_No, colCheque_Due_Date, colVoucher_Currency_Rate, colPay_Way_Id, colPay_Way_Desc, colManual_Voucher_No });
            grdVoucherList.ContextMenuStrip = contextMenuStrip1;
            grdVoucherList.Location = new Point(14, 165);
            grdVoucherList.Margin = new Padding(3, 4, 3, 4);
            grdVoucherList.Name = "grdVoucherList";
            grdVoucherList.ReadOnly = true;
            grdVoucherList.RowHeadersWidth = 51;
            grdVoucherList.RowTemplate.Height = 25;
            grdVoucherList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVoucherList.Size = new Size(1175, 442);
            grdVoucherList.TabIndex = 1;
            grdVoucherList.CellDoubleClick += grdVoucherList_CellDoubleClick;
            // 
            // colVoucher_ID
            // 
            colVoucher_ID.DataPropertyName = "Voucher_ID";
            colVoucher_ID.HeaderText = "Voucher_ID";
            colVoucher_ID.MinimumWidth = 6;
            colVoucher_ID.Name = "colVoucher_ID";
            colVoucher_ID.ReadOnly = true;
            colVoucher_ID.Visible = false;
            colVoucher_ID.Width = 125;
            // 
            // colvoucher_Type_ID
            // 
            colvoucher_Type_ID.DataPropertyName = "voucher_Type_ID";
            colvoucher_Type_ID.HeaderText = "voucher_Type_ID";
            colvoucher_Type_ID.MinimumWidth = 6;
            colvoucher_Type_ID.Name = "colvoucher_Type_ID";
            colvoucher_Type_ID.ReadOnly = true;
            colvoucher_Type_ID.Visible = false;
            colvoucher_Type_ID.Width = 125;
            // 
            // colVoucher_Type_Desc
            // 
            colVoucher_Type_Desc.DataPropertyName = "Voucher_Type_Desc";
            colVoucher_Type_Desc.HeaderText = "Voucher_Type_Desc";
            colVoucher_Type_Desc.MinimumWidth = 6;
            colVoucher_Type_Desc.Name = "colVoucher_Type_Desc";
            colVoucher_Type_Desc.ReadOnly = true;
            colVoucher_Type_Desc.Visible = false;
            colVoucher_Type_Desc.Width = 125;
            // 
            // colPerson_ID
            // 
            colPerson_ID.DataPropertyName = "Person_ID";
            colPerson_ID.HeaderText = "Person_ID";
            colPerson_ID.MinimumWidth = 6;
            colPerson_ID.Name = "colPerson_ID";
            colPerson_ID.ReadOnly = true;
            colPerson_ID.Visible = false;
            colPerson_ID.Width = 125;
            // 
            // colVoucher_Date
            // 
            colVoucher_Date.DataPropertyName = "Voucher_Date";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colVoucher_Date.DefaultCellStyle = dataGridViewCellStyle2;
            colVoucher_Date.HeaderText = "التاريخ";
            colVoucher_Date.MinimumWidth = 6;
            colVoucher_Date.Name = "colVoucher_Date";
            colVoucher_Date.ReadOnly = true;
            colVoucher_Date.Width = 125;
            // 
            // colPerson_Name
            // 
            colPerson_Name.DataPropertyName = "Person_Name";
            colPerson_Name.HeaderText = "الزبون";
            colPerson_Name.MinimumWidth = 6;
            colPerson_Name.Name = "colPerson_Name";
            colPerson_Name.ReadOnly = true;
            colPerson_Name.Width = 200;
            // 
            // colDebit_Amount
            // 
            colDebit_Amount.DataPropertyName = "Debit_Amount";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            colDebit_Amount.DefaultCellStyle = dataGridViewCellStyle3;
            colDebit_Amount.HeaderText = "مبلغ مدين";
            colDebit_Amount.MinimumWidth = 6;
            colDebit_Amount.Name = "colDebit_Amount";
            colDebit_Amount.ReadOnly = true;
            colDebit_Amount.Width = 125;
            // 
            // colCredit_Amount
            // 
            colCredit_Amount.DataPropertyName = "Credit_Amount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            colCredit_Amount.DefaultCellStyle = dataGridViewCellStyle4;
            colCredit_Amount.HeaderText = "مبلغ دائن";
            colCredit_Amount.MinimumWidth = 6;
            colCredit_Amount.Name = "colCredit_Amount";
            colCredit_Amount.ReadOnly = true;
            colCredit_Amount.Width = 125;
            // 
            // colVoucher_Currency_ID
            // 
            colVoucher_Currency_ID.DataPropertyName = "Voucher_Currency_ID";
            colVoucher_Currency_ID.HeaderText = "Voucher_Currency_ID";
            colVoucher_Currency_ID.MinimumWidth = 6;
            colVoucher_Currency_ID.Name = "colVoucher_Currency_ID";
            colVoucher_Currency_ID.ReadOnly = true;
            colVoucher_Currency_ID.Visible = false;
            colVoucher_Currency_ID.Width = 125;
            // 
            // colCurrency_Name
            // 
            colCurrency_Name.DataPropertyName = "Currency_Name";
            colCurrency_Name.HeaderText = "العملة";
            colCurrency_Name.MinimumWidth = 6;
            colCurrency_Name.Name = "colCurrency_Name";
            colCurrency_Name.ReadOnly = true;
            colCurrency_Name.Width = 125;
            // 
            // colVoucher_Details
            // 
            colVoucher_Details.DataPropertyName = "Voucher_Details";
            colVoucher_Details.HeaderText = "البيان";
            colVoucher_Details.MinimumWidth = 6;
            colVoucher_Details.Name = "colVoucher_Details";
            colVoucher_Details.ReadOnly = true;
            colVoucher_Details.Width = 200;
            // 
            // colBank_Name
            // 
            colBank_Name.DataPropertyName = "Bank_Name";
            colBank_Name.HeaderText = "البنك";
            colBank_Name.MinimumWidth = 6;
            colBank_Name.Name = "colBank_Name";
            colBank_Name.ReadOnly = true;
            colBank_Name.Width = 125;
            // 
            // colCheque_No
            // 
            colCheque_No.DataPropertyName = "Cheque_No";
            colCheque_No.HeaderText = "رقم الشيك";
            colCheque_No.MinimumWidth = 6;
            colCheque_No.Name = "colCheque_No";
            colCheque_No.ReadOnly = true;
            colCheque_No.Width = 125;
            // 
            // colCheque_Due_Date
            // 
            colCheque_Due_Date.DataPropertyName = "Cheque_Due_Date";
            colCheque_Due_Date.HeaderText = "ت الاستحقاق";
            colCheque_Due_Date.MinimumWidth = 6;
            colCheque_Due_Date.Name = "colCheque_Due_Date";
            colCheque_Due_Date.ReadOnly = true;
            colCheque_Due_Date.Width = 125;
            // 
            // colVoucher_Currency_Rate
            // 
            colVoucher_Currency_Rate.DataPropertyName = "Voucher_Currency_Rate";
            colVoucher_Currency_Rate.HeaderText = "Voucher_Currency_Rate";
            colVoucher_Currency_Rate.MinimumWidth = 6;
            colVoucher_Currency_Rate.Name = "colVoucher_Currency_Rate";
            colVoucher_Currency_Rate.ReadOnly = true;
            colVoucher_Currency_Rate.Visible = false;
            colVoucher_Currency_Rate.Width = 125;
            // 
            // colPay_Way_Id
            // 
            colPay_Way_Id.DataPropertyName = "Pay_Way_Id";
            colPay_Way_Id.HeaderText = "Pay_Way_Id";
            colPay_Way_Id.MinimumWidth = 6;
            colPay_Way_Id.Name = "colPay_Way_Id";
            colPay_Way_Id.ReadOnly = true;
            colPay_Way_Id.Visible = false;
            colPay_Way_Id.Width = 125;
            // 
            // colPay_Way_Desc
            // 
            colPay_Way_Desc.DataPropertyName = "Pay_Way_Desc";
            colPay_Way_Desc.HeaderText = "طريقة الدفع";
            colPay_Way_Desc.MinimumWidth = 6;
            colPay_Way_Desc.Name = "colPay_Way_Desc";
            colPay_Way_Desc.ReadOnly = true;
            colPay_Way_Desc.Width = 125;
            // 
            // colManual_Voucher_No
            // 
            colManual_Voucher_No.DataPropertyName = "Manual_Voucher_No";
            colManual_Voucher_No.HeaderText = "Manual_Voucher_No";
            colManual_Voucher_No.MinimumWidth = 6;
            colManual_Voucher_No.Name = "colManual_Voucher_No";
            colManual_Voucher_No.ReadOnly = true;
            colManual_Voucher_No.Visible = false;
            colManual_Voucher_No.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnuChangeVoucherType });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(174, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // mnuChangeVoucherType
            // 
            mnuChangeVoucherType.Name = "mnuChangeVoucherType";
            mnuChangeVoucherType.Size = new Size(173, 24);
            mnuChangeVoucherType.Text = "تغيير نوع السند";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnDetails, tsbtnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1202, 39);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            tsbtnAdd.Image = Properties.Resources.Add_Order;
            tsbtnAdd.ImageTransparentColor = Color.Magenta;
            tsbtnAdd.Name = "tsbtnAdd";
            tsbtnAdd.Size = new Size(75, 36);
            tsbtnAdd.Text = "جديد";
            tsbtnAdd.Click += tsbtnAdd_Click;
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
            tsbtnPrint.Click += tsbtnPrint_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(696, 52);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(563, 52);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(125, 27);
            txtFrom_Trans_Date.TabIndex = 5;
            txtFrom_Trans_Date.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(478, 52);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 6;
            label1.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(351, 52);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(119, 27);
            txtTo_Trans_Date.TabIndex = 7;
            txtTo_Trans_Date.TabStop = false;
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(387, 16);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 10;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Person_ID_LOV.Click += btnShow_Person_ID_LOV_Click;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(425, 16);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 9;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(146, 16);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(236, 27);
            lblPerson_Name.TabIndex = 11;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(485, 16);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(47, 20);
            lblPerson.TabIndex = 8;
            lblPerson.Text = "الزبون";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(696, 16);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 12;
            label3.Text = "طريقة الدفع";
            // 
            // cmbPay_Way_Id
            // 
            cmbPay_Way_Id.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPay_Way_Id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPay_Way_Id.FormattingEnabled = true;
            cmbPay_Way_Id.Items.AddRange(new object[] { "الجميع", "ذمم", "نقدي", "شيكات", "حوالة مالية", "فيزا" });
            cmbPay_Way_Id.Location = new Point(551, 14);
            cmbPay_Way_Id.Margin = new Padding(3, 4, 3, 4);
            cmbPay_Way_Id.Name = "cmbPay_Way_Id";
            cmbPay_Way_Id.Size = new Size(138, 28);
            cmbPay_Way_Id.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbPay_Way_Id);
            panel1.Controls.Add(btnShow_Person_ID_LOV);
            panel1.Controls.Add(txtPerson_No);
            panel1.Controls.Add(lblPerson_Name);
            panel1.Controls.Add(lblPerson);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTo_Trans_Date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFrom_Trans_Date);
            panel1.Controls.Add(btnGetData);
            panel1.Location = new Point(396, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 103);
            panel1.TabIndex = 14;
            // 
            // VoucherListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 623);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(grdVoucherList);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VoucherListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الحركات المالية";
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetData;
        private DataGridView grdVoucherList;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnDetails;
        private Label label2;
        private DateTimePicker txtFrom_Trans_Date;
        private Label label1;
        private DateTimePicker txtTo_Trans_Date;
        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private ToolStripButton tsbtnPrint;
        private DataGridViewTextBoxColumn colDaily_Trans_ID;
        private DataGridViewTextBoxColumn colDaily_Trans_Type_ID;
        private DataGridViewTextBoxColumn colDaily_Trans_Type_Desc;
        private DataGridViewTextBoxColumn colTrans_Date;
        private DataGridViewTextBoxColumn colTrans_Amount;
        private DataGridViewTextBoxColumn colTrans_Currency_ID;
        private DataGridViewTextBoxColumn colTrans_Details;
        private DataGridViewTextBoxColumn colTrans_Currency_Rate;
        private Label label3;
        private ComboBox cmbPay_Way_Id;
        private ToolStripButton tsbtnAdd;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuChangeVoucherType;
        private DataGridViewTextBoxColumn colVoucher_ID;
        private DataGridViewTextBoxColumn colvoucher_Type_ID;
        private DataGridViewTextBoxColumn colVoucher_Type_Desc;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colVoucher_Date;
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
        private DataGridViewTextBoxColumn colManual_Voucher_No;
        private Panel panel1;
    }
}