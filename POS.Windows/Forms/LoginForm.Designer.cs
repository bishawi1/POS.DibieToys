namespace RealEstateRentalApp
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            chkChangePassword = new CheckBox();
            txtPassword = new TextBox();
            txtUser_Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.Location = new Point(253, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "تسجيل دخول";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(41, 174);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkChangePassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser_Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 154);
            panel1.TabIndex = 0;
            // 
            // chkChangePassword
            // 
            chkChangePassword.AutoSize = true;
            chkChangePassword.Location = new Point(109, 109);
            chkChangePassword.Name = "chkChangePassword";
            chkChangePassword.Size = new Size(108, 19);
            chkChangePassword.TabIndex = 4;
            chkChangePassword.TabStop = false;
            chkChangePassword.Text = "تغيير كلمة المرور";
            chkChangePassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPassword.Location = new Point(49, 65);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUser_Name
            // 
            txtUser_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUser_Name.Location = new Point(49, 22);
            txtUser_Name.Name = "txtUser_Name";
            txtUser_Name.Size = new Size(168, 23);
            txtUser_Name.TabIndex = 1;
            txtUser_Name.TabStop = false;
            txtUser_Name.Text = "admin";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(223, 65);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(223, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "اسم المستخدم";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 209);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل دخول";
            KeyDown += LoginForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUser_Name;
        private Label label2;
        private Label label1;
        private CheckBox chkChangePassword;
    }
}