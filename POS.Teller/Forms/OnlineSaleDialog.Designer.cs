namespace POS.Teller.Forms
{
    partial class OnlineSaleDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineSaleDialog));
            label1 = new Label();
            txtNotes = new TextBox();
            panel1 = new Panel();
            btnFeesNumericCalc = new PictureBox();
            txtDelevery_Transaction_No = new TextBox();
            label4 = new Label();
            txtDelevery_Fees = new TextBox();
            label3 = new Label();
            cmbDelevery_Place = new ComboBox();
            label2 = new Label();
            imageList1 = new ImageList(components);
            btnOK = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFeesNumericCalc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(411, 164);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 12F);
            txtNotes.Location = new Point(21, 164);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(384, 81);
            txtNotes.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnFeesNumericCalc);
            panel1.Controls.Add(txtDelevery_Transaction_No);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDelevery_Fees);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbDelevery_Place);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 263);
            panel1.TabIndex = 2;
            // 
            // btnFeesNumericCalc
            // 
            btnFeesNumericCalc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFeesNumericCalc.Image = Properties.Resources.NumericKeyboard;
            btnFeesNumericCalc.Location = new Point(192, 115);
            btnFeesNumericCalc.Name = "btnFeesNumericCalc";
            btnFeesNumericCalc.Size = new Size(50, 43);
            btnFeesNumericCalc.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFeesNumericCalc.TabIndex = 15;
            btnFeesNumericCalc.TabStop = false;
            btnFeesNumericCalc.Click += btnFeesNumericCalc_Click;
            // 
            // txtDelevery_Transaction_No
            // 
            txtDelevery_Transaction_No.Font = new Font("Segoe UI", 12F);
            txtDelevery_Transaction_No.Location = new Point(147, 15);
            txtDelevery_Transaction_No.Name = "txtDelevery_Transaction_No";
            txtDelevery_Transaction_No.Size = new Size(258, 34);
            txtDelevery_Transaction_No.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(411, 17);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 6;
            label4.Text = "رقم البوليصة";
            // 
            // txtDelevery_Fees
            // 
            txtDelevery_Fees.Font = new Font("Segoe UI", 12F);
            txtDelevery_Fees.Location = new Point(248, 115);
            txtDelevery_Fees.Name = "txtDelevery_Fees";
            txtDelevery_Fees.Size = new Size(157, 34);
            txtDelevery_Fees.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(411, 115);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 4;
            label3.Text = "المبلغ";
            // 
            // cmbDelevery_Place
            // 
            cmbDelevery_Place.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDelevery_Place.Font = new Font("Segoe UI", 12F);
            cmbDelevery_Place.FormattingEnabled = true;
            cmbDelevery_Place.Items.AddRange(new object[] { "الضفة", "القدس", "الداخل" });
            cmbDelevery_Place.Location = new Point(234, 64);
            cmbDelevery_Place.Name = "cmbDelevery_Place";
            cmbDelevery_Place.Size = new Size(171, 36);
            cmbDelevery_Place.TabIndex = 3;
            cmbDelevery_Place.SelectedIndexChanged += cmbDelevery_Place_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(411, 72);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 2;
            label2.Text = "مكان التوصيل";
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
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(391, 296);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 32;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "icons8-cancel-50-red.png";
            btnCancel.ImageList = imageList1;
            btnCancel.Location = new Point(6, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // OnlineSaleDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 379);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OnlineSaleDialog";
            RightToLeft = RightToLeft.Yes;
            Text = "بيع عن بعد Online";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnFeesNumericCalc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ImageList imageList1;
        private Button btnOK;
        private Button btnCancel;
        public TextBox txtNotes;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox btnFeesNumericCalc;
        public ComboBox cmbDelevery_Place;
        public TextBox txtDelevery_Transaction_No;
        public TextBox txtDelevery_Fees;
    }
}