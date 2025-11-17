namespace POS.Windows.Forms
{
    partial class PersonListForm
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
            grdList = new DataGridView();
            colPerson_ID = new DataGridViewTextBoxColumn();
            colPerson_No = new DataGridViewTextBoxColumn();
            colPerson_Name = new DataGridViewTextBoxColumn();
            colCity_Name = new DataGridViewTextBoxColumn();
            colMobile = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colPerson_Balance = new DataGridViewTextBoxColumn();
            colPerson_Account_ID = new DataGridViewTextBoxColumn();
            btnGetData = new Button();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            tsbtnStatement = new ToolStripButton();
            tsbtnPersonSales = new ToolStripButton();
            tsbtnNewInvoice = new ToolStripButton();
            tsbtnPersonPurcaheInvoices = new ToolStripButton();
            tsbtnAddSardVoucher = new ToolStripButton();
            txtCustomer_Name = new TextBox();
            label3 = new Label();
            txtCity_ID = new MaskedTextBox();
            btnShow_City_ID_LOV = new Button();
            txtCity_Name = new TextBox();
            label5 = new Label();
            txtPerson_No = new MaskedTextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grdList).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            grdList.Columns.AddRange(new DataGridViewColumn[] { colPerson_ID, colPerson_No, colPerson_Name, colCity_Name, colMobile, colAddress, colPerson_Balance, colPerson_Account_ID });
            grdList.Location = new Point(21, 175);
            grdList.Margin = new Padding(3, 4, 3, 4);
            grdList.Name = "grdList";
            grdList.ReadOnly = true;
            grdList.RowHeadersWidth = 51;
            grdList.RowTemplate.Height = 25;
            grdList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdList.Size = new Size(960, 395);
            grdList.TabIndex = 10;
            grdList.CellContentClick += grdList_CellContentClick;
            grdList.CellDoubleClick += grdList_CellDoubleClick;
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
            // colPerson_No
            // 
            colPerson_No.DataPropertyName = "Person_No";
            colPerson_No.HeaderText = "الرقم";
            colPerson_No.MinimumWidth = 6;
            colPerson_No.Name = "colPerson_No";
            colPerson_No.ReadOnly = true;
            colPerson_No.Width = 80;
            // 
            // colPerson_Name
            // 
            colPerson_Name.DataPropertyName = "Person_Name";
            colPerson_Name.HeaderText = "الاسم";
            colPerson_Name.MinimumWidth = 6;
            colPerson_Name.Name = "colPerson_Name";
            colPerson_Name.ReadOnly = true;
            colPerson_Name.Width = 150;
            // 
            // colCity_Name
            // 
            colCity_Name.DataPropertyName = "City_Name";
            colCity_Name.HeaderText = "المدينة";
            colCity_Name.MinimumWidth = 6;
            colCity_Name.Name = "colCity_Name";
            colCity_Name.ReadOnly = true;
            colCity_Name.Width = 125;
            // 
            // colMobile
            // 
            colMobile.DataPropertyName = "Mobile";
            colMobile.HeaderText = "موبايل";
            colMobile.MinimumWidth = 6;
            colMobile.Name = "colMobile";
            colMobile.ReadOnly = true;
            colMobile.Width = 80;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "العنوان";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.Width = 150;
            // 
            // colPerson_Balance
            // 
            colPerson_Balance.DataPropertyName = "Person_Balance";
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            colPerson_Balance.DefaultCellStyle = dataGridViewCellStyle2;
            colPerson_Balance.HeaderText = "الرصيد";
            colPerson_Balance.MinimumWidth = 6;
            colPerson_Balance.Name = "colPerson_Balance";
            colPerson_Balance.ReadOnly = true;
            colPerson_Balance.Width = 125;
            // 
            // colPerson_Account_ID
            // 
            colPerson_Account_ID.DataPropertyName = "Person_Account_ID";
            colPerson_Account_ID.HeaderText = "صفحة الحساب";
            colPerson_Account_ID.MinimumWidth = 6;
            colPerson_Account_ID.Name = "colPerson_Account_ID";
            colPerson_Account_ID.ReadOnly = true;
            colPerson_Account_ID.Width = 140;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(101, 76);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 9;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnDetails, tsbtnStatement, tsbtnPersonSales, tsbtnNewInvoice, tsbtnPersonPurcaheInvoices, tsbtnAddSardVoucher });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(994, 39);
            toolStrip1.TabIndex = 0;
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
            tsbtnDetails.Image = Properties.Resources.EditRecord;
            tsbtnDetails.ImageTransparentColor = Color.Magenta;
            tsbtnDetails.Name = "tsbtnDetails";
            tsbtnDetails.Size = new Size(92, 36);
            tsbtnDetails.Text = "تفاصيل";
            tsbtnDetails.Click += tsbtnDetails_Click;
            // 
            // tsbtnStatement
            // 
            tsbtnStatement.Image = Properties.Resources.statement_order1;
            tsbtnStatement.ImageTransparentColor = Color.Magenta;
            tsbtnStatement.Name = "tsbtnStatement";
            tsbtnStatement.Size = new Size(125, 36);
            tsbtnStatement.Text = "كشف حساب";
            tsbtnStatement.Click += tsbtnStatement_Click;
            // 
            // tsbtnPersonSales
            // 
            tsbtnPersonSales.Image = Properties.Resources.icons8_cash_receipt_50;
            tsbtnPersonSales.ImageTransparentColor = Color.Magenta;
            tsbtnPersonSales.Name = "tsbtnPersonSales";
            tsbtnPersonSales.Size = new Size(100, 36);
            tsbtnPersonSales.Text = "المبيعات";
            tsbtnPersonSales.Visible = false;
            tsbtnPersonSales.Click += tsbtnPersonSales_Click;
            // 
            // tsbtnNewInvoice
            // 
            tsbtnNewInvoice.Image = Properties.Resources.icons8_invoice_50;
            tsbtnNewInvoice.ImageTransparentColor = Color.Magenta;
            tsbtnNewInvoice.Name = "tsbtnNewInvoice";
            tsbtnNewInvoice.Size = new Size(125, 36);
            tsbtnNewInvoice.Text = "فاتورة جديدة";
            tsbtnNewInvoice.Visible = false;
            tsbtnNewInvoice.Click += tsbtnNewInvoice_Click;
            // 
            // tsbtnPersonPurcaheInvoices
            // 
            tsbtnPersonPurcaheInvoices.Image = Properties.Resources.icons8_invoice_50;
            tsbtnPersonPurcaheInvoices.ImageTransparentColor = Color.Magenta;
            tsbtnPersonPurcaheInvoices.Name = "tsbtnPersonPurcaheInvoices";
            tsbtnPersonPurcaheInvoices.Size = new Size(111, 36);
            tsbtnPersonPurcaheInvoices.Text = "المشتريات";
            tsbtnPersonPurcaheInvoices.Visible = false;
            tsbtnPersonPurcaheInvoices.Click += tsbtnPersonPurcaheInvoices_Click;
            // 
            // tsbtnAddSardVoucher
            // 
            tsbtnAddSardVoucher.Image = Properties.Resources.Add_Order;
            tsbtnAddSardVoucher.ImageTransparentColor = Color.Magenta;
            tsbtnAddSardVoucher.Name = "tsbtnAddSardVoucher";
            tsbtnAddSardVoucher.Size = new Size(78, 36);
            tsbtnAddSardVoucher.Text = "دفعة";
            tsbtnAddSardVoucher.Visible = false;
            tsbtnAddSardVoucher.Click += tsbtnAddSardVoucher_Click;
            // 
            // txtCustomer_Name
            // 
            txtCustomer_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomer_Name.Location = new Point(214, 40);
            txtCustomer_Name.Margin = new Padding(3, 4, 3, 4);
            txtCustomer_Name.Name = "txtCustomer_Name";
            txtCustomer_Name.Size = new Size(286, 27);
            txtCustomer_Name.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(508, 40);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "الاسم";
            // 
            // txtCity_ID
            // 
            txtCity_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCity_ID.Location = new Point(456, 76);
            txtCity_ID.Margin = new Padding(3, 4, 3, 4);
            txtCity_ID.Mask = "00000";
            txtCity_ID.Name = "txtCity_ID";
            txtCity_ID.Size = new Size(44, 27);
            txtCity_ID.TabIndex = 6;
            txtCity_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCity_ID.ValidatingType = typeof(int);
            txtCity_ID.MaskInputRejected += txtCity_ID_MaskInputRejected;
            txtCity_ID.Validating += txtCity_ID_Validating;
            // 
            // btnShow_City_ID_LOV
            // 
            btnShow_City_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_City_ID_LOV.Image = Properties.Resources.List;
            btnShow_City_ID_LOV.Location = new Point(421, 76);
            btnShow_City_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_City_ID_LOV.Name = "btnShow_City_ID_LOV";
            btnShow_City_ID_LOV.Size = new Size(31, 31);
            btnShow_City_ID_LOV.TabIndex = 7;
            btnShow_City_ID_LOV.TabStop = false;
            btnShow_City_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_City_ID_LOV.Click += btnShow_City_ID_LOV_Click;
            // 
            // txtCity_Name
            // 
            txtCity_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCity_Name.BackColor = Color.White;
            txtCity_Name.Location = new Point(214, 76);
            txtCity_Name.Margin = new Padding(3, 4, 3, 4);
            txtCity_Name.Name = "txtCity_Name";
            txtCity_Name.ReadOnly = true;
            txtCity_Name.Size = new Size(199, 27);
            txtCity_Name.TabIndex = 8;
            txtCity_Name.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(508, 76);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 5;
            label5.Text = "المدينة";
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(456, 4);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(44, 27);
            txtPerson_No.TabIndex = 2;
            txtPerson_No.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPerson_No.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(508, 4);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "الرقم";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPerson_No);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCity_ID);
            panel1.Controls.Add(btnShow_City_ID_LOV);
            panel1.Controls.Add(txtCity_Name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCustomer_Name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnGetData);
            panel1.Location = new Point(401, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 113);
            panel1.TabIndex = 11;
            // 
            // PersonListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 600);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(grdList);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "قائمة الزبائن";
            KeyDown += PersonListForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grdList).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdList;
        private Button btnGetData;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnDetails;
        private TextBox txtCustomer_Name;
        private Label label3;
        private MaskedTextBox txtCity_ID;
        private Button btnShow_City_ID_LOV;
        private TextBox txtCity_Name;
        private Label label5;
        private ToolStripButton tsbtnStatement;
        private DataGridViewTextBoxColumn colmobile_01;
        private MaskedTextBox txtPerson_No;
        private Label label1;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colPerson_No;
        private DataGridViewTextBoxColumn colPerson_Name;
        private DataGridViewTextBoxColumn colCity_Name;
        private DataGridViewTextBoxColumn colMobile;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colCustomerBalance;
        private DataGridViewTextBoxColumn colPerson_Account_ID;
        private Panel panel1;
        private DataGridViewTextBoxColumn colPerson_Balance;
        private ToolStripButton tsbtnAddSardVoucher;
        private ToolStripButton tsbtnPersonSales;
        private ToolStripButton tsbtnPersonPurcaheInvoices;
        private ToolStripButton tsbtnNewInvoice;
    }
}