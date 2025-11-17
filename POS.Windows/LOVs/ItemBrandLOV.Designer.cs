namespace POS.Windows.LOVs
{
    partial class ItemBrandLOV
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
            btnAdd = new Button();
            btnSearch = new Button();
            txtItem_Brand_Name = new TextBox();
            label1 = new Label();
            grdBrandList = new DataGridView();
            colItem_Brand_ID = new DataGridViewTextBoxColumn();
            colItem_Brand_Name = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdBrandList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(40, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(179, 15);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtItem_Brand_Name
            // 
            txtItem_Brand_Name.Location = new Point(272, 16);
            txtItem_Brand_Name.Margin = new Padding(3, 4, 3, 4);
            txtItem_Brand_Name.Name = "txtItem_Brand_Name";
            txtItem_Brand_Name.Size = new Size(212, 27);
            txtItem_Brand_Name.TabIndex = 2;
            txtItem_Brand_Name.TextChanged += txtItem_Brand_Name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "المصنع";
            // 
            // grdBrandList
            // 
            grdBrandList.AllowUserToAddRows = false;
            grdBrandList.AllowUserToDeleteRows = false;
            grdBrandList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdBrandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBrandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBrandList.Columns.AddRange(new DataGridViewColumn[] { colItem_Brand_ID, colItem_Brand_Name });
            grdBrandList.Location = new Point(17, 65);
            grdBrandList.Margin = new Padding(3, 4, 3, 4);
            grdBrandList.Name = "grdBrandList";
            grdBrandList.ReadOnly = true;
            grdBrandList.RowHeadersWidth = 51;
            grdBrandList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBrandList.Size = new Size(537, 469);
            grdBrandList.TabIndex = 0;
            grdBrandList.CellContentClick += grdBrandList_CellContentClick;
            grdBrandList.CellContentDoubleClick += grdBrandList_CellContentDoubleClick;
            grdBrandList.KeyDown += grdBrandList_KeyDown;
            // 
            // colItem_Brand_ID
            // 
            colItem_Brand_ID.DataPropertyName = "Item_Brand_ID";
            colItem_Brand_ID.HeaderText = "";
            colItem_Brand_ID.MinimumWidth = 6;
            colItem_Brand_ID.Name = "colItem_Brand_ID";
            colItem_Brand_ID.ReadOnly = true;
            colItem_Brand_ID.Width = 50;
            // 
            // colItem_Brand_Name
            // 
            colItem_Brand_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem_Brand_Name.DataPropertyName = "Item_Brand_Name";
            colItem_Brand_Name.HeaderText = "الاسم";
            colItem_Brand_Name.MinimumWidth = 6;
            colItem_Brand_Name.Name = "colItem_Brand_Name";
            colItem_Brand_Name.ReadOnly = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(38, 553);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(449, 553);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 5;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ItemBrandLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdBrandList);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtItem_Brand_Name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemBrandLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الشركات المصنعة";
            ((System.ComponentModel.ISupportInitialize)grdBrandList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtItem_Brand_Name;
        private Label label1;
        private DataGridView grdBrandList;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colItem_Brand_ID;
        private DataGridViewTextBoxColumn colItem_Brand_Name;
    }
}