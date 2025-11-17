namespace POS.Windows.Components
{
    partial class CategoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CategoryPic = new PictureBox();
            lblCategory_Name = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryPic).BeginInit();
            SuspendLayout();
            // 
            // CategoryPic
            // 
            CategoryPic.Location = new Point(0, 0);
            CategoryPic.Margin = new Padding(3, 4, 3, 4);
            CategoryPic.Name = "CategoryPic";
            CategoryPic.Size = new Size(114, 67);
            CategoryPic.TabIndex = 1;
            CategoryPic.TabStop = false;
            // 
            // lblCategory_Name
            // 
            lblCategory_Name.Location = new Point(0, 0);
            lblCategory_Name.Name = "lblCategory_Name";
            lblCategory_Name.Size = new Size(114, 31);
            lblCategory_Name.TabIndex = 0;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCategory_Name);
            Controls.Add(CategoryPic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryUserControl";
            Size = new Size(279, 69);
            ((System.ComponentModel.ISupportInitialize)CategoryPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CategoryPic;
        private Label lblCategory_Name;
    }
}
