namespace POS.Windows.Forms
{
    partial class VoucherDialog
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
            btnOk = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            btnBackAssistantCalculator = new Button();
            lblPay_Way_ID = new Label();
            cmbPay_Way_Id = new ComboBox();
            btnShowReference_Transaction = new Button();
            txtTrans_Details = new TextBox();
            label11 = new Label();
            grpCheques = new GroupBox();
            label10 = new Label();
            txtCheque_Due_Date = new DateTimePicker();
            txtCheque_No = new MaskedTextBox();
            label9 = new Label();
            btnShow_Bank_ID_LOV = new Button();
            txtBank_ID = new MaskedTextBox();
            txtBank_Name = new TextBox();
            label8 = new Label();
            txtManual_Trans_No = new TextBox();
            label7 = new Label();
            txtTrans_Currency_Rate = new NumericUpDown();
            label6 = new Label();
            btnShow_Trans_Currency_ID_LOV = new Button();
            txtTrans_Currency_ID = new MaskedTextBox();
            txtCurrency_Name = new TextBox();
            label5 = new Label();
            txtAmount = new NumericUpDown();
            label3 = new Label();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            lblPerson = new Label();
            label2 = new Label();
            txtTrans_Date = new DateTimePicker();
            txtVoucherId = new NumericUpDown();
            label1 = new Label();
            btnSaveAndNew = new Button();
            panel1.SuspendLayout();
            grpCheques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTrans_Currency_Rate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVoucherId).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(508, 449);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(109, 31);
            btnOk.TabIndex = 1;
            btnOk.Text = "حفظ ثم اغلاق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(82, 449);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnBackAssistantCalculator);
            panel1.Controls.Add(lblPay_Way_ID);
            panel1.Controls.Add(cmbPay_Way_Id);
            panel1.Controls.Add(btnShowReference_Transaction);
            panel1.Controls.Add(txtTrans_Details);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(grpCheques);
            panel1.Controls.Add(txtManual_Trans_No);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTrans_Currency_Rate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnShow_Trans_Currency_ID_LOV);
            panel1.Controls.Add(txtTrans_Currency_ID);
            panel1.Controls.Add(txtCurrency_Name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnShow_Person_ID_LOV);
            panel1.Controls.Add(txtPerson_No);
            panel1.Controls.Add(lblPerson_Name);
            panel1.Controls.Add(lblPerson);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTrans_Date);
            panel1.Controls.Add(txtVoucherId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 431);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnBackAssistantCalculator
            // 
            btnBackAssistantCalculator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackAssistantCalculator.Location = new Point(97, 45);
            btnBackAssistantCalculator.Margin = new Padding(3, 4, 3, 4);
            btnBackAssistantCalculator.Name = "btnBackAssistantCalculator";
            btnBackAssistantCalculator.Size = new Size(30, 31);
            btnBackAssistantCalculator.TabIndex = 15;
            btnBackAssistantCalculator.Text = "...";
            btnBackAssistantCalculator.UseVisualStyleBackColor = true;
            btnBackAssistantCalculator.Visible = false;
            btnBackAssistantCalculator.Click += btnBackAssistantCalculator_Click;
            // 
            // lblPay_Way_ID
            // 
            lblPay_Way_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPay_Way_ID.AutoSize = true;
            lblPay_Way_ID.Location = new Point(538, 81);
            lblPay_Way_ID.Name = "lblPay_Way_ID";
            lblPay_Way_ID.Size = new Size(88, 20);
            lblPay_Way_ID.TabIndex = 13;
            lblPay_Way_ID.Text = "طريقة الدفع";
            // 
            // cmbPay_Way_Id
            // 
            cmbPay_Way_Id.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPay_Way_Id.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPay_Way_Id.FormattingEnabled = true;
            cmbPay_Way_Id.Items.AddRange(new object[] { "ذمم", "نقدي", "شيكات", "حوالة مالية", "فيزا" });
            cmbPay_Way_Id.Location = new Point(429, 81);
            cmbPay_Way_Id.Margin = new Padding(3, 4, 3, 4);
            cmbPay_Way_Id.Name = "cmbPay_Way_Id";
            cmbPay_Way_Id.Size = new Size(103, 28);
            cmbPay_Way_Id.TabIndex = 14;
            cmbPay_Way_Id.SelectedIndexChanged += cmbPay_Way_Id_SelectedIndexChanged;
            // 
            // btnShowReference_Transaction
            // 
            btnShowReference_Transaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowReference_Transaction.Location = new Point(25, 7);
            btnShowReference_Transaction.Margin = new Padding(3, 4, 3, 4);
            btnShowReference_Transaction.Name = "btnShowReference_Transaction";
            btnShowReference_Transaction.Size = new Size(41, 31);
            btnShowReference_Transaction.TabIndex = 12;
            btnShowReference_Transaction.Text = "...";
            btnShowReference_Transaction.UseVisualStyleBackColor = true;
            btnShowReference_Transaction.Click += btnShowReference_Transaction_Click;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Location = new Point(15, 283);
            txtTrans_Details.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(517, 137);
            txtTrans_Details.TabIndex = 24;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(545, 285);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 23;
            label11.Text = "البيان";
            // 
            // grpCheques
            // 
            grpCheques.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpCheques.Controls.Add(label10);
            grpCheques.Controls.Add(txtCheque_Due_Date);
            grpCheques.Controls.Add(txtCheque_No);
            grpCheques.Controls.Add(label9);
            grpCheques.Controls.Add(btnShow_Bank_ID_LOV);
            grpCheques.Controls.Add(txtBank_ID);
            grpCheques.Controls.Add(txtBank_Name);
            grpCheques.Controls.Add(label8);
            grpCheques.Location = new Point(15, 154);
            grpCheques.Margin = new Padding(3, 4, 3, 4);
            grpCheques.Name = "grpCheques";
            grpCheques.Padding = new Padding(3, 4, 3, 4);
            grpCheques.Size = new Size(517, 120);
            grpCheques.TabIndex = 22;
            grpCheques.TabStop = false;
            grpCheques.Text = " الشيك ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(194, 68);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 6;
            label10.Text = "تاريخ الاستحقاق";
            // 
            // txtCheque_Due_Date
            // 
            txtCheque_Due_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCheque_Due_Date.CustomFormat = "dd/MM/yyyy";
            txtCheque_Due_Date.Format = DateTimePickerFormat.Custom;
            txtCheque_Due_Date.Location = new Point(82, 68);
            txtCheque_Due_Date.Margin = new Padding(3, 4, 3, 4);
            txtCheque_Due_Date.Name = "txtCheque_Due_Date";
            txtCheque_Due_Date.Size = new Size(105, 27);
            txtCheque_Due_Date.TabIndex = 7;
            // 
            // txtCheque_No
            // 
            txtCheque_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCheque_No.Location = new Point(318, 68);
            txtCheque_No.Margin = new Padding(3, 4, 3, 4);
            txtCheque_No.Mask = "000000000000000";
            txtCheque_No.Name = "txtCheque_No";
            txtCheque_No.Size = new Size(105, 27);
            txtCheque_No.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(437, 68);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 4;
            label9.Text = "رقم الشيك";
            // 
            // btnShow_Bank_ID_LOV
            // 
            btnShow_Bank_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Bank_ID_LOV.Image = Properties.Resources.List;
            btnShow_Bank_ID_LOV.Location = new Point(340, 29);
            btnShow_Bank_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Bank_ID_LOV.Name = "btnShow_Bank_ID_LOV";
            btnShow_Bank_ID_LOV.Size = new Size(31, 31);
            btnShow_Bank_ID_LOV.TabIndex = 2;
            btnShow_Bank_ID_LOV.TabStop = false;
            btnShow_Bank_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Bank_ID_LOV.Click += btnShow_Bank_ID_LOV_Click;
            // 
            // txtBank_ID
            // 
            txtBank_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_ID.Location = new Point(378, 31);
            txtBank_ID.Margin = new Padding(3, 4, 3, 4);
            txtBank_ID.Mask = "00000";
            txtBank_ID.Name = "txtBank_ID";
            txtBank_ID.Size = new Size(45, 27);
            txtBank_ID.TabIndex = 1;
            // 
            // txtBank_Name
            // 
            txtBank_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_Name.BackColor = Color.White;
            txtBank_Name.Location = new Point(82, 29);
            txtBank_Name.Margin = new Padding(3, 4, 3, 4);
            txtBank_Name.Name = "txtBank_Name";
            txtBank_Name.ReadOnly = true;
            txtBank_Name.Size = new Size(253, 27);
            txtBank_Name.TabIndex = 3;
            txtBank_Name.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(437, 29);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 0;
            label8.Text = "البنك";
            // 
            // txtManual_Trans_No
            // 
            txtManual_Trans_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtManual_Trans_No.Location = new Point(72, 9);
            txtManual_Trans_No.Margin = new Padding(3, 4, 3, 4);
            txtManual_Trans_No.Name = "txtManual_Trans_No";
            txtManual_Trans_No.ReadOnly = true;
            txtManual_Trans_No.Size = new Size(107, 27);
            txtManual_Trans_No.TabIndex = 11;
            txtManual_Trans_No.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(186, 9);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 10;
            label7.Text = "المرجعية";
            // 
            // txtTrans_Currency_Rate
            // 
            txtTrans_Currency_Rate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Currency_Rate.DecimalPlaces = 2;
            txtTrans_Currency_Rate.Location = new Point(256, 81);
            txtTrans_Currency_Rate.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Currency_Rate.Name = "txtTrans_Currency_Rate";
            txtTrans_Currency_Rate.Size = new Size(78, 27);
            txtTrans_Currency_Rate.TabIndex = 21;
            txtTrans_Currency_Rate.TabStop = false;
            txtTrans_Currency_Rate.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(340, 81);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 20;
            label6.Text = "س. صرف";
            label6.Visible = false;
            // 
            // btnShow_Trans_Currency_ID_LOV
            // 
            btnShow_Trans_Currency_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Trans_Currency_ID_LOV.Image = Properties.Resources.List;
            btnShow_Trans_Currency_ID_LOV.Location = new Point(250, 45);
            btnShow_Trans_Currency_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Trans_Currency_ID_LOV.Name = "btnShow_Trans_Currency_ID_LOV";
            btnShow_Trans_Currency_ID_LOV.Size = new Size(31, 31);
            btnShow_Trans_Currency_ID_LOV.TabIndex = 18;
            btnShow_Trans_Currency_ID_LOV.TabStop = false;
            btnShow_Trans_Currency_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Trans_Currency_ID_LOV.Click += btnShow_Trans_Currency_ID_LOV_Click;
            // 
            // txtTrans_Currency_ID
            // 
            txtTrans_Currency_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Currency_ID.Location = new Point(287, 45);
            txtTrans_Currency_ID.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Currency_ID.Mask = "00000";
            txtTrans_Currency_ID.Name = "txtTrans_Currency_ID";
            txtTrans_Currency_ID.Size = new Size(45, 27);
            txtTrans_Currency_ID.TabIndex = 17;
            txtTrans_Currency_ID.MaskInputRejected += txtTrans_Currency_ID_MaskInputRejected;
            // 
            // txtCurrency_Name
            // 
            txtCurrency_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrency_Name.BackColor = Color.White;
            txtCurrency_Name.Location = new Point(122, 45);
            txtCurrency_Name.Margin = new Padding(3, 4, 3, 4);
            txtCurrency_Name.Name = "txtCurrency_Name";
            txtCurrency_Name.ReadOnly = true;
            txtCurrency_Name.Size = new Size(122, 27);
            txtCurrency_Name.TabIndex = 19;
            txtCurrency_Name.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(338, 45);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 16;
            label5.Text = "العملة";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.DecimalPlaces = 1;
            txtAmount.Location = new Point(429, 45);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(103, 27);
            txtAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(541, 45);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "المبلغ";
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(450, 118);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 8;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Person_ID_LOV.Click += btnShow_Person_ID_LOV_Click;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(487, 118);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 7;
            txtPerson_No.MaskInputRejected += txtPerson_No_MaskInputRejected;
            txtPerson_No.Validating += txtPerson_No_Validating;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(97, 118);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(347, 27);
            lblPerson_Name.TabIndex = 9;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.Location = new Point(538, 118);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(126, 27);
            lblPerson.TabIndex = 6;
            lblPerson.Text = "الزبون";
            lblPerson.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(539, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "التاريخ";
            // 
            // txtTrans_Date
            // 
            txtTrans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Date.CustomFormat = "dd/MM/yyyy";
            txtTrans_Date.Format = DateTimePickerFormat.Custom;
            txtTrans_Date.Location = new Point(427, 9);
            txtTrans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Date.Name = "txtTrans_Date";
            txtTrans_Date.Size = new Size(105, 27);
            txtTrans_Date.TabIndex = 1;
            txtTrans_Date.TabStop = false;
            // 
            // txtVoucherId
            // 
            txtVoucherId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtVoucherId.Location = new Point(256, 9);
            txtVoucherId.Margin = new Padding(3, 4, 3, 4);
            txtVoucherId.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtVoucherId.Name = "txtVoucherId";
            txtVoucherId.ReadOnly = true;
            txtVoucherId.Size = new Size(76, 27);
            txtVoucherId.TabIndex = 3;
            txtVoucherId.TabStop = false;
            txtVoucherId.ValueChanged += txtVoucherId_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "رقم الحركة";
            // 
            // btnSaveAndNew
            // 
            btnSaveAndNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAndNew.Location = new Point(307, 449);
            btnSaveAndNew.Margin = new Padding(3, 4, 3, 4);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(109, 31);
            btnSaveAndNew.TabIndex = 2;
            btnSaveAndNew.Text = "حفظ ثم اضافة";
            btnSaveAndNew.UseVisualStyleBackColor = true;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // VoucherDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 495);
            Controls.Add(btnSaveAndNew);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VoucherDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الحركة المالية";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpCheques.ResumeLayout(false);
            grpCheques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTrans_Currency_Rate).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVoucherId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Panel panel1;
        private NumericUpDown txtVoucherId;
        private Label label1;
        private Label label2;
        private DateTimePicker txtTrans_Date;
        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private Button btnShow_Trans_Currency_ID_LOV;
        private MaskedTextBox txtTrans_Currency_ID;
        private TextBox txtCurrency_Name;
        private Label label5;
        private NumericUpDown txtAmount;
        private Label label3;
        private TextBox txtManual_Trans_No;
        private Label label7;
        private NumericUpDown txtTrans_Currency_Rate;
        private Label label6;
        private GroupBox grpCheques;
        private TextBox txtTrans_Details;
        private Label label11;
        private Label label10;
        private DateTimePicker txtCheque_Due_Date;
        private MaskedTextBox txtCheque_No;
        private Label label9;
        private Button btnShow_Bank_ID_LOV;
        private MaskedTextBox txtBank_ID;
        private TextBox txtBank_Name;
        private Label label8;
        private Button btnShowReference_Transaction;
        private Label lblPay_Way_ID;
        private ComboBox cmbPay_Way_Id;
        private Button btnSaveAndNew;
        private Button btnBackAssistantCalculator;
    }
}