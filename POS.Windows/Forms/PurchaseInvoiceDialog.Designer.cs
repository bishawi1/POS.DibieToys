namespace POS.Windows.Forms
{
    partial class PurchaseInvoiceDialog
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
            txtTrans_Details = new TextBox();
            label11 = new Label();
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
            btnCancel = new Button();
            btnOk = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTrans_Currency_Rate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVoucherId).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTrans_Details);
            panel1.Controls.Add(label11);
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
            panel1.Location = new Point(10, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 427);
            panel1.TabIndex = 0;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Location = new Point(40, 132);
            txtTrans_Details.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(571, 261);
            txtTrans_Details.TabIndex = 48;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(625, 132);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 47;
            label11.Text = "البيان";
            // 
            // txtManual_Trans_No
            // 
            txtManual_Trans_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtManual_Trans_No.Location = new Point(40, 20);
            txtManual_Trans_No.Margin = new Padding(3, 4, 3, 4);
            txtManual_Trans_No.Name = "txtManual_Trans_No";
            txtManual_Trans_No.ReadOnly = true;
            txtManual_Trans_No.Size = new Size(107, 27);
            txtManual_Trans_No.TabIndex = 36;
            txtManual_Trans_No.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(154, 20);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 35;
            label7.Text = "المرجعية";
            // 
            // txtTrans_Currency_Rate
            // 
            txtTrans_Currency_Rate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Currency_Rate.DecimalPlaces = 2;
            txtTrans_Currency_Rate.Location = new Point(40, 58);
            txtTrans_Currency_Rate.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Currency_Rate.Name = "txtTrans_Currency_Rate";
            txtTrans_Currency_Rate.Size = new Size(78, 27);
            txtTrans_Currency_Rate.TabIndex = 45;
            txtTrans_Currency_Rate.TabStop = false;
            txtTrans_Currency_Rate.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(124, 58);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 44;
            label6.Text = "س. صرف";
            label6.Visible = false;
            // 
            // btnShow_Trans_Currency_ID_LOV
            // 
            btnShow_Trans_Currency_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Trans_Currency_ID_LOV.Image = Properties.Resources.List;
            btnShow_Trans_Currency_ID_LOV.Location = new Point(351, 54);
            btnShow_Trans_Currency_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Trans_Currency_ID_LOV.Name = "btnShow_Trans_Currency_ID_LOV";
            btnShow_Trans_Currency_ID_LOV.Size = new Size(31, 31);
            btnShow_Trans_Currency_ID_LOV.TabIndex = 42;
            btnShow_Trans_Currency_ID_LOV.TabStop = false;
            btnShow_Trans_Currency_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Trans_Currency_ID_LOV.Click += btnShow_Trans_Currency_ID_LOV_Click;
            // 
            // txtTrans_Currency_ID
            // 
            txtTrans_Currency_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Currency_ID.Location = new Point(388, 54);
            txtTrans_Currency_ID.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Currency_ID.Mask = "00000";
            txtTrans_Currency_ID.Name = "txtTrans_Currency_ID";
            txtTrans_Currency_ID.Size = new Size(45, 27);
            txtTrans_Currency_ID.TabIndex = 41;
            // 
            // txtCurrency_Name
            // 
            txtCurrency_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrency_Name.BackColor = Color.White;
            txtCurrency_Name.Location = new Point(223, 54);
            txtCurrency_Name.Margin = new Padding(3, 4, 3, 4);
            txtCurrency_Name.Name = "txtCurrency_Name";
            txtCurrency_Name.ReadOnly = true;
            txtCurrency_Name.Size = new Size(122, 27);
            txtCurrency_Name.TabIndex = 43;
            txtCurrency_Name.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(439, 54);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 40;
            label5.Text = "العملة";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.DecimalPlaces = 1;
            txtAmount.Location = new Point(509, 54);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(103, 27);
            txtAmount.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(621, 54);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 29;
            label3.Text = "المبلغ";
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(529, 93);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(31, 31);
            btnShow_Person_ID_LOV.TabIndex = 33;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Person_ID_LOV.Click += btnShow_Person_ID_LOV_Click;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Location = new Point(566, 93);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(45, 27);
            txtPerson_No.TabIndex = 32;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Location = new Point(176, 93);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(347, 27);
            lblPerson_Name.TabIndex = 34;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.Location = new Point(621, 93);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(68, 27);
            lblPerson.TabIndex = 31;
            lblPerson.Text = "المورد";
            lblPerson.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(619, 18);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 25;
            label2.Text = "التاريخ";
            // 
            // txtTrans_Date
            // 
            txtTrans_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Date.CustomFormat = "dd/MM/yyyy";
            txtTrans_Date.Format = DateTimePickerFormat.Custom;
            txtTrans_Date.Location = new Point(507, 18);
            txtTrans_Date.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Date.Name = "txtTrans_Date";
            txtTrans_Date.Size = new Size(105, 27);
            txtTrans_Date.TabIndex = 26;
            txtTrans_Date.TabStop = false;
            // 
            // txtVoucherId
            // 
            txtVoucherId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtVoucherId.Location = new Point(260, 20);
            txtVoucherId.Margin = new Padding(3, 4, 3, 4);
            txtVoucherId.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtVoucherId.Name = "txtVoucherId";
            txtVoucherId.ReadOnly = true;
            txtVoucherId.Size = new Size(76, 27);
            txtVoucherId.TabIndex = 28;
            txtVoucherId.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 27;
            label1.Text = "رقم الفاتورة";
            // 
            // btnSaveAndNew
            // 
            btnSaveAndNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAndNew.Location = new Point(319, 445);
            btnSaveAndNew.Margin = new Padding(3, 4, 3, 4);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(109, 31);
            btnSaveAndNew.TabIndex = 5;
            btnSaveAndNew.Text = "حفظ ثم اضافة";
            btnSaveAndNew.UseVisualStyleBackColor = true;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(94, 445);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(520, 445);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(109, 31);
            btnOk.TabIndex = 4;
            btnOk.Text = "حفظ ثم اغلاق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // PurchaseInvoiceDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 495);
            Controls.Add(btnSaveAndNew);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PurchaseInvoiceDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاتورة مشتريات";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTrans_Currency_Rate).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVoucherId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTrans_Details;
        private Label label11;
        private TextBox txtManual_Trans_No;
        private Label label7;
        private NumericUpDown txtTrans_Currency_Rate;
        private Label label6;
        private Button btnShow_Trans_Currency_ID_LOV;
        private MaskedTextBox txtTrans_Currency_ID;
        private TextBox txtCurrency_Name;
        private Label label5;
        private NumericUpDown txtAmount;
        private Label label3;
        private Button btnShow_Person_ID_LOV;
        private MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private Label label2;
        private DateTimePicker txtTrans_Date;
        private NumericUpDown txtVoucherId;
        private Label label1;
        private Button btnSaveAndNew;
        private Button btnCancel;
        private Button btnOk;
    }
}