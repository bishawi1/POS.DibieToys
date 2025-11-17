namespace POS.Windows.Forms
{
    partial class PayWithChequeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayWithChequeDialog));
            imageList1 = new ImageList(components);
            btnCancel = new Button();
            btnOK = new Button();
            panel1 = new Panel();
            txtTrans_Details = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtCheque_Due_Date = new DateTimePicker();
            txtCheque_No = new MaskedTextBox();
            label9 = new Label();
            btnShow_Bank_ID_LOV = new Button();
            txtBank_ID = new MaskedTextBox();
            txtBank_Name = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SeachIcon.jpg");
            imageList1.Images.SetKeyName(1, "icons8-ok-50.png");
            imageList1.Images.SetKeyName(2, "icons8-cancel-50-red.png");
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "icons8-cancel-50-red.png";
            btnCancel.ImageList = imageList1;
            btnCancel.Location = new Point(42, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(397, 291);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 36;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTrans_Details);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtCheque_Due_Date);
            panel1.Controls.Add(txtCheque_No);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnShow_Bank_ID_LOV);
            panel1.Controls.Add(txtBank_ID);
            panel1.Controls.Add(txtBank_Name);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(26, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 268);
            panel1.TabIndex = 38;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Location = new Point(15, 102);
            txtTrans_Details.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(400, 148);
            txtTrans_Details.TabIndex = 25;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(429, 102);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 24;
            label11.Text = "البيان";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(127, 67);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 10;
            label10.Text = "تاريخ الاستحقاق";
            // 
            // txtCheque_Due_Date
            // 
            txtCheque_Due_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCheque_Due_Date.CustomFormat = "dd/MM/yyyy";
            txtCheque_Due_Date.Format = DateTimePickerFormat.Custom;
            txtCheque_Due_Date.Location = new Point(15, 67);
            txtCheque_Due_Date.Margin = new Padding(3, 4, 3, 4);
            txtCheque_Due_Date.Name = "txtCheque_Due_Date";
            txtCheque_Due_Date.Size = new Size(105, 27);
            txtCheque_Due_Date.TabIndex = 11;
            // 
            // txtCheque_No
            // 
            txtCheque_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCheque_No.Location = new Point(310, 67);
            txtCheque_No.Margin = new Padding(3, 4, 3, 4);
            txtCheque_No.Mask = "000000000000000";
            txtCheque_No.Name = "txtCheque_No";
            txtCheque_No.Size = new Size(105, 27);
            txtCheque_No.TabIndex = 9;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(429, 67);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 8;
            label9.Text = "رقم الشيك";
            // 
            // btnShow_Bank_ID_LOV
            // 
            btnShow_Bank_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Bank_ID_LOV.Image = Properties.Resources.List;
            btnShow_Bank_ID_LOV.Location = new Point(332, 28);
            btnShow_Bank_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Bank_ID_LOV.Name = "btnShow_Bank_ID_LOV";
            btnShow_Bank_ID_LOV.Size = new Size(31, 31);
            btnShow_Bank_ID_LOV.TabIndex = 6;
            btnShow_Bank_ID_LOV.TabStop = false;
            btnShow_Bank_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Bank_ID_LOV.Click += btnShow_Bank_ID_LOV_Click;
            // 
            // txtBank_ID
            // 
            txtBank_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_ID.Location = new Point(370, 30);
            txtBank_ID.Margin = new Padding(3, 4, 3, 4);
            txtBank_ID.Mask = "00000";
            txtBank_ID.Name = "txtBank_ID";
            txtBank_ID.Size = new Size(45, 27);
            txtBank_ID.TabIndex = 5;
            // 
            // txtBank_Name
            // 
            txtBank_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_Name.BackColor = Color.White;
            txtBank_Name.Location = new Point(15, 28);
            txtBank_Name.Margin = new Padding(3, 4, 3, 4);
            txtBank_Name.Name = "txtBank_Name";
            txtBank_Name.ReadOnly = true;
            txtBank_Name.Size = new Size(312, 27);
            txtBank_Name.TabIndex = 7;
            txtBank_Name.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(429, 28);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 4;
            label8.Text = "البنك";
            // 
            // PayWithChequeDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 363);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayWithChequeDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفع بالشيك";
            Load += PayWithChequeDialog_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button btnCancel;
        private Button btnOK;
        private Panel panel1;
        private Button btnShow_Bank_ID_LOV;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        public MaskedTextBox txtBank_ID;
        public TextBox txtBank_Name;
        public DateTimePicker txtCheque_Due_Date;
        public MaskedTextBox txtCheque_No;
        public TextBox txtTrans_Details;
    }
}