namespace POSApp
{
    partial class SoldItemControl
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
            picItem = new PictureBox();
            lblItemName = new Label();
            lblItemPrice = new Label();
            btnRemoveItem = new Button();
            lblQnt = new Label();
            btnDecrease = new Button();
            btnIncrease = new Button();
            ((System.ComponentModel.ISupportInitialize)picItem).BeginInit();
            SuspendLayout();
            // 
            // picItem
            // 
            picItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picItem.Location = new Point(172, 0);
            picItem.Name = "picItem";
            picItem.Size = new Size(53, 52);
            picItem.TabIndex = 0;
            picItem.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblItemName.Location = new Point(1, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(165, 24);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "label1";
            lblItemName.TextAlign = ContentAlignment.MiddleRight;
            lblItemName.Click += lblItemName_Click;
            // 
            // lblItemPrice
            // 
            lblItemPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblItemPrice.Location = new Point(1, 28);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(165, 24);
            lblItemPrice.TabIndex = 2;
            lblItemPrice.Text = "label1";
            lblItemPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveItem.Location = new Point(226, 1);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(21, 23);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Text = "X";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // lblQnt
            // 
            lblQnt.BackColor = Color.FromArgb(255, 255, 192);
            lblQnt.Location = new Point(44, 56);
            lblQnt.Name = "lblQnt";
            lblQnt.Size = new Size(56, 24);
            lblQnt.TabIndex = 4;
            lblQnt.Text = "0";
            lblQnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(17, 56);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(21, 23);
            btnDecrease.TabIndex = 5;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(106, 56);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(21, 23);
            btnIncrease.TabIndex = 6;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            // 
            // SoldItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Controls.Add(lblQnt);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemName);
            Controls.Add(picItem);
            Name = "SoldItemControl";
            Size = new Size(250, 84);
            ((System.ComponentModel.ISupportInitialize)picItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picItem;
        private Label lblItemName;
        private Label lblItemPrice;
        private Button btnRemoveItem;
        private Label lblQnt;
        private Button btnDecrease;
        private Button btnIncrease;
    }
}
