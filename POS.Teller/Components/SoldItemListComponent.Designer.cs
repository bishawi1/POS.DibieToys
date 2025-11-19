namespace POS.Windows.Components
{
    partial class SoldItemListComponent
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldItemListComponent));
            grdItemList = new DataGridView();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_Item_ID = new DataGridViewTextBoxColumn();
            colItem_ID = new DataGridViewTextBoxColumn();
            colItem_Desc = new DataGridViewTextBoxColumn();
            colItem_Group_ID = new DataGridViewTextBoxColumn();
            colUnit_ID = new DataGridViewTextBoxColumn();
            colUnit_Desc = new DataGridViewTextBoxColumn();
            colItem_Unit_Price = new DataGridViewTextBoxColumn();
            colItem_Unit_Cost = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colQnt = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colUndo = new DataGridViewImageColumn();
            panel1 = new Panel();
            lblDiscountPercent = new Label();
            btnDiscountPercent = new PictureBox();
            label5 = new Label();
            btnPayWay = new Button();
            lblNetAmount = new Label();
            lblTotalAmount = new Label();
            lblDiscount = new Label();
            lblItemCount = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnPrintInvoice = new Button();
            txtBarcode = new TextBox();
            btnSearch = new Button();
            imageList1 = new ImageList(components);
            btnSave = new Button();
            panel2 = new Panel();
            btnSaveWithoutPrint = new Button();
            btnCancel = new Button();
            cmnuPayWay = new ContextMenuStrip(components);
            mnuCash = new ToolStripMenuItem();
            mnuDebits = new ToolStripMenuItem();
            mnuCheques = new ToolStripMenuItem();
            mnuMoneyTransfere = new ToolStripMenuItem();
            mnuCreditCard = new ToolStripMenuItem();
            mnuOnlineSales = new ToolStripMenuItem();
            btnBarcodeNumericCalc = new PictureBox();
            btnAdvancedSearch = new Button();
            btnAdjust_Item_QNT = new Button();
            btnAdjust_Discount = new Button();
            btnItem_Unit_Price = new Button();
            ((System.ComponentModel.ISupportInitialize)grdItemList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDiscountPercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            cmnuPayWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).BeginInit();
            SuspendLayout();
            // 
            // grdItemList
            // 
            grdItemList.AllowUserToAddRows = false;
            grdItemList.AllowUserToDeleteRows = false;
            grdItemList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdItemList.BackgroundColor = SystemColors.Control;
            grdItemList.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItemList.Columns.AddRange(new DataGridViewColumn[] { colItem_Unit_ID, colSale_Transaction_Item_ID, colItem_ID, colItem_Desc, colItem_Group_ID, colUnit_ID, colUnit_Desc, colItem_Unit_Price, colItem_Unit_Cost, colBarcode, colQnt, colTotalAmount, colUndo });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdItemList.DefaultCellStyle = dataGridViewCellStyle4;
            grdItemList.Location = new Point(14, 48);
            grdItemList.Name = "grdItemList";
            grdItemList.ReadOnly = true;
            grdItemList.RowHeadersVisible = false;
            grdItemList.RowHeadersWidth = 51;
            grdItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItemList.Size = new Size(527, 350);
            grdItemList.TabIndex = 0;
            grdItemList.CellContentClick += grdItemList_CellContentClick;
            grdItemList.CellFormatting += grdItemList_CellFormatting;
            grdItemList.CellPainting += grdItemList_CellPainting;
            // 
            // colItem_Unit_ID
            // 
            colItem_Unit_ID.DataPropertyName = "Item_Unit_ID";
            colItem_Unit_ID.HeaderText = "Item_Unit_ID";
            colItem_Unit_ID.MinimumWidth = 6;
            colItem_Unit_ID.Name = "colItem_Unit_ID";
            colItem_Unit_ID.ReadOnly = true;
            colItem_Unit_ID.Visible = false;
            colItem_Unit_ID.Width = 125;
            // 
            // colSale_Transaction_Item_ID
            // 
            colSale_Transaction_Item_ID.DataPropertyName = "Sale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.HeaderText = "Sale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.MinimumWidth = 6;
            colSale_Transaction_Item_ID.Name = "colSale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.ReadOnly = true;
            colSale_Transaction_Item_ID.Visible = false;
            colSale_Transaction_Item_ID.Width = 125;
            // 
            // colItem_ID
            // 
            colItem_ID.DataPropertyName = "Item_ID";
            colItem_ID.HeaderText = "Item_ID";
            colItem_ID.MinimumWidth = 6;
            colItem_ID.Name = "colItem_ID";
            colItem_ID.ReadOnly = true;
            colItem_ID.Visible = false;
            colItem_ID.Width = 125;
            // 
            // colItem_Desc
            // 
            colItem_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem_Desc.DataPropertyName = "Item_Desc";
            colItem_Desc.HeaderText = "الصنف";
            colItem_Desc.MinimumWidth = 6;
            colItem_Desc.Name = "colItem_Desc";
            colItem_Desc.ReadOnly = true;
            // 
            // colItem_Group_ID
            // 
            colItem_Group_ID.DataPropertyName = "Item_Group_ID";
            colItem_Group_ID.HeaderText = "Item_Group_ID";
            colItem_Group_ID.MinimumWidth = 6;
            colItem_Group_ID.Name = "colItem_Group_ID";
            colItem_Group_ID.ReadOnly = true;
            colItem_Group_ID.Visible = false;
            colItem_Group_ID.Width = 125;
            // 
            // colUnit_ID
            // 
            colUnit_ID.DataPropertyName = "Unit_ID";
            colUnit_ID.HeaderText = "Unit_ID";
            colUnit_ID.MinimumWidth = 6;
            colUnit_ID.Name = "colUnit_ID";
            colUnit_ID.ReadOnly = true;
            colUnit_ID.Visible = false;
            colUnit_ID.Width = 125;
            // 
            // colUnit_Desc
            // 
            colUnit_Desc.DataPropertyName = "Unit_Desc";
            colUnit_Desc.HeaderText = "الوحدة";
            colUnit_Desc.MinimumWidth = 6;
            colUnit_Desc.Name = "colUnit_Desc";
            colUnit_Desc.ReadOnly = true;
            colUnit_Desc.Visible = false;
            colUnit_Desc.Width = 70;
            // 
            // colItem_Unit_Price
            // 
            colItem_Unit_Price.DataPropertyName = "Item_Unit_Price";
            colItem_Unit_Price.HeaderText = "السعر";
            colItem_Unit_Price.MinimumWidth = 6;
            colItem_Unit_Price.Name = "colItem_Unit_Price";
            colItem_Unit_Price.ReadOnly = true;
            colItem_Unit_Price.Width = 70;
            // 
            // colItem_Unit_Cost
            // 
            colItem_Unit_Cost.DataPropertyName = "Item_Unit_Cost";
            colItem_Unit_Cost.HeaderText = "Item_Unit_Cost";
            colItem_Unit_Cost.MinimumWidth = 6;
            colItem_Unit_Cost.Name = "colItem_Unit_Cost";
            colItem_Unit_Cost.ReadOnly = true;
            colItem_Unit_Cost.Visible = false;
            colItem_Unit_Cost.Width = 125;
            // 
            // colBarcode
            // 
            colBarcode.DataPropertyName = "Barcode";
            colBarcode.HeaderText = "Barcode";
            colBarcode.MinimumWidth = 6;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Visible = false;
            colBarcode.Width = 125;
            // 
            // colQnt
            // 
            colQnt.DataPropertyName = "Qnt";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            colQnt.DefaultCellStyle = dataGridViewCellStyle2;
            colQnt.HeaderText = "الكمية";
            colQnt.MinimumWidth = 6;
            colQnt.Name = "colQnt";
            colQnt.ReadOnly = true;
            colQnt.Width = 70;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            colTotalAmount.HeaderText = "الاجمالي";
            colTotalAmount.MinimumWidth = 6;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.Width = 125;
            // 
            // colUndo
            // 
            colUndo.HeaderText = "";
            colUndo.Image = (Image)resources.GetObject("colUndo.Image");
            colUndo.Name = "colUndo";
            colUndo.ReadOnly = true;
            colUndo.Width = 50;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblDiscountPercent);
            panel1.Controls.Add(btnDiscountPercent);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnPayWay);
            panel1.Controls.Add(lblNetAmount);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblItemCount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel1.Location = new Point(11, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 116);
            panel1.TabIndex = 1;
            // 
            // lblDiscountPercent
            // 
            lblDiscountPercent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscountPercent.BackColor = Color.White;
            lblDiscountPercent.BorderStyle = BorderStyle.Fixed3D;
            lblDiscountPercent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDiscountPercent.Location = new Point(291, 86);
            lblDiscountPercent.Name = "lblDiscountPercent";
            lblDiscountPercent.Size = new Size(91, 27);
            lblDiscountPercent.TabIndex = 15;
            lblDiscountPercent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDiscountPercent
            // 
            btnDiscountPercent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiscountPercent.Image = (Image)resources.GetObject("btnDiscountPercent.Image");
            btnDiscountPercent.Location = new Point(248, 84);
            btnDiscountPercent.Margin = new Padding(3, 2, 3, 2);
            btnDiscountPercent.Name = "btnDiscountPercent";
            btnDiscountPercent.Size = new Size(44, 27);
            btnDiscountPercent.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDiscountPercent.TabIndex = 14;
            btnDiscountPercent.TabStop = false;
            btnDiscountPercent.Click += btnDiscountPercent_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.BackColor = Color.Gray;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(248, 47);
            label5.Name = "label5";
            label5.Size = new Size(134, 32);
            label5.TabIndex = 12;
            label5.Text = "خصم نسبة";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPayWay
            // 
            btnPayWay.Anchor = AnchorStyles.Top;
            btnPayWay.BackColor = Color.FromArgb(250, 166, 24);
            btnPayWay.Font = new Font("Segoe UI", 10F);
            btnPayWay.Image = (Image)resources.GetObject("btnPayWay.Image");
            btnPayWay.Location = new Point(175, 46);
            btnPayWay.Margin = new Padding(3, 2, 3, 2);
            btnPayWay.Name = "btnPayWay";
            btnPayWay.Size = new Size(64, 47);
            btnPayWay.TabIndex = 7;
            btnPayWay.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayWay.UseVisualStyleBackColor = false;
            btnPayWay.Click += btnPayWay_Click;
            // 
            // lblNetAmount
            // 
            lblNetAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNetAmount.BackColor = Color.White;
            lblNetAmount.BorderStyle = BorderStyle.Fixed3D;
            lblNetAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblNetAmount.Location = new Point(12, 46);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(82, 33);
            lblNetAmount.TabIndex = 11;
            lblNetAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalAmount.BackColor = Color.White;
            lblTotalAmount.BorderStyle = BorderStyle.Fixed3D;
            lblTotalAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(248, 12);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(120, 27);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.TextAlign = ContentAlignment.MiddleLeft;
            lblTotalAmount.Paint += lblTotalAmount_Paint;
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.BackColor = Color.White;
            lblDiscount.BorderStyle = BorderStyle.Fixed3D;
            lblDiscount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDiscount.Location = new Point(388, 86);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(79, 27);
            lblDiscount.TabIndex = 10;
            lblDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblItemCount
            // 
            lblItemCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblItemCount.BackColor = Color.White;
            lblItemCount.BorderStyle = BorderStyle.Fixed3D;
            lblItemCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblItemCount.Location = new Point(11, 7);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(83, 27);
            lblItemCount.TabIndex = 6;
            lblItemCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(101, 47);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 4;
            label3.Text = "للدفع";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 86);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(100, 7);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "عدد الاصناف";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(374, 12);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 0;
            label1.Text = "المبلغ قبل الخصم";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(388, 47);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 6;
            label4.Text = "خصم مبلغ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Image = (Image)resources.GetObject("btnPrintInvoice.Image");
            btnPrintInvoice.Location = new Point(9, 5);
            btnPrintInvoice.Margin = new Padding(3, 2, 3, 2);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(42, 39);
            btnPrintInvoice.TabIndex = 13;
            btnPrintInvoice.UseVisualStyleBackColor = true;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBarcode.Font = new Font("Segoe UI", 14F);
            txtBarcode.Location = new Point(433, 8);
            txtBarcode.Margin = new Padding(3, 2, 3, 2);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(56, 32);
            txtBarcode.TabIndex = 2;
            txtBarcode.MouseClick += txtBarcode_MouseClick;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.Enter += txtBarcode_Enter;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.ImageIndex = 0;
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new Point(383, 8);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 38);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SeachIcon.jpg");
            imageList1.Images.SetKeyName(1, "icons8-save-50.png");
            imageList1.Images.SetKeyName(2, "icons8-cash-50.png");
            imageList1.Images.SetKeyName(3, "icons8-cheque-50.png");
            imageList1.Images.SetKeyName(4, "icons8-credit-card-50.png");
            imageList1.Images.SetKeyName(5, "icons8-liabilities-50.png");
            imageList1.Images.SetKeyName(6, "icons8-money-transfer-50.png");
            imageList1.Images.SetKeyName(7, "icons8-online-50.png");
            imageList1.Images.SetKeyName(8, "AdvancedSearch.png");
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(65, 124, 73);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(236, 4);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 47);
            btnSave.TabIndex = 4;
            btnSave.Text = "حفظ";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSaveWithoutPrint);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 464);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 60);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // btnSaveWithoutPrint
            // 
            btnSaveWithoutPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveWithoutPrint.BackColor = Color.FromArgb(86, 45, 193);
            btnSaveWithoutPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveWithoutPrint.ForeColor = Color.White;
            btnSaveWithoutPrint.Image = (Image)resources.GetObject("btnSaveWithoutPrint.Image");
            btnSaveWithoutPrint.Location = new Point(360, 2);
            btnSaveWithoutPrint.Margin = new Padding(3, 2, 3, 2);
            btnSaveWithoutPrint.Name = "btnSaveWithoutPrint";
            btnSaveWithoutPrint.Size = new Size(172, 47);
            btnSaveWithoutPrint.TabIndex = 6;
            btnSaveWithoutPrint.Text = "حفظ";
            btnSaveWithoutPrint.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveWithoutPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSaveWithoutPrint.UseVisualStyleBackColor = false;
            btnSaveWithoutPrint.Click += btnSaveWithoutPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(11, 5);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "الغاء";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmnuPayWay
            // 
            cmnuPayWay.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            cmnuPayWay.ImageScalingSize = new Size(20, 20);
            cmnuPayWay.Items.AddRange(new ToolStripItem[] { mnuCash, mnuDebits, mnuCheques, mnuMoneyTransfere, mnuCreditCard, mnuOnlineSales });
            cmnuPayWay.Name = "cmnuPayWay";
            cmnuPayWay.RightToLeft = RightToLeft.Yes;
            cmnuPayWay.Size = new Size(223, 196);
            // 
            // mnuCash
            // 
            mnuCash.Image = (Image)resources.GetObject("mnuCash.Image");
            mnuCash.Name = "mnuCash";
            mnuCash.Size = new Size(222, 32);
            mnuCash.Text = "نقدي";
            mnuCash.Click += mnuCash_Click;
            // 
            // mnuDebits
            // 
            mnuDebits.Image = (Image)resources.GetObject("mnuDebits.Image");
            mnuDebits.Name = "mnuDebits";
            mnuDebits.Size = new Size(222, 32);
            mnuDebits.Text = "ذمم";
            mnuDebits.Click += mnuDebits_Click;
            // 
            // mnuCheques
            // 
            mnuCheques.Image = (Image)resources.GetObject("mnuCheques.Image");
            mnuCheques.Name = "mnuCheques";
            mnuCheques.Size = new Size(222, 32);
            mnuCheques.Text = "شيكات";
            mnuCheques.Click += mnuCheques_Click;
            // 
            // mnuMoneyTransfere
            // 
            mnuMoneyTransfere.Image = (Image)resources.GetObject("mnuMoneyTransfere.Image");
            mnuMoneyTransfere.Name = "mnuMoneyTransfere";
            mnuMoneyTransfere.Size = new Size(222, 32);
            mnuMoneyTransfere.Text = "حوالة";
            mnuMoneyTransfere.Click += mnuMoneyTransfere_Click;
            // 
            // mnuCreditCard
            // 
            mnuCreditCard.Image = (Image)resources.GetObject("mnuCreditCard.Image");
            mnuCreditCard.Name = "mnuCreditCard";
            mnuCreditCard.Size = new Size(222, 32);
            mnuCreditCard.Text = "فيزا";
            mnuCreditCard.Click += mnuCreditCard_Click;
            // 
            // mnuOnlineSales
            // 
            mnuOnlineSales.Image = (Image)resources.GetObject("mnuOnlineSales.Image");
            mnuOnlineSales.Name = "mnuOnlineSales";
            mnuOnlineSales.Size = new Size(222, 32);
            mnuOnlineSales.Text = "اون لاين Online";
            mnuOnlineSales.Click += mnuOnlineSales_Click;
            // 
            // btnBarcodeNumericCalc
            // 
            btnBarcodeNumericCalc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBarcodeNumericCalc.Image = (Image)resources.GetObject("btnBarcodeNumericCalc.Image");
            btnBarcodeNumericCalc.Location = new Point(495, 8);
            btnBarcodeNumericCalc.Margin = new Padding(3, 2, 3, 2);
            btnBarcodeNumericCalc.Name = "btnBarcodeNumericCalc";
            btnBarcodeNumericCalc.Size = new Size(44, 38);
            btnBarcodeNumericCalc.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBarcodeNumericCalc.TabIndex = 14;
            btnBarcodeNumericCalc.TabStop = false;
            btnBarcodeNumericCalc.Click += btnBarcodeNumericCalc_Click;
            // 
            // btnAdvancedSearch
            // 
            btnAdvancedSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdvancedSearch.BackgroundImageLayout = ImageLayout.None;
            btnAdvancedSearch.ImageIndex = 8;
            btnAdvancedSearch.ImageList = imageList1;
            btnAdvancedSearch.Location = new Point(318, 8);
            btnAdvancedSearch.Margin = new Padding(3, 2, 3, 2);
            btnAdvancedSearch.Name = "btnAdvancedSearch";
            btnAdvancedSearch.Size = new Size(61, 38);
            btnAdvancedSearch.TabIndex = 15;
            btnAdvancedSearch.UseVisualStyleBackColor = true;
            btnAdvancedSearch.Click += btnAdvancedSearch_Click;
            // 
            // btnAdjust_Item_QNT
            // 
            btnAdjust_Item_QNT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdjust_Item_QNT.Location = new Point(130, 8);
            btnAdjust_Item_QNT.Margin = new Padding(3, 2, 3, 2);
            btnAdjust_Item_QNT.Name = "btnAdjust_Item_QNT";
            btnAdjust_Item_QNT.Size = new Size(102, 34);
            btnAdjust_Item_QNT.TabIndex = 19;
            btnAdjust_Item_QNT.Text = "تغيير الكمية F2";
            btnAdjust_Item_QNT.UseVisualStyleBackColor = true;
            btnAdjust_Item_QNT.Click += btnAdjust_Item_QNT_Click;
            // 
            // btnAdjust_Discount
            // 
            btnAdjust_Discount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdjust_Discount.Location = new Point(140, 5);
            btnAdjust_Discount.Margin = new Padding(3, 2, 3, 2);
            btnAdjust_Discount.Name = "btnAdjust_Discount";
            btnAdjust_Discount.Size = new Size(71, 34);
            btnAdjust_Discount.TabIndex = 20;
            btnAdjust_Discount.Text = "خصم F3";
            btnAdjust_Discount.UseVisualStyleBackColor = true;
            btnAdjust_Discount.Visible = false;
            // 
            // btnItem_Unit_Price
            // 
            btnItem_Unit_Price.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnItem_Unit_Price.Location = new Point(56, 5);
            btnItem_Unit_Price.Margin = new Padding(3, 2, 3, 2);
            btnItem_Unit_Price.Name = "btnItem_Unit_Price";
            btnItem_Unit_Price.Size = new Size(69, 34);
            btnItem_Unit_Price.TabIndex = 21;
            btnItem_Unit_Price.Text = "السعر F4";
            btnItem_Unit_Price.UseVisualStyleBackColor = true;
            btnItem_Unit_Price.Click += btnItem_Unit_Price_Click;
            // 
            // SoldItemListComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnItem_Unit_Price);
            Controls.Add(btnAdjust_Discount);
            Controls.Add(btnAdjust_Item_QNT);
            Controls.Add(btnAdvancedSearch);
            Controls.Add(btnBarcodeNumericCalc);
            Controls.Add(btnPrintInvoice);
            Controls.Add(btnSearch);
            Controls.Add(txtBarcode);
            Controls.Add(panel1);
            Controls.Add(grdItemList);
            Controls.Add(panel2);
            Name = "SoldItemListComponent";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(541, 524);
            Paint += SoldItemListComponent_Paint;
            ((System.ComponentModel.ISupportInitialize)grdItemList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDiscountPercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            cmnuPayWay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBarcodeNumericCalc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdItemList;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBarcode;
        private Button btnSearch;
        private ImageList imageList1;
        private Button btnSave;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblItemCount;
        private Label lblTotalAmount;
        private Label lblDiscount;
        private Label lblNetAmount;
        private Button btnCancel;
        private Button btnSaveWithoutPrint;
        private Button btnPayWay;
        private ContextMenuStrip cmnuPayWay;
        private ToolStripMenuItem mnuCash;
        private ToolStripMenuItem mnuDebits;
        private ToolStripMenuItem mnuCheques;
        private ToolStripMenuItem mnuMoneyTransfere;
        private ToolStripMenuItem mnuCreditCard;
        private ToolStripMenuItem mnuOnlineSales;
        private Button btnPrintInvoice;
        private PictureBox btnBarcodeNumericCalc;
        private Button btnAdvancedSearch;
        private Button btnAdjust_Item_QNT;
        private Button btnAdjust_Discount;
        private Button btnItem_Unit_Price;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_Item_ID;
        private DataGridViewTextBoxColumn colItem_ID;
        private DataGridViewTextBoxColumn colItem_Desc;
        private DataGridViewTextBoxColumn colItem_Group_ID;
        private DataGridViewTextBoxColumn colUnit_ID;
        private DataGridViewTextBoxColumn colUnit_Desc;
        private DataGridViewTextBoxColumn colItem_Unit_Price;
        private DataGridViewTextBoxColumn colItem_Unit_Cost;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colQnt;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewImageColumn colUndo;
        private Label label5;
        private Label lblDiscountPercent;
        private PictureBox btnDiscountPercent;
    }
}
