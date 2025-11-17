namespace POS.Windows.Forms.Books.Lookups
{
    partial class PublisherDialog
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
            panel1 = new Panel();
            txtPublisher_Notes = new TextBox();
            txtPublisher_Desc = new TextBox();
            txtPublisher_ID = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPublisher_Notes);
            panel1.Controls.Add(txtPublisher_Desc);
            panel1.Controls.Add(txtPublisher_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 258);
            panel1.TabIndex = 0;
            // 
            // txtPublisher_Notes
            // 
            txtPublisher_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPublisher_Notes.Location = new Point(29, 104);
            txtPublisher_Notes.Margin = new Padding(3, 4, 3, 4);
            txtPublisher_Notes.Multiline = true;
            txtPublisher_Notes.Name = "txtPublisher_Notes";
            txtPublisher_Notes.Size = new Size(327, 136);
            txtPublisher_Notes.TabIndex = 37;
            // 
            // txtPublisher_Desc
            // 
            txtPublisher_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPublisher_Desc.Location = new Point(32, 55);
            txtPublisher_Desc.Margin = new Padding(3, 4, 3, 4);
            txtPublisher_Desc.Name = "txtPublisher_Desc";
            txtPublisher_Desc.Size = new Size(327, 27);
            txtPublisher_Desc.TabIndex = 35;
            // 
            // txtPublisher_ID
            // 
            txtPublisher_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPublisher_ID.Location = new Point(312, 10);
            txtPublisher_ID.Margin = new Padding(3, 4, 3, 4);
            txtPublisher_ID.Mask = "00000";
            txtPublisher_ID.Name = "txtPublisher_ID";
            txtPublisher_ID.ReadOnly = true;
            txtPublisher_ID.Size = new Size(44, 27);
            txtPublisher_ID.TabIndex = 33;
            txtPublisher_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPublisher_ID.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 108);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 36;
            label3.Text = "ملاحظات";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 34;
            label2.Text = "الاسم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 32;
            label1.Text = "الرمز";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(66, 283);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(349, 283);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 31);
            btnOk.TabIndex = 9;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // PublisherDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 330);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PublisherDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الناشر";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtPublisher_Notes;
        private TextBox txtPublisher_Desc;
        private MaskedTextBox txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtPublisher_ID;
    }
}