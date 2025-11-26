namespace POS.Teller.Components
{
    partial class CategoryComponent
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
            pnlContentBase = new Panel();
            pnlContent = new FlowLayoutPanel();
            pnlContentBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentBase
            // 
            pnlContentBase.BackColor = Color.FromArgb(192, 192, 255);
            pnlContentBase.Controls.Add(pnlContent);
            pnlContentBase.Dock = DockStyle.Fill;
            pnlContentBase.ForeColor = Color.White;
            pnlContentBase.Location = new Point(0, 0);
            pnlContentBase.Margin = new Padding(3, 4, 3, 4);
            pnlContentBase.Name = "pnlContentBase";
            pnlContentBase.RightToLeft = RightToLeft.Yes;
            pnlContentBase.Size = new Size(150, 150);
            pnlContentBase.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(192, 192, 255);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(150, 150);
            pnlContent.TabIndex = 0;
            // 
            // CategoryComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(pnlContentBase);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryComponent";
            pnlContentBase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        //public POS.Windows.Components.RoundedPanel pnlContentBase;
        public Panel pnlContentBase;
        private FlowLayoutPanel pnlContent;
    }
}
