namespace POS.Teller.Forms
{
    partial class TicketDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketDialog));
            imageList1 = new ImageList(components);
            btnOK = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            btnShow_Discount_Calculator = new PictureBox();
            btnShow_Kids_Count_Calculator = new PictureBox();
            txtAmount_To_Pay = new TextBox();
            label5 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            txtTotal_Amount = new TextBox();
            label3 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            txtKids_Count = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnShow_Discount_Calculator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShow_Kids_Count_Calculator).BeginInit();
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
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(203, 240);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(124, 63);
            btnOK.TabIndex = 39;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "icons8-cancel-50-red.png";
            btnCancel.ImageList = imageList1;
            btnCancel.Location = new Point(15, 240);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 63);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow_Discount_Calculator);
            panel1.Controls.Add(btnShow_Kids_Count_Calculator);
            panel1.Controls.Add(txtAmount_To_Pay);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTotal_Amount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtKids_Count);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 227);
            panel1.TabIndex = 41;
            // 
            // btnShow_Discount_Calculator
            // 
            btnShow_Discount_Calculator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Discount_Calculator.Image = (Image)resources.GetObject("btnShow_Discount_Calculator.Image");
            btnShow_Discount_Calculator.Location = new Point(16, 137);
            btnShow_Discount_Calculator.Margin = new Padding(3, 2, 3, 2);
            btnShow_Discount_Calculator.Name = "btnShow_Discount_Calculator";
            btnShow_Discount_Calculator.Size = new Size(44, 26);
            btnShow_Discount_Calculator.SizeMode = PictureBoxSizeMode.StretchImage;
            btnShow_Discount_Calculator.TabIndex = 30;
            btnShow_Discount_Calculator.TabStop = false;
            btnShow_Discount_Calculator.Click += btnShow_Discount_Calculator_Click;
            // 
            // btnShow_Kids_Count_Calculator
            // 
            btnShow_Kids_Count_Calculator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Kids_Count_Calculator.Image = (Image)resources.GetObject("btnShow_Kids_Count_Calculator.Image");
            btnShow_Kids_Count_Calculator.Location = new Point(16, 25);
            btnShow_Kids_Count_Calculator.Margin = new Padding(3, 2, 3, 2);
            btnShow_Kids_Count_Calculator.Name = "btnShow_Kids_Count_Calculator";
            btnShow_Kids_Count_Calculator.Size = new Size(44, 26);
            btnShow_Kids_Count_Calculator.SizeMode = PictureBoxSizeMode.StretchImage;
            btnShow_Kids_Count_Calculator.TabIndex = 29;
            btnShow_Kids_Count_Calculator.TabStop = false;
            btnShow_Kids_Count_Calculator.Click += btnShow_Kids_Count_Calculator_Click;
            // 
            // txtAmount_To_Pay
            // 
            txtAmount_To_Pay.Font = new Font("Segoe UI", 13F);
            txtAmount_To_Pay.Location = new Point(65, 173);
            txtAmount_To_Pay.Margin = new Padding(3, 2, 3, 2);
            txtAmount_To_Pay.Name = "txtAmount_To_Pay";
            txtAmount_To_Pay.ReadOnly = true;
            txtAmount_To_Pay.Size = new Size(112, 31);
            txtAmount_To_Pay.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(182, 173);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 8;
            label5.Text = "المبلغ للدفع";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.White;
            txtDiscount.Font = new Font("Segoe UI", 13F);
            txtDiscount.Location = new Point(65, 136);
            txtDiscount.Margin = new Padding(3, 2, 3, 2);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(112, 31);
            txtDiscount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(182, 136);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "الخصم";
            // 
            // txtTotal_Amount
            // 
            txtTotal_Amount.Font = new Font("Segoe UI", 13F);
            txtTotal_Amount.Location = new Point(65, 98);
            txtTotal_Amount.Margin = new Padding(3, 2, 3, 2);
            txtTotal_Amount.Name = "txtTotal_Amount";
            txtTotal_Amount.ReadOnly = true;
            txtTotal_Amount.Size = new Size(112, 31);
            txtTotal_Amount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(182, 98);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "الاجمالي";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 13F);
            txtAmount.Location = new Point(65, 61);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(112, 31);
            txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(182, 61);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "ثمن التذكرة";
            // 
            // txtKids_Count
            // 
            txtKids_Count.BackColor = Color.White;
            txtKids_Count.Font = new Font("Segoe UI", 13F);
            txtKids_Count.Location = new Point(65, 23);
            txtKids_Count.Margin = new Padding(3, 2, 3, 2);
            txtKids_Count.Name = "txtKids_Count";
            txtKids_Count.ReadOnly = true;
            txtKids_Count.Size = new Size(112, 31);
            txtKids_Count.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(182, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "عدد التذاكر";
            // 
            // TicketDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 312);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicketDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تذاكر الالعاب";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnShow_Discount_Calculator).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShow_Kids_Count_Calculator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button btnOK;
        private Button btnCancel;
        private Panel panel1;
        private TextBox txtAmount_To_Pay;
        private Label label5;
        private TextBox txtDiscount;
        private Label label4;
        private TextBox txtTotal_Amount;
        private Label label3;
        private TextBox txtAmount;
        private Label label2;
        private TextBox txtKids_Count;
        private Label label1;
        private PictureBox btnShow_Discount_Calculator;
        private PictureBox btnShow_Kids_Count_Calculator;
    }
}