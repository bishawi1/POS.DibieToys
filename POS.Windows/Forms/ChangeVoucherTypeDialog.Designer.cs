namespace Bookshop.TestClient
{
    partial class ChangeVoucherTypeDialog
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
            btnOK = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            label3 = new Label();
            cmbVoucherType = new ComboBox();
            lblCurrentVoucherType = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(218, 152);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(39, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbVoucherType);
            panel1.Controls.Add(lblCurrentVoucherType);
            panel1.Location = new Point(8, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 135);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(227, 75);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "تحويل الى";
            // 
            // cmbVoucherType
            // 
            cmbVoucherType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVoucherType.FormattingEnabled = true;
            cmbVoucherType.Items.AddRange(new object[] { "قبض", "صرف", "فاتورة مبيعات", "فاتورة مشتريات" });
            cmbVoucherType.Location = new Point(23, 72);
            cmbVoucherType.Name = "cmbVoucherType";
            cmbVoucherType.Size = new Size(198, 23);
            cmbVoucherType.TabIndex = 15;
            // 
            // lblCurrentVoucherType
            // 
            lblCurrentVoucherType.Location = new Point(19, 16);
            lblCurrentVoucherType.Name = "lblCurrentVoucherType";
            lblCurrentVoucherType.Size = new Size(265, 23);
            lblCurrentVoucherType.TabIndex = 0;
            lblCurrentVoucherType.Text = "label1";
            lblCurrentVoucherType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangeVoucherTypeDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 187);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeVoucherTypeDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تغيير نوع الحركة المالية";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Panel panel1;
        private Label lblCurrentVoucherType;
        private Label label3;
        private ComboBox cmbVoucherType;
    }
}