namespace POS.Teller.Forms
{
    partial class PayDetailsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayDetailsDialog));
            panel1 = new Panel();
            btnBarcodeNumericCalc = new PictureBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Location = new Point(10, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 280);
            panel1.TabIndex = 0;
            // 
            // btnBarcodeNumericCalc
            // 
            btnBarcodeNumericCalc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBarcodeNumericCalc.Image = (Image)resources.GetObject("btnBarcodeNumericCalc.Image");
            btnBarcodeNumericCalc.Location = new Point(234, 55);
            btnBarcodeNumericCalc.Margin = new Padding(3, 2, 3, 2);
            btnBarcodeNumericCalc.Name = "btnBarcodeNumericCalc";
            btnBarcodeNumericCalc.Size = new Size(44, 26);
            btnBarcodeNumericCalc.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBarcodeNumericCalc.TabIndex = 37;
            btnBarcodeNumericCalc.TabStop = false;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Location = new Point(53, 93);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(350, 98);
            txtTrans_Details.TabIndex = 36;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(415, 93);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 35;
            label11.Text = "البيان";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.DecimalPlaces = 1;
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.Location = new Point(283, 55);
            txtAmount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(120, 29);
            txtAmount.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(420, 57);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 33;
            label3.Text = "المبلغ";
            // 
            // btnShow_Person_ID_LOV
            // 
            btnShow_Person_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Person_ID_LOV.Font = new Font("Segoe UI", 12F);
            btnShow_Person_ID_LOV.Image = (Image)resources.GetObject("btnShow_Person_ID_LOV.Image");
            btnShow_Person_ID_LOV.Location = new Point(311, 19);
            btnShow_Person_ID_LOV.Name = "btnShow_Person_ID_LOV";
            btnShow_Person_ID_LOV.Size = new Size(37, 30);
            btnShow_Person_ID_LOV.TabIndex = 31;
            btnShow_Person_ID_LOV.TabStop = false;
            btnShow_Person_ID_LOV.UseVisualStyleBackColor = true;
            // 
            // txtPerson_No
            // 
            txtPerson_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_No.Font = new Font("Segoe UI", 12F);
            txtPerson_No.Location = new Point(353, 19);
            txtPerson_No.Mask = "00000";
            txtPerson_No.Name = "txtPerson_No";
            txtPerson_No.Size = new Size(50, 29);
            txtPerson_No.TabIndex = 30;
            // 
            // lblPerson_Name
            // 
            lblPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson_Name.BackColor = Color.White;
            lblPerson_Name.Font = new Font("Segoe UI", 12F);
            lblPerson_Name.Location = new Point(50, 19);
            lblPerson_Name.Name = "lblPerson_Name";
            lblPerson_Name.ReadOnly = true;
            lblPerson_Name.Size = new Size(256, 29);
            lblPerson_Name.TabIndex = 32;
            lblPerson_Name.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(415, 19);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(37, 15);
            lblPerson.TabIndex = 29;
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
            btnCancel.Location = new Point(34, 300);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 56);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(345, 300);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(124, 56);
            btnOK.TabIndex = 40;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // PayDetailsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 362);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayDetailsDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayDetailsDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private Button btnCancel;
        private Button btnOK;
        private PictureBox btnBarcodeNumericCalc;
        public TextBox txtTrans_Details;
        private Label label11;
        public NumericUpDown txtAmount;
        private Label label3;
        private Button btnShow_Person_ID_LOV;
        public MaskedTextBox txtPerson_No;
        private TextBox lblPerson_Name;
        private Label lblPerson;
    }
}