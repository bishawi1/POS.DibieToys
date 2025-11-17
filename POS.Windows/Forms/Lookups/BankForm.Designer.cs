namespace POS.Windows.Lookups
{
    partial class BankForm
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
            btnCancel = new Button();
            btnOk = new Button();
            txtBank_No = new MaskedTextBox();
            label4 = new Label();
            txtBank_Notes = new TextBox();
            txtBank_Name = new TextBox();
            txtBank_ID = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(55, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(303, 253);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 7;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtBank_No
            // 
            txtBank_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_No.Location = new Point(274, 50);
            txtBank_No.Mask = "00000";
            txtBank_No.Name = "txtBank_No";
            txtBank_No.Size = new Size(39, 23);
            txtBank_No.TabIndex = 31;
            txtBank_No.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtBank_No.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 50);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 30;
            label4.Text = "كود البنك";
            // 
            // txtBank_Notes
            // 
            txtBank_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_Notes.Location = new Point(24, 117);
            txtBank_Notes.Multiline = true;
            txtBank_Notes.Name = "txtBank_Notes";
            txtBank_Notes.Size = new Size(287, 103);
            txtBank_Notes.TabIndex = 29;
            // 
            // txtBank_Name
            // 
            txtBank_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_Name.Location = new Point(26, 80);
            txtBank_Name.Name = "txtBank_Name";
            txtBank_Name.Size = new Size(287, 23);
            txtBank_Name.TabIndex = 27;
            // 
            // txtBank_ID
            // 
            txtBank_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBank_ID.Location = new Point(274, 20);
            txtBank_ID.Mask = "00000";
            txtBank_ID.Name = "txtBank_ID";
            txtBank_ID.ReadOnly = true;
            txtBank_ID.Size = new Size(39, 23);
            txtBank_ID.TabIndex = 25;
            txtBank_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtBank_ID.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 28;
            label3.Text = "ملاحظات";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 80);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 26;
            label2.Text = "الاسم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 24;
            label1.Text = "الرمز";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBank_No);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBank_Notes);
            panel1.Controls.Add(txtBank_Name);
            panel1.Controls.Add(txtBank_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 235);
            panel1.TabIndex = 36;
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 288);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BankForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "البنوك";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private MaskedTextBox txtBank_No;
        private Label label4;
        private TextBox txtBank_Notes;
        private TextBox txtBank_Name;
        private MaskedTextBox txtBank_ID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}