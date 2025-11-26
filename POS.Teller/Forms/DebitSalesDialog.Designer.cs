namespace POS.Teller.Forms
{
    partial class DebitSalesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitSalesDialog));
            panel1 = new Panel();
            txtTrans_Details = new TextBox();
            label11 = new Label();
            txtAmount = new NumericUpDown();
            label3 = new Label();
            btnShow_Person_ID_LOV = new Button();
            txtPerson_No = new MaskedTextBox();
            lblPerson_Name = new TextBox();
            lblPerson = new Label();
            imageList1 = new ImageList(components);
            btnCancel = new Button();
            btnOK = new Button();
            btnBarcodeNumericCalc = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnBarcodeNumericCalc);
            panel1.Controls.Add(txtTrans_Details);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnShow_Person_ID_LOV);
            panel1.Controls.Add(txtPerson_No);
            panel1.Controls.Add(lblPerson_Name);
            panel1.Controls.Add(lblPerson);
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 270);
            panel1.TabIndex = 0;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Location = new Point(47, 120);
            txtTrans_Details.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(400, 129);
            txtTrans_Details.TabIndex = 27;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(461, 120);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 26;
            label11.Text = "البيان";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.DecimalPlaces = 1;
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.Location = new Point(310, 69);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(137, 34);
            txtAmount.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(466, 72);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "المبلغ";
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Font = new Font("Segoe UI", 12F);
            btnShow_Person_ID_LOV.Image = Properties.Resources.List;
            btnShow_Person_ID_LOV.Location = new Point(342, 21);
            btnShow_Person_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(42, 40);
            btnShow_Person_ID_LOV.TabIndex = 12;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Person_ID_LOV.Click += btnShow_Person_ID_LOV_Click;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Font = new Font("Segoe UI", 12F);
            txtPerson_No.Location = new Point(390, 21);
            txtPerson_No.Margin = new Padding(3, 4, 3, 4);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(57, 34);
            txtPerson_No.TabIndex = 11;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Font = new Font("Segoe UI", 12F);
            lblPerson_Name.Location = new Point(44, 21);
            lblPerson_Name.Margin = new Padding(3, 4, 3, 4);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(292, 34);
            lblPerson_Name.TabIndex = 13;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(461, 21);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(47, 20);
            lblPerson.TabIndex = 10;
            lblPerson.Text = "الزبون";
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
            btnCancel.Location = new Point(37, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 39;
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
            btnOK.Location = new Point(392, 296);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 38;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnBarcodeNumericCalc
            // 
            btnBarcodeNumericCalc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBarcodeNumericCalc.Image = Properties.Resources.NumericKeyboard;
            btnBarcodeNumericCalc.Location = new Point(254, 69);
            btnBarcodeNumericCalc.Name = "btnBarcodeNumericCalc";
            btnBarcodeNumericCalc.Size = new Size(50, 34);
            btnBarcodeNumericCalc.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBarcodeNumericCalc.TabIndex = 28;
            btnBarcodeNumericCalc.TabStop = false;
            btnBarcodeNumericCalc.Click += btnBarcodeNumericCalc_Click;
            // 
            // DebitSalesDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 366);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DebitSalesDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بيع ذمم";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnShow_Person_ID_LOV;
        private TextBox lblPerson_Name;
        private Label lblPerson;
        private Label label3;
        public TextBox txtTrans_Details;
        private Label label11;
        private ImageList imageList1;
        private Button btnCancel;
        private Button btnOK;
        public MaskedTextBox txtPerson_No;
        public NumericUpDown txtAmount;
        private PictureBox btnBarcodeNumericCalc;
    }
}