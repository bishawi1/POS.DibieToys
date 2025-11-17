namespace POS.Windows.Forms.Books.LOVs
{
    partial class BookAuthorDialog
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
            btnOK = new Button();
            panel1 = new Panel();
            txtBook_Author_Notes = new TextBox();
            label3 = new Label();
            txtBook_Author_Desc = new TextBox();
            label2 = new Label();
            txtBook_Author_ID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(32, 284);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(367, 284);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 3;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBook_Author_Notes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBook_Author_Desc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBook_Author_ID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 241);
            panel1.TabIndex = 5;
            // 
            // txtBook_Author_Notes
            // 
            txtBook_Author_Notes.ForeColor = Color.Black;
            txtBook_Author_Notes.Location = new Point(21, 127);
            txtBook_Author_Notes.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_Notes.Multiline = true;
            txtBook_Author_Notes.Name = "txtBook_Author_Notes";
            txtBook_Author_Notes.Size = new Size(339, 88);
            txtBook_Author_Notes.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(370, 131);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 10;
            label3.Text = "ملاحظات";
            // 
            // txtBook_Author_Desc
            // 
            txtBook_Author_Desc.ForeColor = Color.Black;
            txtBook_Author_Desc.Location = new Point(21, 76);
            txtBook_Author_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_Desc.Name = "txtBook_Author_Desc";
            txtBook_Author_Desc.Size = new Size(339, 27);
            txtBook_Author_Desc.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(370, 80);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 8;
            label2.Text = "الاسم";
            // 
            // txtBook_Author_ID
            // 
            txtBook_Author_ID.ForeColor = Color.Black;
            txtBook_Author_ID.Location = new Point(266, 23);
            txtBook_Author_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_ID.Name = "txtBook_Author_ID";
            txtBook_Author_ID.ReadOnly = true;
            txtBook_Author_ID.Size = new Size(93, 27);
            txtBook_Author_ID.TabIndex = 7;
            txtBook_Author_ID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(370, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "الرقم";
            // 
            // BookAuthorDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 328);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookAuthorDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المؤلف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private Panel panel1;
        private TextBox txtBook_Author_Notes;
        private Label label3;
        private TextBox txtBook_Author_Desc;
        private Label label2;
        private TextBox txtBook_Author_ID;
        private Label label1;
    }
}