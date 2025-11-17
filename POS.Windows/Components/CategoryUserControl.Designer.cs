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
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCategory_Name);
            Controls.Add(CategoryPic);
            Name = "CategoryUserControl";
            Size = new Size(244, 95);
            ((System.ComponentModel.ISupportInitialize)CategoryPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CategoryPic;
        private Label lblCategory_Name;
    }
}
