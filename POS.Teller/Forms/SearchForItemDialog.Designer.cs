namespace POS.Teller.Forms
{
    partial class SearchForItemDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForItemDialog));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtItem_Desc = new TextBox();
            btnSearch = new Button();
            imageList1 = new ImageList(components);
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
            btnOK = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(568, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "الصنف";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.Font = new Font("Segoe UI", 14F);
            txtItem_Desc.Location = new Point(258, 17);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.Size = new Size(304, 39);
            txtItem_Desc.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.ImageIndex = 0;
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new Point(198, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(54, 48);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SeachIcon.jpg");
            imageList1.Images.SetKeyName(1, "icons8-cancel-50-red.png");
            imageList1.Images.SetKeyName(2, "icons8-ok-50.png");
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
            grdItems.Location = new Point(12, 67);
            grdItems.Margin = new Padding(3, 4, 3, 4);
            grdItems.Name = "grdItems";
            grdItems.ReadOnly = true;
            grdItems.RowHeadersWidth = 51;
            grdItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItems.Size = new Size(647, 377);
            grdItems.TabIndex = 5;
            grdItems.CellContentDoubleClick += grdItems_CellContentDoubleClick;
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
            colItem_Desc.Width = 200;
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
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(495, 451);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(139, 60);
            btnOK.TabIndex = 32;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.ImageKey = "icons8-cancel-50-red.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(52, 451);
            button1.Name = "button1";
            button1.Size = new Size(139, 60);
            button1.TabIndex = 33;
            button1.Text = "الغاء امر";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchForItemDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 523);
            Controls.Add(button1);
            Controls.Add(btnOK);
            Controls.Add(grdItems);
            Controls.Add(btnSearch);
            Controls.Add(txtItem_Desc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForItemDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بحث الاصناف";
            Load += SearchForItemDialog_Load;
            ((System.ComponentModel.ISupportInitialize)grdItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItem_Desc;
        private Button btnSearch;
        private ImageList imageList1;
        private DataGridView grdItems;
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
        private Button btnOK;
        private Button button1;
    }
}