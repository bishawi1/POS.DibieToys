namespace POS.Windows.Forms
{
    partial class ManualProductUnitPriceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualProductUnitPriceDialog));
            imageList1 = new ImageList(components);
            btnCancel = new Button();
            btnOK = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblItemUnitPrice = new Label();
            txtTrans_Details = new TextBox();
            label11 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnCancel.Location = new Point(34, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 41;
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
            btnOK.Location = new Point(389, 238);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 40;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblItemUnitPrice);
            panel1.Controls.Add(txtTrans_Details);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 212);
            panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.NumericKeyboard;
            pictureBox1.Location = new Point(245, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblItemUnitPrice
            // 
            lblItemUnitPrice.BackColor = Color.White;
            lblItemUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            lblItemUnitPrice.Font = new Font("Segoe UI", 12F);
            lblItemUnitPrice.Location = new Point(301, 22);
            lblItemUnitPrice.Name = "lblItemUnitPrice";
            lblItemUnitPrice.Size = new Size(118, 41);
            lblItemUnitPrice.TabIndex = 32;
            // 
            // txtTrans_Details
            // 
            txtTrans_Details.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTrans_Details.Font = new Font("Segoe UI", 12F);
            txtTrans_Details.Location = new Point(19, 83);
            txtTrans_Details.Margin = new Padding(3, 4, 3, 4);
            txtTrans_Details.Multiline = true;
            txtTrans_Details.Name = "txtTrans_Details";
            txtTrans_Details.Size = new Size(400, 113);
            txtTrans_Details.TabIndex = 31;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(438, 83);
            label11.Name = "label11";
            label11.Size = new Size(56, 28);
            label11.TabIndex = 30;
            label11.Text = "البيان";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(425, 22);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 28;
            label3.Text = "سعر الوحدة";
            // 
            // ManualProductUnitPriceDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 310);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManualProductUnitPriceDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تحديد سعر المنتج/الخدمة";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button btnCancel;
        private Button btnOK;
        private Panel panel1;
        public TextBox txtTrans_Details;
        private Label label11;
        private Label label3;
        private PictureBox pictureBox1;
        public Label lblItemUnitPrice;
    }
}