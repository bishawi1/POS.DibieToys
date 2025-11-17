namespace POS.Windows
{
    partial class MainForm1
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
            components = new System.ComponentModel.Container();
            btnCloseWindow = new Button();
            mainCategoryComponent = new POS.Windows.Components.CategoryComponent();
            cmbMainItemCategory = new ComboBox();
            subCategoryComponent = new POS.Windows.Components.CategoryComponent();
            categoryProductComponent1 = new POS.Windows.Components.CategoryProductComponent();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pnlQuickAccessButtons = new Panel();
            panel2 = new Panel();
            btnInvoiceList = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlInvoiceBase = new Panel();
            pnlInvoices = new Panel();
            pnlAddInvoice = new Panel();
            btnAddInvoice = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            pnlQuickAccessButtons.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlInvoiceBase.SuspendLayout();
            pnlAddInvoice.SuspendLayout();
            SuspendLayout();
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseWindow.Cursor = Cursors.Hand;
            btnCloseWindow.FlatAppearance.BorderSize = 0;
            btnCloseWindow.FlatStyle = FlatStyle.Flat;
            btnCloseWindow.Image = Properties.Resources.CloseWindow;
            btnCloseWindow.Location = new Point(1018, 5);
            btnCloseWindow.Margin = new Padding(3, 4, 3, 4);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(51, 45);
            btnCloseWindow.TabIndex = 0;
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // mainCategoryComponent
            // 
            mainCategoryComponent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainCategoryComponent.AutoScroll = true;
            mainCategoryComponent.BackColor = Color.FromArgb(192, 192, 255);
            mainCategoryComponent.Location = new Point(3, 4);
            mainCategoryComponent.Margin = new Padding(3, 4, 3, 4);
            mainCategoryComponent.Name = "mainCategoryComponent";
            mainCategoryComponent.Size = new Size(508, 60);
            mainCategoryComponent.TabIndex = 2;
            mainCategoryComponent.OnCategoryClick += mainCategoryComponent_OnCategoryClick;
            mainCategoryComponent.Load += mainCategoryComponent_Load;
            // 
            // cmbMainItemCategory
            // 
            cmbMainItemCategory.FormattingEnabled = true;
            cmbMainItemCategory.Location = new Point(512, 14);
            cmbMainItemCategory.Name = "cmbMainItemCategory";
            cmbMainItemCategory.Size = new Size(317, 28);
            cmbMainItemCategory.TabIndex = 3;
            cmbMainItemCategory.Visible = false;
            // 
            // subCategoryComponent
            // 
            subCategoryComponent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subCategoryComponent.AutoScroll = true;
            subCategoryComponent.BackColor = Color.FromArgb(192, 192, 255);
            subCategoryComponent.Location = new Point(3, 72);
            subCategoryComponent.Margin = new Padding(3, 4, 3, 4);
            subCategoryComponent.Name = "subCategoryComponent";
            subCategoryComponent.Size = new Size(511, 126);
            subCategoryComponent.TabIndex = 4;
            subCategoryComponent.OnCategoryClick += subCategoryComponent_OnCategoryClick;
            // 
            // categoryProductComponent1
            // 
            categoryProductComponent1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryProductComponent1.BackColor = Color.White;
            categoryProductComponent1.BorderStyle = BorderStyle.FixedSingle;
            categoryProductComponent1.Location = new Point(3, 206);
            categoryProductComponent1.Margin = new Padding(3, 4, 3, 4);
            categoryProductComponent1.Name = "categoryProductComponent1";
            categoryProductComponent1.RightToLeft = RightToLeft.Yes;
            categoryProductComponent1.Size = new Size(508, 247);
            categoryProductComponent1.TabIndex = 5;
            categoryProductComponent1.OnProductClick += categoryProductComponent1_OnProductClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCloseWindow);
            panel1.Controls.Add(cmbMainItemCategory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 57);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_minimize_50;
            button1.Location = new Point(961, 5);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(51, 45);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 35);
            label1.TabIndex = 4;
            label1.Text = "مكتبة الكمال";
            // 
            // pnlQuickAccessButtons
            // 
            pnlQuickAccessButtons.Controls.Add(panel2);
            pnlQuickAccessButtons.Controls.Add(mainCategoryComponent);
            pnlQuickAccessButtons.Controls.Add(subCategoryComponent);
            pnlQuickAccessButtons.Controls.Add(categoryProductComponent1);
            pnlQuickAccessButtons.Dock = DockStyle.Fill;
            pnlQuickAccessButtons.Location = new Point(543, 3);
            pnlQuickAccessButtons.Name = "pnlQuickAccessButtons";
            pnlQuickAccessButtons.Size = new Size(514, 531);
            pnlQuickAccessButtons.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnInvoiceList);
            panel2.Location = new Point(3, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 62);
            panel2.TabIndex = 6;
            // 
            // btnInvoiceList
            // 
            btnInvoiceList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInvoiceList.BackColor = Color.FromArgb(86, 45, 193);
            btnInvoiceList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInvoiceList.ForeColor = Color.White;
            btnInvoiceList.Image = Properties.Resources.icons8_invoice_50;
            btnInvoiceList.Location = new Point(311, -1);
            btnInvoiceList.Name = "btnInvoiceList";
            btnInvoiceList.Size = new Size(197, 63);
            btnInvoiceList.TabIndex = 7;
            btnInvoiceList.Text = "فواتير سابقة";
            btnInvoiceList.TextAlign = ContentAlignment.MiddleLeft;
            btnInvoiceList.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInvoiceList.UseVisualStyleBackColor = false;
            btnInvoiceList.Click += btnInvoiceList_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlQuickAccessButtons, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlInvoiceBase, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1060, 537);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlInvoiceBase
            // 
            pnlInvoiceBase.Controls.Add(pnlInvoices);
            pnlInvoiceBase.Controls.Add(pnlAddInvoice);
            pnlInvoiceBase.Controls.Add(flowLayoutPanel1);
            pnlInvoiceBase.Dock = DockStyle.Fill;
            pnlInvoiceBase.Location = new Point(3, 3);
            pnlInvoiceBase.Name = "pnlInvoiceBase";
            pnlInvoiceBase.Size = new Size(514, 531);
            pnlInvoiceBase.TabIndex = 8;
            // 
            // pnlInvoices
            // 
            pnlInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInvoices.Location = new Point(4, 61);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(507, 466);
            pnlInvoices.TabIndex = 2;
            // 
            // pnlAddInvoice
            // 
            pnlAddInvoice.Controls.Add(btnAddInvoice);
            pnlAddInvoice.Location = new Point(3, 3);
            pnlAddInvoice.Name = "pnlAddInvoice";
            pnlAddInvoice.Size = new Size(68, 53);
            pnlAddInvoice.TabIndex = 1;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddInvoice.Location = new Point(13, 3);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(46, 47);
            btnAddInvoice.TabIndex = 0;
            btnAddInvoice.Text = "+";
            btnAddInvoice.UseVisualStyleBackColor = true;
            btnAddInvoice.Click += btnAddInvoice_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(74, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(440, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1072, 600);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm1";
            Text = "Teller";
            WindowState = FormWindowState.Maximized;
            Activated += MainForm_Activated;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlQuickAccessButtons.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlInvoiceBase.ResumeLayout(false);
            pnlAddInvoice.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCloseWindow;
        private POS.Windows.Components.CategoryComponent mainCategoryComponent;
        private ComboBox cmbMainItemCategory;
        private POS.Windows.Components.CategoryComponent subCategoryComponent;
        private Components.CategoryProductComponent categoryProductComponent1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel pnlQuickAccessButtons;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel pnlInvoiceBase;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlAddInvoice;
        private Button btnAddInvoice;
        private Panel pnlInvoices;
        private Button button1;
        private Panel panel2;
        private Button btnInvoiceList;
    }
}
