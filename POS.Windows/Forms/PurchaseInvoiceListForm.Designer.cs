namespace POS.Windows.Forms
{
    partial class PurchaseInvoiceListForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            grdList = new DataGridView();
            colVoucher_ID = new DataGridViewTextBoxColumn();
            colvoucher_Type_ID = new DataGridViewTextBoxColumn();
            colVoucher_Type_Desc = new DataGridViewTextBoxColumn();
            colPerson_ID = new DataGridViewTextBoxColumn();
            colVoucher_Date = new DataGridViewTextBoxColumn();
            colPerson_Name = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colVoucher_Currency_ID = new DataGridViewTextBoxColumn();
            colCurrency_Name = new DataGridViewTextBoxColumn();
            colVoucher_Currency_Rate = new DataGridViewTextBoxColumn();
            colVoucher_Details = new DataGridViewTextBoxColumn();
            colUser_Name = new DataGridViewTextBoxColumn();
            colPaid_Amount = new DataGridViewTextBoxColumn();
            colRemain_Amount = new DataGridViewTextBoxColumn();
            btnGetData = new Button();
            label3 = new Label();
            cmbPay_Way_Id = new ComboBox();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            lblPerson = new Label();
            label1 = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            label2 = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            tsbtnSarfVoucherList = new ToolStripButton();
            tsbtnPrint = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdList).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdList
            // 
            grdList.AllowUserToAddRows = false;
            grdList.AllowUserToDeleteRows = false;
            grdList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdList.Columns.AddRange(new DataGridViewColumn[] { colVoucher_ID, colvoucher_Type_ID, colVoucher_Type_Desc, colPerson_ID, colVoucher_Date, colPerson_Name, colAmount, colVoucher_Currency_ID, colCurrency_Name, colVoucher_Currency_Rate, colVoucher_Details, colUser_Name, colPaid_Amount, colRemain_Amount });
            grdList.Location = new Point(25, 170);
            grdList.Name = "grdList";
            grdList.ReadOnly = true;
            grdList.RowHeadersWidth = 51;
            grdList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdList.Size = new Size(1084, 469);
            grdList.TabIndex = 0;
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
            colVoucher_Date.Width = 150;
            // 
            // colPerson_Name
            // 
            colPerson_Name.DataPropertyName = "Person_Name";
            colPerson_Name.HeaderText = "المورد";
            colPerson_Name.MinimumWidth = 6;
            colPerson_Name.Name = "colPerson_Name";
            colPerson_Name.ReadOnly = true;
            colPerson_Name.Width = 200;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colAmount.DefaultCellStyle = dataGridViewCellStyle3;
            colAmount.HeaderText = "المبلغ";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 125;
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
            // colVoucher_Details
            // 
            colVoucher_Details.DataPropertyName = "Voucher_Details";
            colVoucher_Details.HeaderText = "البيان";
            colVoucher_Details.MinimumWidth = 6;
            colVoucher_Details.Name = "colVoucher_Details";
            colVoucher_Details.ReadOnly = true;
            colVoucher_Details.Width = 125;
            // 
            // colUser_Name
            // 
            colUser_Name.DataPropertyName = "User_Name";
            colUser_Name.HeaderText = "User_Name";
            colUser_Name.MinimumWidth = 6;
            colUser_Name.Name = "colUser_Name";
            colUser_Name.ReadOnly = true;
            colUser_Name.Visible = false;
            colUser_Name.Width = 125;
            // 
            // colPaid_Amount
            // 
            colPaid_Amount.DataPropertyName = "Paid_Amount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            colPaid_Amount.DefaultCellStyle = dataGridViewCellStyle4;
            colPaid_Amount.HeaderText = "المصروف";
            colPaid_Amount.MinimumWidth = 6;
            colPaid_Amount.Name = "colPaid_Amount";
            colPaid_Amount.ReadOnly = true;
            colPaid_Amount.Width = 125;
            // 
            // colRemain_Amount
            // 
            colRemain_Amount.DataPropertyName = "Remain_Amount";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            colRemain_Amount.DefaultCellStyle = dataGridViewCellStyle5;
            colRemain_Amount.HeaderText = "المتبقي";
            colRemain_Amount.MinimumWidth = 6;
            colRemain_Amount.Name = "colRemain_Amount";
            colRemain_Amount.ReadOnly = true;
            colRemain_Amount.Width = 125;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(490, 134);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(136, 29);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(996, 57);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 22;
            label3.Text = "طريقة الدفع";
            // 
            // cmbPay_Way_Id
            // 
            cmbPay_Way_Id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPay_Way_Id.FormattingEnabled = true;
            cmbPay_Way_Id.Items.AddRange(new object[] { "الجميع", "ذمم", "نقدي", "شيكات", "حوالة مالية", "فيزا" });
            cmbPay_Way_Id.Location = new Point(851, 55);
            cmbPay_Way_Id.Margin = new Padding(3, 4, 3, 4);
            cmbPay_Way_Id.Name = "cmbPay_Way_Id";
            cmbPay_Way_Id.Size = new Size(138, 28);
            cmbPay_Way_Id.TabIndex = 23;
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(905, 132);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 20;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(943, 132);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 19;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(664, 132);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(236, 27);
            lblPerson_Name.TabIndex = 21;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(1003, 132);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(47, 20);
            lblPerson.TabIndex = 18;
            lblPerson.Text = "الزبون";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(812, 93);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 16;
            label1.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(685, 93);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(119, 27);
            txtTo_Trans_Date.TabIndex = 17;
            txtTo_Trans_Date.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(996, 93);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 14;
            label2.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(863, 93);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(125, 27);
            txtFrom_Trans_Date.TabIndex = 15;
            txtFrom_Trans_Date.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnDetails, tsbtnSarfVoucherList, tsbtnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1121, 39);
            toolStrip1.TabIndex = 24;
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
            tsbtnDetails.Click += tsbtnDetails_Click_1;
            // 
            // tsbtnSarfVoucherList
            // 
            tsbtnSarfVoucherList.Image = Properties.Resources.icons8_expenses_50;
            tsbtnSarfVoucherList.ImageTransparentColor = Color.Magenta;
            tsbtnSarfVoucherList.Name = "tsbtnSarfVoucherList";
            tsbtnSarfVoucherList.Size = new Size(100, 36);
            tsbtnSarfVoucherList.Text = "مصاريف";
            tsbtnSarfVoucherList.Click += tsbtnSarfVoucherList_Click;
            // 
            // tsbtnPrint
            // 
            tsbtnPrint.Image = Properties.Resources.print;
            tsbtnPrint.ImageTransparentColor = Color.Magenta;
            tsbtnPrint.Name = "tsbtnPrint";
            tsbtnPrint.Size = new Size(84, 36);
            tsbtnPrint.Text = "طباعة";
            // 
            // PurchaseInvoiceListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 671);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(cmbPay_Way_Id);
            Controls.Add(btnShow_Person_ID_LOV);
            Controls.Add(txtPerson_No);
            Controls.Add(lblPerson_Name);
            Controls.Add(lblPerson);
            Controls.Add(label1);
            Controls.Add(txtTo_Trans_Date);
            Controls.Add(label2);
            Controls.Add(txtFrom_Trans_Date);
            Controls.Add(btnGetData);
            Controls.Add(grdList);
            KeyPreview = true;
            Name = "PurchaseInvoiceListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فواتير المشتريات";
            ((System.ComponentModel.ISupportInitialize)grdList).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdList;
        private DataGridViewTextBoxColumn colVoucher_ID;
        private DataGridViewTextBoxColumn colvoucher_Type_ID;
        private DataGridViewTextBoxColumn colVoucher_Type_Desc;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colVoucher_Date;
        private DataGridViewTextBoxColumn colPerson_Name;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colVoucher_Currency_ID;
        private DataGridViewTextBoxColumn colCurrency_Name;
        private DataGridViewTextBoxColumn colVoucher_Currency_Rate;
        private DataGridViewTextBoxColumn colVoucher_Details;
        private DataGridViewTextBoxColumn colUser_Name;
        private DataGridViewTextBoxColumn colPaid_Amount;
        private DataGridViewTextBoxColumn colRemain_Amount;
        private Button btnGetData;
        private Label label3;
        private ComboBox cmbPay_Way_Id;
        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private Label label1;
        private DateTimePicker txtTo_Trans_Date;
        private Label label2;
        private DateTimePicker txtFrom_Trans_Date;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnDetails;
        private ToolStripButton tsbtnPrint;
        private ToolStripButton tsbtnSarfVoucherList;
    }
}