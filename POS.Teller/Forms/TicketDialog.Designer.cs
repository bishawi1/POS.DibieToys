namespace POS.Windows.Forms
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
            btnOK.Location = new Point(232, 334);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
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
            btnCancel.Location = new Point(17, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
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
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 306);
            panel1.TabIndex = 41;
            // 
            // btnShow_Discount_Calculator
            // 
            btnShow_Discount_Calculator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Discount_Calculator.Image = Properties.Resources.NumericKeyboard;
            btnShow_Discount_Calculator.Location = new Point(18, 183);
            btnShow_Discount_Calculator.Name = "btnShow_Discount_Calculator";
            btnShow_Discount_Calculator.Size = new Size(50, 34);
            btnShow_Discount_Calculator.SizeMode = PictureBoxSizeMode.StretchImage;
            btnShow_Discount_Calculator.TabIndex = 30;
            btnShow_Discount_Calculator.TabStop = false;
            btnShow_Discount_Calculator.Click += btnShow_Discount_Calculator_Click;
            // 
            // btnShow_Kids_Count_Calculator
            // 
            btnShow_Kids_Count_Calculator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Kids_Count_Calculator.Image = Properties.Resources.NumericKeyboard;
            btnShow_Kids_Count_Calculator.Location = new Point(18, 33);
            btnShow_Kids_Count_Calculator.Name = "btnShow_Kids_Count_Calculator";
            btnShow_Kids_Count_Calculator.Size = new Size(50, 34);
            btnShow_Kids_Count_Calculator.SizeMode = PictureBoxSizeMode.StretchImage;
            btnShow_Kids_Count_Calculator.TabIndex = 29;
            btnShow_Kids_Count_Calculator.TabStop = false;
            btnShow_Kids_Count_Calculator.Click += btnShow_Kids_Count_Calculator_Click;
            // 
            // txtAmount_To_Pay
            // 
            txtAmount_To_Pay.Font = new Font("Segoe UI", 13F);
            txtAmount_To_Pay.Location = new Point(74, 231);
            txtAmount_To_Pay.Name = "txtAmount_To_Pay";
            txtAmount_To_Pay.ReadOnly = true;
            txtAmount_To_Pay.Size = new Size(128, 36);
            txtAmount_To_Pay.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(208, 231);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 8;
            label5.Text = "المبلغ للدفع";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.White;
            txtDiscount.Font = new Font("Segoe UI", 13F);
            txtDiscount.Location = new Point(74, 181);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(128, 36);
            txtDiscount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(208, 181);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 6;
            label4.Text = "الخصم";
            // 
            // txtTotal_Amount
            // 
            txtTotal_Amount.Font = new Font("Segoe UI", 13F);
            txtTotal_Amount.Location = new Point(74, 131);
            txtTotal_Amount.Name = "txtTotal_Amount";
            txtTotal_Amount.ReadOnly = true;
            txtTotal_Amount.Size = new Size(128, 36);
            txtTotal_Amount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(208, 131);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "الاجمالي";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 13F);
            txtAmount.Location = new Point(74, 81);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(128, 36);
            txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(208, 81);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "ثمن التذكرة";
            // 
            // txtKids_Count
            // 
            txtKids_Count.BackColor = Color.White;
            txtKids_Count.Font = new Font("Segoe UI", 13F);
            txtKids_Count.Location = new Point(74, 31);
            txtKids_Count.Name = "txtKids_Count";
            txtKids_Count.ReadOnly = true;
            txtKids_Count.Size = new Size(128, 36);
            txtKids_Count.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(208, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "عدد التذاكر";
            // 
            // TicketDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 406);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
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