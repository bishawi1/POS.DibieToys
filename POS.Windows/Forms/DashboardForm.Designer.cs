namespace POS.Windows.Forms
{
    partial class DashboardForm
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
            txtSalesInvoiceAmount = new NumericUpDown();
            txtCashQabdAmount = new NumericUpDown();
            label4 = new Label();
            txtChequeQabdAmount = new NumericUpDown();
            label5 = new Label();
            txtVisaQabdAmount = new NumericUpDown();
            label6 = new Label();
            txtTransfereQabdAmount = new NumericUpDown();
            label7 = new Label();
            txtTransfereSarfAmount = new NumericUpDown();
            txtVisaSarfAmount = new NumericUpDown();
            txtChequeSarfAmount = new NumericUpDown();
            txtCashSarfAmount = new NumericUpDown();
            txtCashAvailableAmount = new NumericUpDown();
            panel1 = new Panel();
            lblDebtitSalestText = new Label();
            txtDebitSalesInvoice = new NumericUpDown();
            label15 = new Label();
            txtQabTotalAmount = new NumericUpDown();
            lblAllSalesText = new Label();
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label17 = new Label();
            label16 = new Label();
            lblTo = new Label();
            txtTo_Trans_Date = new DateTimePicker();
            lblFrom = new Label();
            txtFrom_Trans_Date = new DateTimePicker();
            btnGetData = new Button();
            cmbPeriod = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtSalesInvoiceAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCashQabdAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChequeQabdAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVisaQabdAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTransfereQabdAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTransfereSarfAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVisaSarfAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChequeSarfAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCashSarfAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCashAvailableAmount).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDebitSalesInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQabTotalAmount).BeginInit();
            SuspendLayout();
            // 
            // txtSalesInvoiceAmount
            // 
            txtSalesInvoiceAmount.Location = new Point(592, 43);
            txtSalesInvoiceAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtSalesInvoiceAmount.Name = "txtSalesInvoiceAmount";
            txtSalesInvoiceAmount.Size = new Size(150, 27);
            txtSalesInvoiceAmount.TabIndex = 1;
            txtSalesInvoiceAmount.ThousandsSeparator = true;
            // 
            // txtCashQabdAmount
            // 
            txtCashQabdAmount.Location = new Point(573, 177);
            txtCashQabdAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtCashQabdAmount.Name = "txtCashQabdAmount";
            txtCashQabdAmount.Size = new Size(150, 27);
            txtCashQabdAmount.TabIndex = 7;
            txtCashQabdAmount.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(573, 143);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 6;
            label4.Text = "نقدا";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtChequeQabdAmount
            // 
            txtChequeQabdAmount.Location = new Point(399, 177);
            txtChequeQabdAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtChequeQabdAmount.Name = "txtChequeQabdAmount";
            txtChequeQabdAmount.Size = new Size(150, 27);
            txtChequeQabdAmount.TabIndex = 9;
            txtChequeQabdAmount.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(399, 143);
            label5.Name = "label5";
            label5.Size = new Size(150, 31);
            label5.TabIndex = 8;
            label5.Text = "شيكات";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVisaQabdAmount
            // 
            txtVisaQabdAmount.Location = new Point(225, 177);
            txtVisaQabdAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtVisaQabdAmount.Name = "txtVisaQabdAmount";
            txtVisaQabdAmount.Size = new Size(150, 27);
            txtVisaQabdAmount.TabIndex = 11;
            txtVisaQabdAmount.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(225, 143);
            label6.Name = "label6";
            label6.Size = new Size(150, 31);
            label6.TabIndex = 10;
            label6.Text = "فيزا";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTransfereQabdAmount
            // 
            txtTransfereQabdAmount.Location = new Point(51, 177);
            txtTransfereQabdAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtTransfereQabdAmount.Name = "txtTransfereQabdAmount";
            txtTransfereQabdAmount.Size = new Size(150, 27);
            txtTransfereQabdAmount.TabIndex = 13;
            txtTransfereQabdAmount.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(51, 143);
            label7.Name = "label7";
            label7.Size = new Size(150, 31);
            label7.TabIndex = 12;
            label7.Text = "حوالات";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTransfereSarfAmount
            // 
            txtTransfereSarfAmount.Location = new Point(51, 298);
            txtTransfereSarfAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtTransfereSarfAmount.Name = "txtTransfereSarfAmount";
            txtTransfereSarfAmount.Size = new Size(150, 27);
            txtTransfereSarfAmount.TabIndex = 21;
            txtTransfereSarfAmount.ThousandsSeparator = true;
            // 
            // txtVisaSarfAmount
            // 
            txtVisaSarfAmount.Location = new Point(225, 298);
            txtVisaSarfAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtVisaSarfAmount.Name = "txtVisaSarfAmount";
            txtVisaSarfAmount.Size = new Size(150, 27);
            txtVisaSarfAmount.TabIndex = 19;
            txtVisaSarfAmount.ThousandsSeparator = true;
            // 
            // txtChequeSarfAmount
            // 
            txtChequeSarfAmount.Location = new Point(399, 298);
            txtChequeSarfAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtChequeSarfAmount.Name = "txtChequeSarfAmount";
            txtChequeSarfAmount.Size = new Size(150, 27);
            txtChequeSarfAmount.TabIndex = 17;
            txtChequeSarfAmount.ThousandsSeparator = true;
            // 
            // txtCashSarfAmount
            // 
            txtCashSarfAmount.Location = new Point(573, 298);
            txtCashSarfAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtCashSarfAmount.Name = "txtCashSarfAmount";
            txtCashSarfAmount.Size = new Size(150, 27);
            txtCashSarfAmount.TabIndex = 15;
            txtCashSarfAmount.ThousandsSeparator = true;
            // 
            // txtCashAvailableAmount
            // 
            txtCashAvailableAmount.Location = new Point(575, 384);
            txtCashAvailableAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtCashAvailableAmount.Minimum = new decimal(new int[] { 1316134911, 2328, 0, int.MinValue });
            txtCashAvailableAmount.Name = "txtCashAvailableAmount";
            txtCashAvailableAmount.Size = new Size(150, 27);
            txtCashAvailableAmount.TabIndex = 23;
            txtCashAvailableAmount.ThousandsSeparator = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDebtitSalestText);
            panel1.Controls.Add(txtDebitSalesInvoice);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtQabTotalAmount);
            panel1.Controls.Add(lblAllSalesText);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(txtCashAvailableAmount);
            panel1.Controls.Add(txtTransfereSarfAmount);
            panel1.Controls.Add(txtVisaSarfAmount);
            panel1.Controls.Add(txtChequeSarfAmount);
            panel1.Controls.Add(txtCashSarfAmount);
            panel1.Controls.Add(txtTransfereQabdAmount);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtVisaQabdAmount);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtChequeQabdAmount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCashQabdAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSalesInvoiceAmount);
            panel1.Location = new Point(35, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 428);
            panel1.TabIndex = 24;
            // 
            // lblDebtitSalestText
            // 
            lblDebtitSalestText.BackColor = Color.FromArgb(255, 128, 0);
            lblDebtitSalestText.BorderStyle = BorderStyle.FixedSingle;
            lblDebtitSalestText.Location = new Point(271, 9);
            lblDebtitSalestText.Name = "lblDebtitSalestText";
            lblDebtitSalestText.Size = new Size(150, 31);
            lblDebtitSalestText.TabIndex = 36;
            lblDebtitSalestText.Text = "مبيعات ذمم";
            lblDebtitSalestText.Click += lblDebtitSalestText_Click;
            lblDebtitSalestText.DoubleClick += lblDebtitSalestText_DoubleClick;
            // 
            // txtDebitSalesInvoice
            // 
            txtDebitSalesInvoice.Location = new Point(271, 43);
            txtDebitSalesInvoice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtDebitSalesInvoice.Name = "txtDebitSalesInvoice";
            txtDebitSalesInvoice.Size = new Size(150, 27);
            txtDebitSalesInvoice.TabIndex = 35;
            txtDebitSalesInvoice.ThousandsSeparator = true;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(192, 255, 192);
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(427, 9);
            label15.Name = "label15";
            label15.Size = new Size(150, 31);
            label15.TabIndex = 34;
            label15.Text = "المقبوضات";
            // 
            // txtQabTotalAmount
            // 
            txtQabTotalAmount.Location = new Point(427, 43);
            txtQabTotalAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtQabTotalAmount.Name = "txtQabTotalAmount";
            txtQabTotalAmount.Size = new Size(150, 27);
            txtQabTotalAmount.TabIndex = 33;
            txtQabTotalAmount.ThousandsSeparator = true;
            // 
            // lblAllSalesText
            // 
            lblAllSalesText.BackColor = Color.FromArgb(255, 224, 192);
            lblAllSalesText.BorderStyle = BorderStyle.FixedSingle;
            lblAllSalesText.Location = new Point(592, 9);
            lblAllSalesText.Name = "lblAllSalesText";
            lblAllSalesText.Size = new Size(150, 31);
            lblAllSalesText.TabIndex = 32;
            lblAllSalesText.Text = "المبيعات";
            lblAllSalesText.Click += lblAllSalesText_Click;
            lblAllSalesText.DoubleClick += lblAllSalesText_DoubleClick;
            // 
            // label12
            // 
            label12.BackColor = Color.Green;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.ForeColor = Color.White;
            label12.Location = new Point(575, 350);
            label12.Name = "label12";
            label12.Size = new Size(150, 31);
            label12.TabIndex = 31;
            label12.Text = "الصندوق";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(51, 264);
            label8.Name = "label8";
            label8.Size = new Size(150, 31);
            label8.TabIndex = 30;
            label8.Text = "حوالات";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(225, 264);
            label9.Name = "label9";
            label9.Size = new Size(150, 31);
            label9.TabIndex = 29;
            label9.Text = "فيزا";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(224, 224, 224);
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(399, 264);
            label10.Name = "label10";
            label10.Size = new Size(150, 31);
            label10.TabIndex = 28;
            label10.Text = "شيكات";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(573, 264);
            label11.Name = "label11";
            label11.Size = new Size(150, 31);
            label11.TabIndex = 27;
            label11.Text = "نقدا";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.FromArgb(255, 192, 192);
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Location = new Point(392, 226);
            label17.Name = "label17";
            label17.Size = new Size(350, 31);
            label17.TabIndex = 26;
            label17.Text = "المصاريف";
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(192, 255, 192);
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Location = new Point(392, 103);
            label16.Name = "label16";
            label16.Size = new Size(350, 31);
            label16.TabIndex = 25;
            label16.Text = "المقبوصات";
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTo.AutoSize = true;
            lblTo.Location = new Point(281, 48);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(31, 20);
            lblTo.TabIndex = 27;
            lblTo.Text = "الى";
            // 
            // txtTo_Trans_Date
            // 
            txtTo_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Trans_Date.Location = new Point(154, 48);
            txtTo_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTo_Trans_Date.Name = "txtTo_Trans_Date";
            txtTo_Trans_Date.ShowCheckBox = true;
            txtTo_Trans_Date.Size = new Size(119, 27);
            txtTo_Trans_Date.TabIndex = 28;
            txtTo_Trans_Date.TabStop = false;
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(465, 48);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(87, 20);
            lblFrom.TabIndex = 25;
            lblFrom.Text = "التاريخ     من";
            // 
            // txtFrom_Trans_Date
            // 
            txtFrom_Trans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Trans_Date.Checked = false;
            txtFrom_Trans_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Trans_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Trans_Date.Location = new Point(332, 48);
            txtFrom_Trans_Date.Margin = new Padding(3, 4, 3, 4);
            txtFrom_Trans_Date.Name = "txtFrom_Trans_Date";
            txtFrom_Trans_Date.ShowCheckBox = true;
            txtFrom_Trans_Date.Size = new Size(125, 27);
            txtFrom_Trans_Date.TabIndex = 26;
            txtFrom_Trans_Date.TabStop = false;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(36, 48);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(112, 31);
            btnGetData.TabIndex = 29;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // cmbPeriod
            // 
            cmbPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.FormattingEnabled = true;
            cmbPeriod.Items.AddRange(new object[] { "اليوم", "اليوم السابق", "الاسبوع الحالي", "الشهر الحالي", "اخرى" });
            cmbPeriod.Location = new Point(591, 42);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(181, 28);
            cmbPeriod.TabIndex = 30;
            cmbPeriod.SelectedIndexChanged += cmbPeriod_SelectedIndexChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(cmbPeriod);
            Controls.Add(btnGetData);
            Controls.Add(lblTo);
            Controls.Add(txtTo_Trans_Date);
            Controls.Add(lblFrom);
            Controls.Add(txtFrom_Trans_Date);
            Controls.Add(panel1);
            Name = "DashboardForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ملخص الحركات";
            ((System.ComponentModel.ISupportInitialize)txtSalesInvoiceAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCashQabdAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChequeQabdAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVisaQabdAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTransfereQabdAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTransfereSarfAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVisaSarfAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChequeSarfAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCashSarfAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCashAvailableAmount).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDebitSalesInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQabTotalAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown txtSalesInvoiceAmount;
        private NumericUpDown txtDebitSalesInvoiceAmount;
        private Label label2;
        private NumericUpDown txtTotalSales;
        private Label label3;
        private NumericUpDown txtCashQabdAmount;
        private Label label4;
        private NumericUpDown txtChequeQabdAmount;
        private Label label5;
        private NumericUpDown txtVisaQabdAmount;
        private Label label6;
        private NumericUpDown txtTransfereQabdAmount;
        private Label label7;
        private NumericUpDown txtTransfereSarfAmount;
        private NumericUpDown txtVisaSarfAmount;
        private NumericUpDown txtChequeSarfAmount;
        private NumericUpDown txtCashSarfAmount;
        private NumericUpDown txtCashAvailableAmount;
        private Panel panel1;
        private Label lblTo;
        private DateTimePicker txtTo_Trans_Date;
        private Label lblFrom;
        private DateTimePicker txtFrom_Trans_Date;
        private Label label16;
        private Button btnGetData;
        private Label label17;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblAllSalesText;
        private Label label15;
        private NumericUpDown txtQabTotalAmount;
        private Label lblDebtitSalestText;
        private NumericUpDown txtDebitSalesInvoice;
        private ComboBox cmbPeriod;
    }
}