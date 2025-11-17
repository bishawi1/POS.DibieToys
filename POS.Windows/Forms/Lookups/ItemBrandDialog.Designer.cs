namespace POS.Windows.Forms.Lookups
{
    partial class ItemBrandDialog
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
            roundedPanel1 = new POS.Windows.Components.RoundedPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            txtItem_Brand_Name = new TextBox();
            label2 = new Label();
            txtItem_Brand_ID = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Control;
            roundedPanel1.Controls.Add(textBox3);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(txtItem_Brand_Name);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(txtItem_Brand_ID);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(7, 11);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(409, 181);
            roundedPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(26, 95);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 67);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(332, 98);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "ملاحظات";
            // 
            // txtItem_Brand_Name
            // 
            txtItem_Brand_Name.ForeColor = Color.Black;
            txtItem_Brand_Name.Location = new Point(26, 57);
            txtItem_Brand_Name.Name = "txtItem_Brand_Name";
            txtItem_Brand_Name.Size = new Size(297, 23);
            txtItem_Brand_Name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(332, 60);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "الاسم";
            // 
            // txtItem_Brand_ID
            // 
            txtItem_Brand_ID.ForeColor = Color.Black;
            txtItem_Brand_ID.Location = new Point(241, 17);
            txtItem_Brand_ID.Name = "txtItem_Brand_ID";
            txtItem_Brand_ID.ReadOnly = true;
            txtItem_Brand_ID.Size = new Size(82, 23);
            txtItem_Brand_ID.TabIndex = 1;
            txtItem_Brand_ID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(332, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "الرقم";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(326, 211);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(33, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ItemBrandDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 246);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(roundedPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemBrandDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الشركة المصنعة";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.RoundedPanel roundedPanel1;
        private Button btnOK;
        private Button btnCancel;
        private TextBox txt;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtItem_Brand_Name;
        private TextBox txtItem_Brand_ID;
    }
}