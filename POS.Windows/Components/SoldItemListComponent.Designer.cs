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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            grdItemList = new DataGridView();
            panel1 = new Panel();
            txtItemCount = new NumericUpDown();
            label2 = new Label();
            txtTotalAmount = new NumericUpDown();
            label1 = new Label();
            txtQnt = new NumericUpDown();
            label3 = new Label();
            btnIncrease = new Button();
            btnDecrease = new Button();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colItem_ID = new DataGridViewTextBoxColumn();
            colItem_Desc = new DataGridViewTextBoxColumn();
            colIncrease = new DataGridViewButtonColumn();
            colItem_Group_ID = new DataGridViewTextBoxColumn();
            colUnit_ID = new DataGridViewTextBoxColumn();
            colUnit_Desc = new DataGridViewTextBoxColumn();
            colItem_Unit_Price = new DataGridViewTextBoxColumn();
            colItem_Unit_Cost = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colQnt = new DataGridViewTextBoxColumn();
            colDescrease = new DataGridViewButtonColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdItemList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtItemCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQnt).BeginInit();
            SuspendLayout();
            // 
            // grdItemList
            // 
            grdItemList.AllowUserToAddRows = false;
            grdItemList.AllowUserToDeleteRows = false;
            grdItemList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdItemList.BorderStyle = BorderStyle.None;
            grdItemList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdItemList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItemList.Columns.AddRange(new DataGridViewColumn[] { colItem_Unit_ID, colItem_ID, colItem_Desc, colIncrease, colItem_Group_ID, colUnit_ID, colUnit_Desc, colItem_Unit_Price, colItem_Unit_Cost, colBarcode, colQnt, colDescrease, colTotalAmount });
            grdItemList.EnableHeadersVisualStyles = false;
            grdItemList.Location = new Point(11, 46);
            grdItemList.Name = "grdItemList";
            grdItemList.ReadOnly = true;
            grdItemList.RowHeadersVisible = false;
            grdItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItemList.Size = new Size(373, 189);
            grdItemList.TabIndex = 0;
            grdItemList.CellContentClick += grdItemList_CellContentClick;
            grdItemList.SelectionChanged += grdItemList_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtItemCount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 45);
            panel1.TabIndex = 1;
            // 
            // txtItemCount
            // 
            txtItemCount.DecimalPlaces = 1;
            txtItemCount.Location = new Point(17, 10);
            txtItemCount.Name = "txtItemCount";
            txtItemCount.Size = new Size(79, 23);
            txtItemCount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 12);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "عدد الاصناف";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.DecimalPlaces = 1;
            txtTotalAmount.Location = new Point(191, 10);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(79, 23);
            txtTotalAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "السعر الاجمالي";
            // 
            // txtQnt
            // 
            txtQnt.DecimalPlaces = 1;
            txtQnt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtQnt.Location = new Point(210, 11);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(83, 29);
            txtQnt.TabIndex = 5;
            txtQnt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 16);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "الكمية";
            // 
            // btnIncrease
            // 
            btnIncrease.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIncrease.Location = new Point(297, 11);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(37, 29);
            btnIncrease.TabIndex = 6;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDecrease.Location = new Point(167, 11);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(37, 29);
            btnDecrease.TabIndex = 7;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // colItem_Unit_ID
            // 
            colItem_Unit_ID.DataPropertyName = "Item_Unit_ID";
            colItem_Unit_ID.HeaderText = "Item_Unit_ID";
            colItem_Unit_ID.Name = "colItem_Unit_ID";
            colItem_Unit_ID.ReadOnly = true;
            colItem_Unit_ID.Visible = false;
            // 
            // colItem_ID
            // 
            colItem_ID.DataPropertyName = "Item_ID";
            colItem_ID.HeaderText = "Item_ID";
            colItem_ID.Name = "colItem_ID";
            colItem_ID.ReadOnly = true;
            colItem_ID.Visible = false;
            // 
            // colItem_Desc
            // 
            colItem_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem_Desc.DataPropertyName = "Item_Desc";
            colItem_Desc.HeaderText = "الصنف";
            colItem_Desc.Name = "colItem_Desc";
            colItem_Desc.ReadOnly = true;
            // 
            // colIncrease
            // 
            colIncrease.DataPropertyName = "Increase";
            colIncrease.HeaderText = "";
            colIncrease.Name = "colIncrease";
            colIncrease.ReadOnly = true;
            colIncrease.Resizable = DataGridViewTriState.True;
            colIncrease.SortMode = DataGridViewColumnSortMode.Automatic;
            colIncrease.Width = 40;
            // 
            // colItem_Group_ID
            // 
            colItem_Group_ID.DataPropertyName = "Item_Group_ID";
            colItem_Group_ID.HeaderText = "Item_Group_ID";
            colItem_Group_ID.Name = "colItem_Group_ID";
            colItem_Group_ID.ReadOnly = true;
            colItem_Group_ID.Visible = false;
            // 
            // colUnit_ID
            // 
            colUnit_ID.DataPropertyName = "Unit_ID";
            colUnit_ID.HeaderText = "Unit_ID";
            colUnit_ID.Name = "colUnit_ID";
            colUnit_ID.ReadOnly = true;
            colUnit_ID.Visible = false;
            // 
            // colUnit_Desc
            // 
            colUnit_Desc.DataPropertyName = "Unit_Desc";
            colUnit_Desc.HeaderText = "الوحدة";
            colUnit_Desc.Name = "colUnit_Desc";
            colUnit_Desc.ReadOnly = true;
            colUnit_Desc.Visible = false;
            colUnit_Desc.Width = 70;
            // 
            // colItem_Unit_Price
            // 
            colItem_Unit_Price.DataPropertyName = "Item_Unit_Price";
            colItem_Unit_Price.HeaderText = "السعر";
            colItem_Unit_Price.Name = "colItem_Unit_Price";
            colItem_Unit_Price.ReadOnly = true;
            colItem_Unit_Price.Visible = false;
            colItem_Unit_Price.Width = 70;
            // 
            // colItem_Unit_Cost
            // 
            colItem_Unit_Cost.DataPropertyName = "Item_Unit_Cost";
            colItem_Unit_Cost.HeaderText = "Item_Unit_Cost";
            colItem_Unit_Cost.Name = "colItem_Unit_Cost";
            colItem_Unit_Cost.ReadOnly = true;
            colItem_Unit_Cost.Visible = false;
            // 
            // colBarcode
            // 
            colBarcode.DataPropertyName = "Barcode";
            colBarcode.HeaderText = "Barcode";
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Visible = false;
            // 
            // colQnt
            // 
            colQnt.DataPropertyName = "Qnt";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            colQnt.DefaultCellStyle = dataGridViewCellStyle2;
            colQnt.HeaderText = "الكمية";
            colQnt.Name = "colQnt";
            colQnt.ReadOnly = true;
            colQnt.Width = 70;
            // 
            // colDescrease
            // 
            colDescrease.DataPropertyName = "Descrease";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            colDescrease.DefaultCellStyle = dataGridViewCellStyle3;
            colDescrease.HeaderText = "";
            colDescrease.Name = "colDescrease";
            colDescrease.ReadOnly = true;
            colDescrease.Width = 40;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            colTotalAmount.HeaderText = "الاجمالي";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // SoldItemListComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDecrease);
            Controls.Add(btnIncrease);
            Controls.Add(txtQnt);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(grdItemList);
            Name = "SoldItemListComponent";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(387, 290);
            ((System.ComponentModel.ISupportInitialize)grdItemList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtItemCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQnt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdItemList;
        private Panel panel1;
        private Label label1;
        private NumericUpDown txtTotalAmount;
        private NumericUpDown txtItemCount;
        private Label label2;
        private NumericUpDown txtQnt;
        private Label label3;
        private Button btnIncrease;
        private Button btnDecrease;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colItem_ID;
        private DataGridViewTextBoxColumn colItem_Desc;
        private DataGridViewButtonColumn colIncrease;
        private DataGridViewTextBoxColumn colItem_Group_ID;
        private DataGridViewTextBoxColumn colUnit_ID;
        private DataGridViewTextBoxColumn colUnit_Desc;
        private DataGridViewTextBoxColumn colItem_Unit_Price;
        private DataGridViewTextBoxColumn colItem_Unit_Cost;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colQnt;
        private DataGridViewButtonColumn colDescrease;
        private DataGridViewTextBoxColumn colTotalAmount;
    }
}
