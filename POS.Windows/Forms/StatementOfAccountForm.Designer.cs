namespace POS.Windows.Forms
{
    partial class StatementOfAccountForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            label4 = new Label();
            btnGetData = new Button();
            label1 = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            label2 = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            grdVoucherList = new DataGridView();
            colVoucher_Date = new DataGridViewTextBoxColumn();
            colvoucher_Type_ID = new DataGridViewTextBoxColumn();
            colVoucher_Type_Desc = new DataGridViewTextBoxColumn();
            colPerson_ID = new DataGridViewTextBoxColumn();
            colPerson_Name = new DataGridViewTextBoxColumn();
            colDebit_Amount = new DataGridViewTextBoxColumn();
            colCredit_Amount = new DataGridViewTextBoxColumn();
            colVoucher_Currency_ID = new DataGridViewTextBoxColumn();
            colCurrency_Name = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            colVoucher_Details = new DataGridViewTextBoxColumn();
            colVoucher_ID = new DataGridViewTextBoxColumn();
            colBank_Name = new DataGridViewTextBoxColumn();
            colCheque_No = new DataGridViewTextBoxColumn();
            colCheque_Due_Date = new DataGridViewTextBoxColumn();
            colVoucher_Currency_Rate = new DataGridViewTextBoxColumn();
            colPay_Way_Id = new DataGridViewTextBoxColumn();
            colPay_Way_Desc = new DataGridViewTextBoxColumn();
            toolstrip1 = new ToolStrip();
            tsbtnShow_TransactionDetails = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).BeginInit();
            toolstrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(900, 109);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 15;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Person_ID_LOV.Click += btnShow_Person_ID_LOV_Click;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(938, 109);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 14;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(664, 109);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(231, 27);
            lblPerson_Name.TabIndex = 16;
            lblPerson_Name.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(991, 108);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 13;
            label4.Text = "الزبون";
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(572, 108);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 12;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(807, 74);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 19;
            label1.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(662, 74);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(139, 27);
            txtTo_Trans_Date.TabIndex = 20;
            txtTo_Trans_Date.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(991, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 17;
            label2.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(844, 74);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(139, 27);
            txtFrom_Trans_Date.TabIndex = 18;
            txtFrom_Trans_Date.TabStop = false;
            // 
            // grdVoucherList
            // 
            grdVoucherList.AllowUserToAddRows = false;
            grdVoucherList.AllowUserToDeleteRows = false;
            grdVoucherList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdVoucherList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdVoucherList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVoucherList.Columns.AddRange(new DataGridViewColumn[] { colVoucher_Date, colvoucher_Type_ID, colVoucher_Type_Desc, colPerson_ID, colPerson_Name, colDebit_Amount, colCredit_Amount, colVoucher_Currency_ID, colCurrency_Name, colBalance, colVoucher_Details, colVoucher_ID, colBank_Name, colCheque_No, colCheque_Due_Date, colVoucher_Currency_Rate, colPay_Way_Id, colPay_Way_Desc });
            grdVoucherList.Location = new Point(12, 157);
            grdVoucherList.Margin = new Padding(3, 4, 3, 4);
            grdVoucherList.Name = "grdVoucherList";
            grdVoucherList.ReadOnly = true;
            grdVoucherList.RowHeadersWidth = 51;
            grdVoucherList.RowTemplate.Height = 25;
            grdVoucherList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVoucherList.Size = new Size(1062, 434);
            grdVoucherList.TabIndex = 21;
            // 
            // colVoucher_Date
            // 
            colVoucher_Date.DataPropertyName = "Voucher_Date";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            dataGridViewCellStyle7.NullValue = null;
            colVoucher_Date.DefaultCellStyle = dataGridViewCellStyle7;
            colVoucher_Date.HeaderText = "التاريخ";
            colVoucher_Date.MinimumWidth = 6;
            colVoucher_Date.Name = "colVoucher_Date";
            colVoucher_Date.ReadOnly = true;
            colVoucher_Date.Width = 125;
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
            colVoucher_Type_Desc.HeaderText = "نوع الحركة";
            colVoucher_Type_Desc.MinimumWidth = 6;
            colVoucher_Type_Desc.Name = "colVoucher_Type_Desc";
            colVoucher_Type_Desc.ReadOnly = true;
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
            // colPerson_Name
            // 
            colPerson_Name.DataPropertyName = "Person_Name";
            colPerson_Name.HeaderText = "الزبون";
            colPerson_Name.MinimumWidth = 6;
            colPerson_Name.Name = "colPerson_Name";
            colPerson_Name.ReadOnly = true;
            colPerson_Name.Visible = false;
            colPerson_Name.Width = 200;
            // 
            // colDebit_Amount
            // 
            colDebit_Amount.DataPropertyName = "Debit_Amount";
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = null;
            colDebit_Amount.DefaultCellStyle = dataGridViewCellStyle8;
            colDebit_Amount.HeaderText = "مبلغ مدين";
            colDebit_Amount.MinimumWidth = 6;
            colDebit_Amount.Name = "colDebit_Amount";
            colDebit_Amount.ReadOnly = true;
            colDebit_Amount.Width = 125;
            // 
            // colCredit_Amount
            // 
            colCredit_Amount.DataPropertyName = "Credit_Amount";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            colCredit_Amount.DefaultCellStyle = dataGridViewCellStyle9;
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
            // colBalance
            // 
            colBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            colBalance.DefaultCellStyle = dataGridViewCellStyle10;
            colBalance.HeaderText = "الرصيد";
            colBalance.MinimumWidth = 6;
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            colBalance.Width = 125;
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
            // colVoucher_ID
            // 
            colVoucher_ID.DataPropertyName = "Voucher_ID";
            colVoucher_ID.HeaderText = "رقم الحركة";
            colVoucher_ID.MinimumWidth = 6;
            colVoucher_ID.Name = "colVoucher_ID";
            colVoucher_ID.ReadOnly = true;
            colVoucher_ID.Width = 125;
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
            // toolstrip1
            // 
            toolstrip1.ImageScalingSize = new Size(48, 48);
            toolstrip1.Items.AddRange(new ToolStripItem[] { tsbtnShow_TransactionDetails });
            toolstrip1.Location = new Point(0, 0);
            toolstrip1.Name = "toolstrip1";
            toolstrip1.Size = new Size(1089, 55);
            toolstrip1.TabIndex = 22;
            toolstrip1.Text = "toolStrip1";
            // 
            // tsbtnShow_TransactionDetails
            // 
            tsbtnShow_TransactionDetails.Image = Properties.Resources.view_details;
            tsbtnShow_TransactionDetails.ImageTransparentColor = Color.Magenta;
            tsbtnShow_TransactionDetails.Name = "tsbtnShow_TransactionDetails";
            tsbtnShow_TransactionDetails.Size = new Size(108, 52);
            tsbtnShow_TransactionDetails.Text = "تفاصيل";
            tsbtnShow_TransactionDetails.Click += tsbtnShow_TransactionDetails_Click;
            // 
            // StatementOfAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 623);
            Controls.Add(toolstrip1);
            Controls.Add(grdVoucherList);
            Controls.Add(label1);
            Controls.Add(txtTo_Trans_Date);
            Controls.Add(label2);
            Controls.Add(txtFrom_Trans_Date);
            Controls.Add(btnShow_Person_ID_LOV);
            Controls.Add(txtPerson_No);
            Controls.Add(lblPerson_Name);
            Controls.Add(label4);
            Controls.Add(btnGetData);
            KeyPreview = true;
            Name = "StatementOfAccountForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "كشف حساب";
            ((System.ComponentModel.ISupportInitialize)grdVoucherList).EndInit();
            toolstrip1.ResumeLayout(false);
            toolstrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label label4;
        private Button btnGetData;
        private Label label1;
        private DateTimePicker txtTo_Trans_Date;
        private Label label2;
        private DateTimePicker txtFrom_Trans_Date;
        private DataGridView grdVoucherList;
        private DataGridViewTextBoxColumn colVoucher_Date;
        private DataGridViewTextBoxColumn colvoucher_Type_ID;
        private DataGridViewTextBoxColumn colVoucher_Type_Desc;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colPerson_Name;
        private DataGridViewTextBoxColumn colDebit_Amount;
        private DataGridViewTextBoxColumn colCredit_Amount;
        private DataGridViewTextBoxColumn colVoucher_Currency_ID;
        private DataGridViewTextBoxColumn colCurrency_Name;
        private DataGridViewTextBoxColumn colBalance;
        private DataGridViewTextBoxColumn colVoucher_Details;
        private DataGridViewTextBoxColumn colVoucher_ID;
        private DataGridViewTextBoxColumn colBank_Name;
        private DataGridViewTextBoxColumn colCheque_No;
        private DataGridViewTextBoxColumn colCheque_Due_Date;
        private DataGridViewTextBoxColumn colVoucher_Currency_Rate;
        private DataGridViewTextBoxColumn colPay_Way_Id;
        private DataGridViewTextBoxColumn colPay_Way_Desc;
        private ToolStrip toolstrip1;
        private ToolStripButton tsbtnShow_TransactionDetails;
    }
}