namespace POS.Windows.Forms
{
    partial class PayByCreditCardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayByCreditCardDialog));
            panel1 = new Panel();
            txtNotes = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            btnCancel = new Button();
            btnOK = new Button();
            label2 = new Label();
            lblAmount = new Label();
            btnDiscountPercent = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDiscountPercent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(btnDiscountPercent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 200);
            panel1.TabIndex = 3;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 12F);
            txtNotes.Location = new Point(10, 67);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(336, 115);
            txtNotes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(360, 67);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "ملاحظات";
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
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "icons8-cancel-50-red.png";
            btnCancel.ImageList = imageList1;
            btnCancel.Location = new Point(21, 223);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 60);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(358, 223);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(124, 60);
            btnOK.TabIndex = 34;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(360, 25);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 2;
            label2.Text = "المبلغ";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAmount.BackColor = Color.White;
            lblAmount.BorderStyle = BorderStyle.Fixed3D;
            lblAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAmount.Location = new Point(255, 25);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(91, 27);
            lblAmount.TabIndex = 17;
            lblAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDiscountPercent
            // 
            btnDiscountPercent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiscountPercent.Image = (Image)resources.GetObject("btnDiscountPercent.Image");
            btnDiscountPercent.Location = new Point(212, 23);
            btnDiscountPercent.Margin = new Padding(3, 2, 3, 2);
            btnDiscountPercent.Name = "btnDiscountPercent";
            btnDiscountPercent.Size = new Size(44, 27);
            btnDiscountPercent.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDiscountPercent.TabIndex = 16;
            btnDiscountPercent.TabStop = false;
            btnDiscountPercent.Click += btnDiscountPercent_Click;
            // 
            // PayByCreditCardDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 294);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PayByCreditCardDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بيع بالفيزا";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDiscountPercent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public TextBox txtNotes;
        private Label label1;
        private ImageList imageList1;
        private Button btnCancel;
        private Button btnOK;
        private Label label2;
        private Label lblAmount;
        private PictureBox btnDiscountPercent;
    }
}