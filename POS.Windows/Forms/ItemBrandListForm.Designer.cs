namespace POS.Windows.Forms
{
    partial class ItemBrandListForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBrandListForm));
            toolStrip1 = new ToolStrip();
            grdBrandList = new DataGridView();
            colItem_Brand_ID = new DataGridViewTextBoxColumn();
            colItem_Brand_Name = new DataGridViewTextBoxColumn();
            tsbtnNew = new ToolStripButton();
            btnGetData = new Button();
            label1 = new Label();
            txtBrand_Name = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdBrandList).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNew });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(459, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // grdBrandList
            // 
            grdBrandList.AllowUserToAddRows = false;
            grdBrandList.AllowUserToDeleteRows = false;
            grdBrandList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdBrandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdBrandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBrandList.Columns.AddRange(new DataGridViewColumn[] { colItem_Brand_ID, colItem_Brand_Name });
            grdBrandList.Location = new Point(12, 82);
            grdBrandList.Name = "grdBrandList";
            grdBrandList.ReadOnly = true;
            grdBrandList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBrandList.Size = new Size(435, 340);
            grdBrandList.TabIndex = 1;
            // 
            // colItem_Brand_ID
            // 
            colItem_Brand_ID.DataPropertyName = "Item_Brand_ID";
            colItem_Brand_ID.HeaderText = "";
            colItem_Brand_ID.Name = "colItem_Brand_ID";
            colItem_Brand_ID.ReadOnly = true;
            colItem_Brand_ID.Width = 40;
            // 
            // colItem_Brand_Name
            // 
            colItem_Brand_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem_Brand_Name.DataPropertyName = "Item_Brand_Name";
            colItem_Brand_Name.HeaderText = "الاسم";
            colItem_Brand_Name.Name = "colItem_Brand_Name";
            colItem_Brand_Name.ReadOnly = true;
            // 
            // tsbtnNew
            // 
            tsbtnNew.Image = (Image)resources.GetObject("tsbtnNew.Image");
            tsbtnNew.ImageTransparentColor = Color.Magenta;
            tsbtnNew.Name = "tsbtnNew";
            tsbtnNew.Size = new Size(66, 36);
            tsbtnNew.Text = "جديد";
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(106, 42);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(75, 23);
            btnGetData.TabIndex = 2;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 46);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "الاسم";
            // 
            // txtBrand_Name
            // 
            txtBrand_Name.Location = new Point(187, 43);
            txtBrand_Name.Name = "txtBrand_Name";
            txtBrand_Name.Size = new Size(206, 23);
            txtBrand_Name.TabIndex = 4;
            // 
            // ItemBrandListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(txtBrand_Name);
            Controls.Add(label1);
            Controls.Add(btnGetData);
            Controls.Add(grdBrandList);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Name = "ItemBrandListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الشركات المصنعة";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdBrandList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView grdBrandList;
        private DataGridViewTextBoxColumn colItem_Brand_ID;
        private DataGridViewTextBoxColumn colItem_Brand_Name;
        private ToolStripButton tsbtnNew;
        private Button btnGetData;
        private Label label1;
        private TextBox txtBrand_Name;
    }
}