namespace POS.Teller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            chkChangePassword = new CheckBox();
            btnPasswordNumericCalc = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            chkRememberMe = new CheckBox();
            txtUserName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnPasswordNumericCalc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(550, 157);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(550, 202);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "كلمة المرور";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(330, 202);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(215, 32);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "123456";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.None;
            btnOK.Font = new Font("Segoe UI", 12F);
            btnOK.Location = new Point(506, 323);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(126, 38);
            btnOK.TabIndex = 5;
            btnOK.Text = "تسجيل دخول";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(313, 323);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkChangePassword
            // 
            chkChangePassword.Anchor = AnchorStyles.None;
            chkChangePassword.AutoSize = true;
            chkChangePassword.Font = new Font("Segoe UI", 12F);
            chkChangePassword.Location = new Point(408, 270);
            chkChangePassword.Margin = new Padding(3, 2, 3, 2);
            chkChangePassword.Name = "chkChangePassword";
            chkChangePassword.Size = new Size(137, 25);
            chkChangePassword.TabIndex = 7;
            chkChangePassword.Text = "تغيير كلمة المرور";
            chkChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnPasswordNumericCalc
            // 
            btnPasswordNumericCalc.Anchor = AnchorStyles.None;
            btnPasswordNumericCalc.Image = (Image)resources.GetObject("btnPasswordNumericCalc.Image");
            btnPasswordNumericCalc.Location = new Point(281, 202);
            btnPasswordNumericCalc.Margin = new Padding(3, 2, 3, 2);
            btnPasswordNumericCalc.Name = "btnPasswordNumericCalc";
            btnPasswordNumericCalc.Size = new Size(44, 38);
            btnPasswordNumericCalc.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPasswordNumericCalc.TabIndex = 15;
            btnPasswordNumericCalc.TabStop = false;
            btnPasswordNumericCalc.Click += btnPasswordNumericCalc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(446, 57);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 19;
            label4.Text = "Dibie Toys";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(446, 18);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 18;
            label3.Text = "دبعي تويز";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(562, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Anchor = AnchorStyles.None;
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Segoe UI", 12F);
            chkRememberMe.Location = new Point(471, 238);
            chkRememberMe.Margin = new Padding(3, 2, 3, 2);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(74, 25);
            chkRememberMe.TabIndex = 21;
            chkRememberMe.Text = "تذكرني";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Segoe UI", 14F);
            txtUserName.Location = new Point(330, 157);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(215, 32);
            txtUserName.TabIndex = 22;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(677, 383);
            Controls.Add(txtUserName);
            Controls.Add(chkRememberMe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnPasswordNumericCalc);
            Controls.Add(chkChangePassword);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل دخول";
            ((System.ComponentModel.ISupportInitialize)btnPasswordNumericCalc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Button btnOK;
        private Button btnCancel;
        private CheckBox chkChangePassword;
        private PictureBox btnPasswordNumericCalc;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox chkRememberMe;
        private TextBox txtUserName;
    }
}