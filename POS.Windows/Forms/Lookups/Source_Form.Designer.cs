namespace POS.Windows.Lookups
{
    partial class Source_Form
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
            txtBook_Source_Notes = new TextBox();
            txtBook_Source_Desc = new TextBox();
            txtBook_Source_ID = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(52, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(300, 211);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 5;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtBook_Source_Notes
            // 
            txtBook_Source_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Source_Notes.Location = new Point(37, 94);
            txtBook_Source_Notes.Multiline = true;
            txtBook_Source_Notes.Name = "txtBook_Source_Notes";
            txtBook_Source_Notes.Size = new Size(287, 69);
            txtBook_Source_Notes.TabIndex = 17;
            // 
            // txtBook_Source_Desc
            // 
            txtBook_Source_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Source_Desc.Location = new Point(37, 54);
            txtBook_Source_Desc.Name = "txtBook_Source_Desc";
            txtBook_Source_Desc.Size = new Size(287, 23);
            txtBook_Source_Desc.TabIndex = 15;
            // 
            // txtBook_Source_ID
            // 
            txtBook_Source_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Source_ID.Location = new Point(285, 13);
            txtBook_Source_ID.Mask = "00000";
            txtBook_Source_ID.Name = "txtBook_Source_ID";
            txtBook_Source_ID.ReadOnly = true;
            txtBook_Source_ID.Size = new Size(39, 23);
            txtBook_Source_ID.TabIndex = 13;
            txtBook_Source_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtBook_Source_ID.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 102);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "ملاحظات";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 57);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 14;
            label2.Text = "الاسم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 16);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 12;
            label1.Text = "الرمز";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBook_Source_Notes);
            panel1.Controls.Add(txtBook_Source_Desc);
            panel1.Controls.Add(txtBook_Source_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 182);
            panel1.TabIndex = 18;
            // 
            // Source_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 246);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Source_Form";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مصادر الكتب";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private TextBox txtBook_Source_Notes;
        private TextBox txtBook_Source_Desc;
        private MaskedTextBox txtBook_Source_ID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}