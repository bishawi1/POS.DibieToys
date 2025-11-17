namespace POSApp
{
    partial class TestForm
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
            categoryComponent1 = new POSApp.Components.CategoryComponent();
            SuspendLayout();
            // 
            // categoryComponent1
            // 
            categoryComponent1.BackColor = Color.FromArgb(255, 192, 192);
            categoryComponent1.Location = new Point(255, 32);
            categoryComponent1.Name = "categoryComponent1";
            categoryComponent1.Size = new Size(401, 77);
            categoryComponent1.TabIndex = 0;
            categoryComponent1.OnCategoryClick += categoryComponent1_OnCategoryClick;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(categoryComponent1);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.CategoryComponent categoryComponent1;
    }
}