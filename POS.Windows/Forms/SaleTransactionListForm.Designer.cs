namespace POS.Windows.Forms
{
    partial class SaleTransactionListForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnSearch = new Button();
            panel1 = new Panel();
            label5 = new Label();
            txtTo_Voucher_Amount = new NumericUpDown();
            label4 = new Label();
            txtFrom_Voucher_Amount = new NumericUpDown();
            label3 = new Label();
            txtTo_Date = new DateTimePicker();
            label2 = new Label();
            txtFrom_Date = new DateTimePicker();
            grdSalesList = new DataGridView();
            colSale_Transaction_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_No = new DataGridViewTextBoxColumn();
            colTeller_ID = new DataGridViewTextBoxColumn();
            colTransaction_Date = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colTeller_Name = new DataGridViewTextBoxColumn();
            colTransaction_Notes = new DataGridViewTextBoxColumn();
            txtItemCount = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTo_Voucher_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFrom_Voucher_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdSalesList).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(15, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTo_Voucher_Amount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFrom_Voucher_Amount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTo_Date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFrom_Date);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(346, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 125);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(288, 63);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "المبلغ   من";
            // 
            // txtTo_Voucher_Amount
            // 
            txtTo_Voucher_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Voucher_Amount.Location = new Point(132, 61);
            txtTo_Voucher_Amount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtTo_Voucher_Amount.Name = "txtTo_Voucher_Amount";
            txtTo_Voucher_Amount.Size = new Size(150, 27);
            txtTo_Voucher_Amount.TabIndex = 7;
            txtTo_Voucher_Amount.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(538, 68);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "المبلغ   من";
            // 
            // txtFrom_Voucher_Amount
            // 
            txtFrom_Voucher_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Voucher_Amount.Location = new Point(382, 66);
            txtFrom_Voucher_Amount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtFrom_Voucher_Amount.Name = "txtFrom_Voucher_Amount";
            txtFrom_Voucher_Amount.Size = new Size(150, 27);
            txtFrom_Voucher_Amount.TabIndex = 5;
            txtFrom_Voucher_Amount.ThousandsSeparator = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(288, 25);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 4;
            label3.Text = "الى";
            // 
            // txtTo_Date
            // 
            txtTo_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Date.Checked = false;
            txtTo_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Date.Location = new Point(132, 25);
            txtTo_Date.Name = "txtTo_Date";
            txtTo_Date.ShowCheckBox = true;
            txtTo_Date.Size = new Size(147, 27);
            txtTo_Date.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(538, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "التاريخ   من";
            // 
            // txtFrom_Date
            // 
            txtFrom_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Date.Checked = false;
            txtFrom_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Date.Location = new Point(385, 23);
            txtFrom_Date.Name = "txtFrom_Date";
            txtFrom_Date.ShowCheckBox = true;
            txtFrom_Date.Size = new Size(147, 27);
            txtFrom_Date.TabIndex = 1;
            // 
            // grdSalesList
            // 
            grdSalesList.AllowUserToAddRows = false;
            grdSalesList.AllowUserToDeleteRows = false;
            grdSalesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdSalesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdSalesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSalesList.Columns.AddRange(new DataGridViewColumn[] { colSale_Transaction_ID, colSale_Transaction_No, colTeller_ID, colTransaction_Date, colAmount, colTeller_Name, colTransaction_Notes });
            grdSalesList.Location = new Point(12, 186);
            grdSalesList.Name = "grdSalesList";
            grdSalesList.ReadOnly = true;
            grdSalesList.RowHeadersWidth = 51;
            grdSalesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSalesList.Size = new Size(985, 346);
            grdSalesList.TabIndex = 2;
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
            colSale_Transaction_No.HeaderText = "رقم الحركة";
            colSale_Transaction_No.MinimumWidth = 6;
            colSale_Transaction_No.Name = "colSale_Transaction_No";
            colSale_Transaction_No.ReadOnly = true;
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
            // colTransaction_Date
            // 
            colTransaction_Date.DataPropertyName = "Transaction_Date";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            colTransaction_Date.DefaultCellStyle = dataGridViewCellStyle5;
            colTransaction_Date.HeaderText = "التاريخ";
            colTransaction_Date.MinimumWidth = 6;
            colTransaction_Date.Name = "colTransaction_Date";
            colTransaction_Date.ReadOnly = true;
            colTransaction_Date.Width = 125;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            colAmount.HeaderText = "المبلغ";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 125;
            // 
            // colTeller_Name
            // 
            colTeller_Name.DataPropertyName = "Teller_Name";
            colTeller_Name.HeaderText = "الصندوق";
            colTeller_Name.MinimumWidth = 6;
            colTeller_Name.Name = "colTeller_Name";
            colTeller_Name.ReadOnly = true;
            colTeller_Name.Width = 150;
            // 
            // colTransaction_Notes
            // 
            colTransaction_Notes.DataPropertyName = "Transaction_Notes";
            colTransaction_Notes.HeaderText = "ملاحظات";
            colTransaction_Notes.MinimumWidth = 6;
            colTransaction_Notes.Name = "colTransaction_Notes";
            colTransaction_Notes.ReadOnly = true;
            colTransaction_Notes.Width = 200;
            // 
            // txtItemCount
            // 
            txtItemCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtItemCount.Location = new Point(771, 554);
            txtItemCount.Name = "txtItemCount";
            txtItemCount.ReadOnly = true;
            txtItemCount.Size = new Size(125, 27);
            txtItemCount.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(902, 554);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "عدد الحركات";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(45, 45);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1009, 52);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.view_details;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(105, 49);
            toolStripButton1.Text = "تفاصيل";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // SaleTransactionListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 595);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(txtItemCount);
            Controls.Add(grdSalesList);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "SaleTransactionListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة المبيعات";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTo_Voucher_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFrom_Voucher_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdSalesList).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Panel panel1;
        private DataGridView grdSalesList;
        private TextBox txtItemCount;
        private Label label1;
        private DataGridViewTextBoxColumn colSale_Transaction_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_No;
        private DataGridViewTextBoxColumn colTeller_ID;
        private DataGridViewTextBoxColumn colTransaction_Date;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colTeller_Name;
        private DataGridViewTextBoxColumn colTransaction_Notes;
        private Label label2;
        private DateTimePicker txtFrom_Date;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Label label3;
        private DateTimePicker txtTo_Date;
        private Label label5;
        private NumericUpDown txtTo_Voucher_Amount;
        private Label label4;
        private NumericUpDown txtFrom_Voucher_Amount;
    }
}