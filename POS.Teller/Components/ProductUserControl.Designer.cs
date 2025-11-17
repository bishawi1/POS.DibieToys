namespace POS.Windows.Components
{
    partial class ProductUserControl
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
            lblItem_Name = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblItem_Name
            // 
            lblItem_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblItem_Name.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblItem_Name.Location = new Point(7, 9);
            lblItem_Name.Name = "lblItem_Name";
            lblItem_Name.Size = new Size(116, 31);
            lblItem_Name.TabIndex = 3;
            lblItem_Name.Text = "Item Name";
            lblItem_Name.Click += lblItem_Name_Click;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPrice.Location = new Point(7, 42);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(116, 31);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Item Price";
            lblPrice.Click += lblPrice_Click;
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblItem_Name);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductUserControl";
            Size = new Size(126, 79);
            Click += ProductUserControl_Click;
            ResumeLayout(false);
        }

        #endregion
        private Label lblItem_Name;
        private Label lblPrice;
    }
}
