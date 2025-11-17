using POS.Windows.Properties;
namespace POS.Windows
{
    partial class CustomerDialog
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
            panel1 = new Panel();
            btnDelete = new Button();
            txtPerson_Account_ID = new MaskedTextBox();
            label10 = new Label();
            txtBegining_Balance_Amount = new NumericUpDown();
            label9 = new Label();
            txtPerson_Notes = new TextBox();
            label8 = new Label();
            txtCommercial_Name = new TextBox();
            label7 = new Label();
            txtMobile = new MaskedTextBox();
            label6 = new Label();
            txtSell_Discount_Percent = new NumericUpDown();
            label4 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtCity_ID = new MaskedTextBox();
            btnShow_City_ID_LOV = new Button();
            txtCity_Name = new TextBox();
            label5 = new Label();
            txtCustomer_Name = new TextBox();
            label3 = new Label();
            txtCustomer_No = new NumericUpDown();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            cmbDebitCredit = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBegining_Balance_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSell_Discount_Percent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomer_No).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbDebitCredit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtPerson_Account_ID);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBegining_Balance_Amount);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPerson_Notes);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCommercial_Name);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMobile);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSell_Discount_Percent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCity_ID);
            panel1.Controls.Add(btnShow_City_ID_LOV);
            panel1.Controls.Add(txtCity_Name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCustomer_Name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCustomer_No);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 17);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 455);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(3, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 51);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "الغاء";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPerson_Account_ID
            // 
            txtPerson_Account_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_Account_ID.Location = new Point(69, 194);
            txtPerson_Account_ID.Margin = new Padding(3, 4, 3, 4);
            txtPerson_Account_ID.Mask = "00000";
            txtPerson_Account_ID.Name = "txtPerson_Account_ID";
            txtPerson_Account_ID.Size = new Size(44, 27);
            txtPerson_Account_ID.TabIndex = 20;
            txtPerson_Account_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPerson_Account_ID.ValidatingType = typeof(int);
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(120, 197);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 19;
            label10.Text = "رقم الحساب/الصفحة";
            // 
            // txtBegining_Balance_Amount
            // 
            txtBegining_Balance_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBegining_Balance_Amount.DecimalPlaces = 1;
            txtBegining_Balance_Amount.Location = new Point(2, 240);
            txtBegining_Balance_Amount.Margin = new Padding(3, 4, 3, 4);
            txtBegining_Balance_Amount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtBegining_Balance_Amount.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            txtBegining_Balance_Amount.Name = "txtBegining_Balance_Amount";
            txtBegining_Balance_Amount.Size = new Size(110, 27);
            txtBegining_Balance_Amount.TabIndex = 18;
            txtBegining_Balance_Amount.TabStop = false;
            txtBegining_Balance_Amount.ThousandsSeparator = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(197, 240);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 17;
            label9.Text = "رصيد افتتاحي";
            // 
            // txtPerson_Notes
            // 
            txtPerson_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_Notes.Location = new Point(3, 351);
            txtPerson_Notes.Margin = new Padding(3, 4, 3, 4);
            txtPerson_Notes.Multiline = true;
            txtPerson_Notes.Name = "txtPerson_Notes";
            txtPerson_Notes.Size = new Size(469, 97);
            txtPerson_Notes.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(480, 351);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "ملاحظات";
            // 
            // txtCommercial_Name
            // 
            txtCommercial_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCommercial_Name.Location = new Point(3, 112);
            txtCommercial_Name.Margin = new Padding(3, 4, 3, 4);
            txtCommercial_Name.Name = "txtCommercial_Name";
            txtCommercial_Name.Size = new Size(469, 27);
            txtCommercial_Name.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(480, 112);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 3;
            label7.Text = "الاسم التجاري";
            // 
            // txtMobile
            // 
            txtMobile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMobile.Location = new Point(363, 197);
            txtMobile.Margin = new Padding(3, 4, 3, 4);
            txtMobile.Mask = "0000000000000";
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(109, 27);
            txtMobile.TabIndex = 10;
            txtMobile.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtMobile.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(480, 197);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 9;
            label6.Text = "موبايل";
            // 
            // txtSell_Discount_Percent
            // 
            txtSell_Discount_Percent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSell_Discount_Percent.Location = new Point(363, 240);
            txtSell_Discount_Percent.Margin = new Padding(3, 4, 3, 4);
            txtSell_Discount_Percent.Name = "txtSell_Discount_Percent";
            txtSell_Discount_Percent.Size = new Size(110, 27);
            txtSell_Discount_Percent.TabIndex = 12;
            txtSell_Discount_Percent.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(480, 240);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 11;
            label4.Text = "نسبة الخصم";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAddress.Location = new Point(3, 283);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(469, 59);
            txtAddress.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(480, 283);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "العنوان";
            // 
            // txtCity_ID
            // 
            txtCity_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCity_ID.Location = new Point(429, 155);
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
            btnShow_City_ID_LOV.Image = Resources.List;
            btnShow_City_ID_LOV.Location = new Point(393, 155);
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
            txtCity_Name.Location = new Point(2, 155);
            txtCity_Name.Margin = new Padding(3, 4, 3, 4);
            txtCity_Name.Name = "txtCity_Name";
            txtCity_Name.ReadOnly = true;
            txtCity_Name.Size = new Size(383, 27);
            txtCity_Name.TabIndex = 8;
            txtCity_Name.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(480, 155);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 5;
            label5.Text = "المدينة";
            // 
            // txtCustomer_Name
            // 
            txtCustomer_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomer_Name.Location = new Point(3, 69);
            txtCustomer_Name.Margin = new Padding(3, 4, 3, 4);
            txtCustomer_Name.Name = "txtCustomer_Name";
            txtCustomer_Name.Size = new Size(469, 27);
            txtCustomer_Name.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(480, 69);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "الاسم";
            // 
            // txtCustomer_No
            // 
            txtCustomer_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomer_No.Location = new Point(363, 27);
            txtCustomer_No.Margin = new Padding(3, 4, 3, 4);
            txtCustomer_No.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtCustomer_No.Name = "txtCustomer_No";
            txtCustomer_No.ReadOnly = true;
            txtCustomer_No.Size = new Size(110, 27);
            txtCustomer_No.TabIndex = 0;
            txtCustomer_No.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(480, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "رقم المواطن";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(499, 492);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 31);
            btnOk.TabIndex = 1;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(74, 492);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 31);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbDebitCredit
            // 
            cmbDebitCredit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDebitCredit.FormattingEnabled = true;
            cmbDebitCredit.ItemHeight = 20;
            cmbDebitCredit.Items.AddRange(new object[] { "لنا عنده", "له عندنا" });
            cmbDebitCredit.Location = new Point(124, 240);
            cmbDebitCredit.Name = "cmbDebitCredit";
            cmbDebitCredit.Size = new Size(67, 28);
            cmbDebitCredit.TabIndex = 22;
            // 
            // CustomerDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 539);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بطاقة الزبون";
            KeyDown += CustomerDialog_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBegining_Balance_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSell_Discount_Percent).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomer_No).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOk;
        private Button btnCancel;
        private NumericUpDown txtCustomer_No;
        private Label label1;
        private TextBox txtCustomer_Name;
        private Label label3;
        private NumericUpDown txtSell_Discount_Percent;
        private Label label4;
        private TextBox txtAddress;
        private Label label2;
        private MaskedTextBox txtCity_ID;
        private Button btnShow_City_ID_LOV;
        private TextBox txtCity_Name;
        private Label label5;
        private TextBox txtCommercial_Name;
        private Label label7;
        private MaskedTextBox txtMobile;
        private Label label6;
        private TextBox txtPerson_Notes;
        private Label label8;
        private NumericUpDown txtBegining_Balance_Amount;
        private Label label9;
        private MaskedTextBox txtPerson_Account_ID;
        private Label label10;
        private Button btnDelete;
        private ComboBox cmbDebitCredit;
    }
}