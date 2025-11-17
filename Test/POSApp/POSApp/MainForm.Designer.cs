namespace POSApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlBasic = new TableLayoutPanel();
            tlContent = new TableLayoutPanel();
            pnlTitle = new Panel();
            label1 = new Label();
            tlRightSide = new TableLayoutPanel();
            tlLeftSide = new TableLayoutPanel();
            pnlCategory = new FlowLayoutPanel();
            pnlCategoryProducts = new FlowLayoutPanel();
            tlLeftSideContents = new TableLayoutPanel();
            grdSoldItems = new DataGridView();
            colInvoice_Detail_ID = new DataGridViewTextBoxColumn();
            colInvoice_ID = new DataGridViewTextBoxColumn();
            colProduct_ID = new DataGridViewTextBoxColumn();
            colProduct_Name = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQnt = new DataGridViewTextBoxColumn();
            pnlTransactionHeader = new Panel();
            lblDay_Name = new Label();
            dtToday = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            button1 = new Button();
            tlBasic.SuspendLayout();
            tlContent.SuspendLayout();
            pnlTitle.SuspendLayout();
            tlRightSide.SuspendLayout();
            tlLeftSide.SuspendLayout();
            tlLeftSideContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSoldItems).BeginInit();
            pnlTransactionHeader.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlBasic
            // 
            tlBasic.ColumnCount = 2;
            tlBasic.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlBasic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlBasic.Controls.Add(tlContent, 1, 0);
            tlBasic.Controls.Add(toolStrip1, 0, 0);
            tlBasic.Dock = DockStyle.Fill;
            tlBasic.Location = new Point(0, 0);
            tlBasic.Name = "tlBasic";
            tlBasic.RowCount = 1;
            tlBasic.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlBasic.Size = new Size(800, 450);
            tlBasic.TabIndex = 0;
            tlBasic.Paint += tlBasic_Paint;
            // 
            // tlContent
            // 
            tlContent.ColumnCount = 1;
            tlContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlContent.Controls.Add(pnlTitle, 0, 0);
            tlContent.Controls.Add(tlRightSide, 0, 1);
            tlContent.Dock = DockStyle.Fill;
            tlContent.Location = new Point(3, 3);
            tlContent.Name = "tlContent";
            tlContent.RowCount = 2;
            tlContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlContent.Size = new Size(754, 444);
            tlContent.TabIndex = 2;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(255, 224, 192);
            pnlTitle.Controls.Add(label1);
            pnlTitle.Location = new Point(74, 3);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(677, 34);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(634, 31);
            label1.TabIndex = 0;
            label1.Text = "Bookshop POS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlRightSide
            // 
            tlRightSide.ColumnCount = 2;
            tlRightSide.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlRightSide.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tlRightSide.Controls.Add(tlLeftSide, 0, 0);
            tlRightSide.Controls.Add(tlLeftSideContents, 1, 0);
            tlRightSide.Dock = DockStyle.Fill;
            tlRightSide.Location = new Point(3, 43);
            tlRightSide.Name = "tlRightSide";
            tlRightSide.RowCount = 1;
            tlRightSide.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlRightSide.Size = new Size(748, 398);
            tlRightSide.TabIndex = 1;
            // 
            // tlLeftSide
            // 
            tlLeftSide.ColumnCount = 1;
            tlLeftSide.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlLeftSide.Controls.Add(pnlCategory, 0, 0);
            tlLeftSide.Controls.Add(pnlCategoryProducts, 0, 1);
            tlLeftSide.Dock = DockStyle.Fill;
            tlLeftSide.Location = new Point(403, 3);
            tlLeftSide.Name = "tlLeftSide";
            tlLeftSide.RowCount = 3;
            tlLeftSide.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlLeftSide.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlLeftSide.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlLeftSide.Size = new Size(342, 392);
            tlLeftSide.TabIndex = 0;
            // 
            // pnlCategory
            // 
            pnlCategory.Dock = DockStyle.Fill;
            pnlCategory.Location = new Point(3, 3);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(336, 54);
            pnlCategory.TabIndex = 0;
            // 
            // pnlCategoryProducts
            // 
            pnlCategoryProducts.Dock = DockStyle.Fill;
            pnlCategoryProducts.Location = new Point(3, 63);
            pnlCategoryProducts.Name = "pnlCategoryProducts";
            pnlCategoryProducts.Size = new Size(336, 226);
            pnlCategoryProducts.TabIndex = 1;
            // 
            // tlLeftSideContents
            // 
            tlLeftSideContents.ColumnCount = 1;
            tlLeftSideContents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlLeftSideContents.Controls.Add(grdSoldItems, 0, 1);
            tlLeftSideContents.Controls.Add(pnlTransactionHeader, 0, 0);
            tlLeftSideContents.Dock = DockStyle.Fill;
            tlLeftSideContents.Location = new Point(3, 3);
            tlLeftSideContents.Name = "tlLeftSideContents";
            tlLeftSideContents.RowCount = 3;
            tlLeftSideContents.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlLeftSideContents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlLeftSideContents.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlLeftSideContents.Size = new Size(394, 392);
            tlLeftSideContents.TabIndex = 1;
            tlLeftSideContents.Paint += tableLayoutPanel1_Paint;
            // 
            // grdSoldItems
            // 
            grdSoldItems.AllowUserToAddRows = false;
            grdSoldItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdSoldItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSoldItems.Columns.AddRange(new DataGridViewColumn[] { colInvoice_Detail_ID, colInvoice_ID, colProduct_ID, colProduct_Name, colPrice, colQnt });
            grdSoldItems.Location = new Point(16, 43);
            grdSoldItems.Name = "grdSoldItems";
            grdSoldItems.ReadOnly = true;
            grdSoldItems.Size = new Size(375, 181);
            grdSoldItems.TabIndex = 0;
            // 
            // colInvoice_Detail_ID
            // 
            colInvoice_Detail_ID.HeaderText = "Invoice_Detail_ID";
            colInvoice_Detail_ID.Name = "colInvoice_Detail_ID";
            colInvoice_Detail_ID.ReadOnly = true;
            colInvoice_Detail_ID.Visible = false;
            // 
            // colInvoice_ID
            // 
            colInvoice_ID.DataPropertyName = "Invoice_ID";
            colInvoice_ID.HeaderText = "Invoice_ID";
            colInvoice_ID.Name = "colInvoice_ID";
            colInvoice_ID.ReadOnly = true;
            colInvoice_ID.Visible = false;
            // 
            // colProduct_ID
            // 
            colProduct_ID.DataPropertyName = "Product_ID";
            colProduct_ID.HeaderText = "Product_ID";
            colProduct_ID.Name = "colProduct_ID";
            colProduct_ID.ReadOnly = true;
            colProduct_ID.Visible = false;
            // 
            // colProduct_Name
            // 
            colProduct_Name.DataPropertyName = "Product_Name";
            colProduct_Name.HeaderText = "الصنف";
            colProduct_Name.Name = "colProduct_Name";
            colProduct_Name.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 50;
            // 
            // colQnt
            // 
            colQnt.DataPropertyName = "Qnt";
            colQnt.HeaderText = "Qnt";
            colQnt.Name = "colQnt";
            colQnt.ReadOnly = true;
            colQnt.Width = 50;
            // 
            // pnlTransactionHeader
            // 
            pnlTransactionHeader.Controls.Add(button1);
            pnlTransactionHeader.Controls.Add(lblDay_Name);
            pnlTransactionHeader.Controls.Add(dtToday);
            pnlTransactionHeader.Location = new Point(3, 3);
            pnlTransactionHeader.Name = "pnlTransactionHeader";
            pnlTransactionHeader.Size = new Size(388, 33);
            pnlTransactionHeader.TabIndex = 1;
            // 
            // lblDay_Name
            // 
            lblDay_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDay_Name.Location = new Point(174, 3);
            lblDay_Name.Name = "lblDay_Name";
            lblDay_Name.Size = new Size(100, 22);
            lblDay_Name.TabIndex = 3;
            lblDay_Name.Text = "Day Name";
            lblDay_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtToday
            // 
            dtToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtToday.CustomFormat = "dd/MM/yyyy";
            dtToday.Enabled = false;
            dtToday.Format = DateTimePickerFormat.Custom;
            dtToday.Location = new Point(280, 3);
            dtToday.Name = "dtToday";
            dtToday.Size = new Size(105, 23);
            dtToday.TabIndex = 2;
            dtToday.ValueChanged += dtToday_ValueChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(760, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(37, 450);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 36);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // button1
            // 
            button1.Location = new Point(56, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlBasic);
            KeyPreview = true;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tlBasic.ResumeLayout(false);
            tlBasic.PerformLayout();
            tlContent.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            tlRightSide.ResumeLayout(false);
            tlLeftSide.ResumeLayout(false);
            tlLeftSideContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSoldItems).EndInit();
            pnlTransactionHeader.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlBasic;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private TableLayoutPanel tlContent;
        private Panel pnlTitle;
        private Label label1;
        private TableLayoutPanel tlContentLayout;
        private TableLayoutPanel tlLeftSide;
        private TableLayoutPanel tlLeftSideContents;
        private DataGridView grdSoldItems;
        private FlowLayoutPanel pnlCategory;
        private FlowLayoutPanel pnlCategoryProducts;
        private Panel pnlTransactionHeader;
        private DateTimePicker dtToday;
        private Label lblDay_Name;
        private TableLayoutPanel tlRightSide;
        private DataGridViewTextBoxColumn colInvoice_Detail_ID;
        private DataGridViewTextBoxColumn colInvoice_ID;
        private DataGridViewTextBoxColumn colProduct_ID;
        private DataGridViewTextBoxColumn colProduct_Name;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQnt;
        private Button button1;
    }
}
