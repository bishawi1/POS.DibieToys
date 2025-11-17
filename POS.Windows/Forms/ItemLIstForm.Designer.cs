namespace POS.Windows
{
    partial class ItemListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbtnNew_Item = new ToolStripButton();
            tsbtnShowItemDetails = new ToolStripButton();
            tsbtnItemStockDetails = new ToolStripButton();
            tsbtnBeginingQnt = new ToolStripButton();
            pnlCriteria = new Panel();
            txtBarcode = new TextBox();
            label5 = new Label();
            btnShow_Item_Group_ID_LOV = new Button();
            txtItem_Group_ID = new MaskedTextBox();
            txtItem_Group_Desc = new TextBox();
            label4 = new Label();
            txtItem_Desc = new TextBox();
            label2 = new Label();
            btnGetData = new Button();
            grdItems = new DataGridView();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colItem_ID = new DataGridViewTextBoxColumn();
            colItem_Desc = new DataGridViewTextBoxColumn();
            colItem_Group_ID = new DataGridViewTextBoxColumn();
            colItem_Group_Desc = new DataGridViewTextBoxColumn();
            colItem_Status_ID = new DataGridViewTextBoxColumn();
            colUnit_ID = new DataGridViewTextBoxColumn();
            colUnit_Desc = new DataGridViewTextBoxColumn();
            colItem_Unit_Price = new DataGridViewTextBoxColumn();
            colItem_Unit_Cost = new DataGridViewTextBoxColumn();
            colRemainQNT = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colIs_Main_Unit = new DataGridViewCheckBoxColumn();
            txtItemCount = new MaskedTextBox();
            label1 = new Label();
            label6 = new Label();
            cmbBranch_ID = new ComboBox();
            toolStrip1.SuspendLayout();
            pnlCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdItems).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNew_Item, tsbtnShowItemDetails, tsbtnItemStockDetails, tsbtnBeginingQnt });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1219, 55);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew_Item
            // 
            tsbtnNew_Item.Image = Properties.Resources.Add_Order;
            tsbtnNew_Item.ImageTransparentColor = Color.Magenta;
            tsbtnNew_Item.Name = "tsbtnNew_Item";
            tsbtnNew_Item.Size = new Size(91, 52);
            tsbtnNew_Item.Text = "جديد";
            tsbtnNew_Item.Click += tsbtnNew_Item_Click;
            // 
            // tsbtnShowItemDetails
            // 
            tsbtnShowItemDetails.Image = Properties.Resources.EditRecord;
            tsbtnShowItemDetails.ImageTransparentColor = Color.Magenta;
            tsbtnShowItemDetails.Name = "tsbtnShowItemDetails";
            tsbtnShowItemDetails.Size = new Size(108, 52);
            tsbtnShowItemDetails.Text = "تفاصيل";
            tsbtnShowItemDetails.Click += tsbtnShowItemDetails_Click;
            // 
            // tsbtnItemStockDetails
            // 
            tsbtnItemStockDetails.Image = Properties.Resources.view_details;
            tsbtnItemStockDetails.ImageTransparentColor = Color.Magenta;
            tsbtnItemStockDetails.Name = "tsbtnItemStockDetails";
            tsbtnItemStockDetails.Size = new Size(153, 52);
            tsbtnItemStockDetails.Text = "بطاقة المخزون";
            tsbtnItemStockDetails.Click += tsbtnItemStockDetails_Click;
            // 
            // tsbtnBeginingQnt
            // 
            tsbtnBeginingQnt.Image = Properties.Resources.icons8_quantity_50;
            tsbtnBeginingQnt.ImageTransparentColor = Color.Magenta;
            tsbtnBeginingQnt.Name = "tsbtnBeginingQnt";
            tsbtnBeginingQnt.Size = new Size(143, 52);
            tsbtnBeginingQnt.Text = "كمية افتتاحية";
            tsbtnBeginingQnt.Click += tsbtnBeginingQnt_Click;
            // 
            // pnlCriteria
            // 
            pnlCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCriteria.BorderStyle = BorderStyle.FixedSingle;
            pnlCriteria.Controls.Add(label6);
            pnlCriteria.Controls.Add(cmbBranch_ID);
            pnlCriteria.Controls.Add(txtBarcode);
            pnlCriteria.Controls.Add(label5);
            pnlCriteria.Controls.Add(btnShow_Item_Group_ID_LOV);
            pnlCriteria.Controls.Add(txtItem_Group_ID);
            pnlCriteria.Controls.Add(txtItem_Group_Desc);
            pnlCriteria.Controls.Add(label4);
            pnlCriteria.Controls.Add(txtItem_Desc);
            pnlCriteria.Controls.Add(label2);
            pnlCriteria.Controls.Add(btnGetData);
            pnlCriteria.Location = new Point(450, 55);
            pnlCriteria.Margin = new Padding(3, 4, 3, 4);
            pnlCriteria.Name = "pnlCriteria";
            pnlCriteria.Size = new Size(748, 133);
            pnlCriteria.TabIndex = 1;
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Location = new Point(311, 13);
            txtBarcode.Margin = new Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(337, 27);
            txtBarcode.TabIndex = 1;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(655, 13);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "باركود";
            // 
            // btnShow_Item_Group_ID_LOV
            // 
            btnShow_Item_Group_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Group_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Group_ID_LOV.Location = new Point(580, 91);
            btnShow_Item_Group_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Group_ID_LOV.Name = "btnShow_Item_Group_ID_LOV";
            btnShow_Item_Group_ID_LOV.Size = new Size(31, 31);
            btnShow_Item_Group_ID_LOV.TabIndex = 6;
            btnShow_Item_Group_ID_LOV.TabStop = false;
            btnShow_Item_Group_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Group_ID_LOV.Click += btnShow_Item_Group_ID_LOV_Click;
            // 
            // txtItem_Group_ID
            // 
            txtItem_Group_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_ID.Location = new Point(614, 91);
            txtItem_Group_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_ID.Mask = "00000";
            txtItem_Group_ID.Name = "txtItem_Group_ID";
            txtItem_Group_ID.Size = new Size(34, 27);
            txtItem_Group_ID.TabIndex = 5;
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_Desc.BackColor = Color.White;
            txtItem_Group_Desc.Location = new Point(311, 91);
            txtItem_Group_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.ReadOnly = true;
            txtItem_Group_Desc.Size = new Size(267, 27);
            txtItem_Group_Desc.TabIndex = 7;
            txtItem_Group_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(655, 91);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "فئة الصنف";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.Location = new Point(311, 52);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.Size = new Size(337, 27);
            txtItem_Desc.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(655, 52);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "اسم الصنف";
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(218, 91);
            btnGetData.Margin = new Padding(3, 4, 3, 4);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(86, 31);
            btnGetData.TabIndex = 8;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // grdItems
            // 
            grdItems.AllowUserToAddRows = false;
            grdItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItems.Columns.AddRange(new DataGridViewColumn[] { colItem_Unit_ID, colItem_ID, colItem_Desc, colItem_Group_ID, colItem_Group_Desc, colItem_Status_ID, colUnit_ID, colUnit_Desc, colItem_Unit_Price, colItem_Unit_Cost, colRemainQNT, colBarcode, colIs_Main_Unit });
            grdItems.Location = new Point(21, 215);
            grdItems.Margin = new Padding(3, 4, 3, 4);
            grdItems.Name = "grdItems";
            grdItems.ReadOnly = true;
            grdItems.RowHeadersWidth = 51;
            grdItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItems.Size = new Size(1185, 473);
            grdItems.TabIndex = 2;
            grdItems.CellMouseDoubleClick += grdItems_CellMouseDoubleClick;
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
            colItem_Desc.DataPropertyName = "Item_Desc";
            colItem_Desc.HeaderText = "الصنف";
            colItem_Desc.MinimumWidth = 6;
            colItem_Desc.Name = "colItem_Desc";
            colItem_Desc.ReadOnly = true;
            colItem_Desc.Width = 300;
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
            // colItem_Group_Desc
            // 
            colItem_Group_Desc.DataPropertyName = "Item_Group_Desc";
            colItem_Group_Desc.HeaderText = "الفئة";
            colItem_Group_Desc.MinimumWidth = 6;
            colItem_Group_Desc.Name = "colItem_Group_Desc";
            colItem_Group_Desc.ReadOnly = true;
            colItem_Group_Desc.Width = 125;
            // 
            // colItem_Status_ID
            // 
            colItem_Status_ID.DataPropertyName = "Item_Status_ID";
            colItem_Status_ID.HeaderText = "Item_Status_ID";
            colItem_Status_ID.MinimumWidth = 6;
            colItem_Status_ID.Name = "colItem_Status_ID";
            colItem_Status_ID.ReadOnly = true;
            colItem_Status_ID.Visible = false;
            colItem_Status_ID.Width = 125;
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
            colUnit_Desc.Width = 125;
            // 
            // colItem_Unit_Price
            // 
            colItem_Unit_Price.DataPropertyName = "Item_Unit_Price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            colItem_Unit_Price.DefaultCellStyle = dataGridViewCellStyle2;
            colItem_Unit_Price.HeaderText = "السعر";
            colItem_Unit_Price.MinimumWidth = 6;
            colItem_Unit_Price.Name = "colItem_Unit_Price";
            colItem_Unit_Price.ReadOnly = true;
            colItem_Unit_Price.Width = 125;
            // 
            // colItem_Unit_Cost
            // 
            colItem_Unit_Cost.DataPropertyName = "Item_Unit_Cost";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colItem_Unit_Cost.DefaultCellStyle = dataGridViewCellStyle3;
            colItem_Unit_Cost.HeaderText = "سعر التكلفة";
            colItem_Unit_Cost.MinimumWidth = 6;
            colItem_Unit_Cost.Name = "colItem_Unit_Cost";
            colItem_Unit_Cost.ReadOnly = true;
            colItem_Unit_Cost.Width = 125;
            // 
            // colRemainQNT
            // 
            colRemainQNT.DataPropertyName = "RemainQNT";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            colRemainQNT.DefaultCellStyle = dataGridViewCellStyle4;
            colRemainQNT.HeaderText = "المتبقي";
            colRemainQNT.MinimumWidth = 6;
            colRemainQNT.Name = "colRemainQNT";
            colRemainQNT.ReadOnly = true;
            colRemainQNT.Width = 125;
            // 
            // colBarcode
            // 
            colBarcode.DataPropertyName = "Barcode";
            colBarcode.HeaderText = "باركود";
            colBarcode.MinimumWidth = 6;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Width = 125;
            // 
            // colIs_Main_Unit
            // 
            colIs_Main_Unit.DataPropertyName = "Is_Main_Unit";
            colIs_Main_Unit.HeaderText = "Is_Main_Unit";
            colIs_Main_Unit.MinimumWidth = 6;
            colIs_Main_Unit.Name = "colIs_Main_Unit";
            colIs_Main_Unit.ReadOnly = true;
            colIs_Main_Unit.Visible = false;
            colIs_Main_Unit.Width = 125;
            // 
            // txtItemCount
            // 
            txtItemCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtItemCount.Location = new Point(1031, 706);
            txtItemCount.Margin = new Padding(3, 4, 3, 4);
            txtItemCount.Mask = "00000000";
            txtItemCount.Name = "txtItemCount";
            txtItemCount.Size = new Size(54, 27);
            txtItemCount.TabIndex = 7;
            txtItemCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1092, 706);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 6;
            label1.Text = "عدد الاصناف";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(249, 13);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 61;
            label6.Text = "الفرع";
            // 
            // cmbBranch_ID
            // 
            cmbBranch_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch_ID.FormattingEnabled = true;
            cmbBranch_ID.Location = new Point(16, 13);
            cmbBranch_ID.Name = "cmbBranch_ID";
            cmbBranch_ID.Size = new Size(227, 28);
            cmbBranch_ID.TabIndex = 60;
            // 
            // ItemListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 746);
            Controls.Add(txtItemCount);
            Controls.Add(label1);
            Controls.Add(grdItems);
            Controls.Add(pnlCriteria);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الاصناف";
            KeyDown += ItemListForm_KeyDown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlCriteria.ResumeLayout(false);
            pnlCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNew_Item;
        private Panel pnlCriteria;
        private Button btnGetData;
        private DataGridView grdItems;
        private ToolStripButton tsbtnShowItemDetails;
        private TextBox txtItem_Desc;
        private Label label2;
        private Button btnShow_Item_Group_ID_LOV;
        private MaskedTextBox txtItem_Group_ID;
        private TextBox txtItem_Group_Desc;
        private Label label4;
        private TextBox txtBarcode;
        private Label label5;
        private MaskedTextBox txtItemCount;
        private Label label1;
        private ToolStripButton tsbtnItemStockDetails;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colItem_ID;
        private DataGridViewTextBoxColumn colItem_Desc;
        private DataGridViewTextBoxColumn colItem_Group_ID;
        private DataGridViewTextBoxColumn colItem_Group_Desc;
        private DataGridViewTextBoxColumn colItem_Status_ID;
        private DataGridViewTextBoxColumn colUnit_ID;
        private DataGridViewTextBoxColumn colUnit_Desc;
        private DataGridViewTextBoxColumn colItem_Unit_Price;
        private DataGridViewTextBoxColumn colItem_Unit_Cost;
        private DataGridViewTextBoxColumn colRemainQNT;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewCheckBoxColumn colIs_Main_Unit;
        private ToolStripButton tsbtnBeginingQnt;
        private Label label6;
        private ComboBox cmbBranch_ID;
    }
}