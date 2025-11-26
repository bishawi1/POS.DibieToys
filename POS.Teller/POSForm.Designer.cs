namespace POS.Teller
{
    partial class POSForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            toolStrip1 = new ToolStrip();
            tsbtnSave = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tsbtnRemoveInvoice = new ToolStripButton();
            tsbtnPrevInvoices = new ToolStripButton();
            subCategoryComponent = new POS.Teller.Components.CategoryComponent();
            timer1 = new System.Windows.Forms.Timer(components);
            categoryProductComponent1 = new POS.Teller.Components.CategoryProductComponent();
            pnlInvoices = new Panel();
            panel1 = new Panel();
            pnlPayWayLIst = new Panel();
            grdPayWays = new DataGridView();
            colPayWayId = new DataGridViewTextBoxColumn();
            colPayWayDesc = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pnlPayWayLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPayWays).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnSave, toolStripButton1, tsbtnRemoveInvoice, tsbtnPrevInvoices });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(873, 55);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            tsbtnSave.Image = (Image)resources.GetObject("tsbtnSave.Image");
            tsbtnSave.ImageTransparentColor = Color.Magenta;
            tsbtnSave.Name = "tsbtnSave";
            tsbtnSave.Size = new Size(82, 52);
            tsbtnSave.Text = "حفظ";
            tsbtnSave.Click += tsbtnSave_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(148, 52);
            toolStripButton1.Text = "حفظ  دو ن طلباعة";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbtnRemoveInvoice
            // 
            tsbtnRemoveInvoice.Image = (Image)resources.GetObject("tsbtnRemoveInvoice.Image");
            tsbtnRemoveInvoice.ImageTransparentColor = Color.Magenta;
            tsbtnRemoveInvoice.Name = "tsbtnRemoveInvoice";
            tsbtnRemoveInvoice.Size = new Size(81, 52);
            tsbtnRemoveInvoice.Text = "الغاء";
            tsbtnRemoveInvoice.Click += tsbtnRemoveInvoice_Click;
            // 
            // tsbtnPrevInvoices
            // 
            tsbtnPrevInvoices.Image = (Image)resources.GetObject("tsbtnPrevInvoices.Image");
            tsbtnPrevInvoices.ImageTransparentColor = Color.Magenta;
            tsbtnPrevInvoices.Name = "tsbtnPrevInvoices";
            tsbtnPrevInvoices.Size = new Size(119, 52);
            tsbtnPrevInvoices.Text = "فواتير سابقة";
            tsbtnPrevInvoices.Click += tsbtnPrevInvoices_Click;
            // 
            // subCategoryComponent
            // 
            subCategoryComponent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subCategoryComponent.AutoScroll = true;
            subCategoryComponent.BackColor = Color.FromArgb(192, 192, 255);
            subCategoryComponent.BorderStyle = BorderStyle.FixedSingle;
            subCategoryComponent.Location = new Point(3, 3);
            subCategoryComponent.Name = "subCategoryComponent";
            subCategoryComponent.Size = new Size(236, 95);
            subCategoryComponent.TabIndex = 5;
            subCategoryComponent.OnCategoryClick += subCategoryComponent_OnCategoryClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // categoryProductComponent1
            // 
            categoryProductComponent1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryProductComponent1.BackColor = Color.FromArgb(192, 192, 255);
            categoryProductComponent1.BorderStyle = BorderStyle.FixedSingle;
            categoryProductComponent1.Location = new Point(3, 104);
            categoryProductComponent1.Name = "categoryProductComponent1";
            categoryProductComponent1.RightToLeft = RightToLeft.Yes;
            categoryProductComponent1.Size = new Size(236, 109);
            categoryProductComponent1.TabIndex = 6;
            categoryProductComponent1.OnProductClick += categoryProductComponent1_OnProductClick;
            // 
            // pnlInvoices
            // 
            pnlInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInvoices.Location = new Point(3, 2);
            pnlInvoices.Margin = new Padding(3, 2, 3, 2);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(589, 348);
            pnlInvoices.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pnlPayWayLIst);
            panel1.Controls.Add(categoryProductComponent1);
            panel1.Controls.Add(subCategoryComponent);
            panel1.Location = new Point(598, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 348);
            panel1.TabIndex = 9;
            // 
            // pnlPayWayLIst
            // 
            pnlPayWayLIst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPayWayLIst.BorderStyle = BorderStyle.FixedSingle;
            pnlPayWayLIst.Controls.Add(grdPayWays);
            pnlPayWayLIst.Location = new Point(3, 219);
            pnlPayWayLIst.Name = "pnlPayWayLIst";
            pnlPayWayLIst.Size = new Size(236, 118);
            pnlPayWayLIst.TabIndex = 7;
            // 
            // grdPayWays
            // 
            grdPayWays.AllowUserToAddRows = false;
            grdPayWays.AllowUserToDeleteRows = false;
            grdPayWays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPayWays.Columns.AddRange(new DataGridViewColumn[] { colPayWayId, colPayWayDesc, colAmount });
            grdPayWays.Dock = DockStyle.Fill;
            grdPayWays.Location = new Point(0, 0);
            grdPayWays.Name = "grdPayWays";
            grdPayWays.ReadOnly = true;
            grdPayWays.Size = new Size(234, 116);
            grdPayWays.TabIndex = 0;
            // 
            // colPayWayId
            // 
            colPayWayId.DataPropertyName = "PayWayId";
            colPayWayId.HeaderText = "PayWayId";
            colPayWayId.Name = "colPayWayId";
            colPayWayId.ReadOnly = true;
            colPayWayId.Visible = false;
            // 
            // colPayWayDesc
            // 
            colPayWayDesc.DataPropertyName = "PayWayDesc";
            colPayWayDesc.HeaderText = "طريقة الدفع";
            colPayWayDesc.Name = "colPayWayDesc";
            colPayWayDesc.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            colAmount.HeaderText = "المبلغ";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlInvoices, 1, 0);
            tableLayoutPanel1.Location = new Point(14, 53);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(849, 352);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 415);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "POSForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المبيعات";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            pnlPayWayLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdPayWays).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnSave;
        private Components.CategoryComponent subCategoryComponent;
        private System.Windows.Forms.Timer timer1;
        private Components.CategoryProductComponent categoryProductComponent1;
        private Panel pnlInvoices;
        private Panel panel1;
        private Label label1;
        private TextBox txtVoucher_Discount_Amount;
        private PictureBox btnShow_Calculator;
        private ToolStripButton toolStripButton1;
        private ToolStripButton tsbtnRemoveInvoice;
        private ToolStripButton tsbtnPrevInvoices;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPayWayLIst;
        private DataGridView grdPayWays;
        private DataGridViewTextBoxColumn colPayWayId;
        private DataGridViewTextBoxColumn colPayWayDesc;
        private DataGridViewTextBoxColumn colAmount;
    }
}