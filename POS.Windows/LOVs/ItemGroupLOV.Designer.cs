namespace POS.Windows.LOVs
{
    partial class ItemGroupLOV
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
            grdItemGroup = new DataGridView();
            colItem_Group_ID = new DataGridViewTextBoxColumn();
            colItem_Group_Desc = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtItem_Group_Desc = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)grdItemGroup).BeginInit();
            SuspendLayout();
            // 
            // grdItemGroup
            // 
            grdItemGroup.AllowUserToAddRows = false;
            grdItemGroup.AllowUserToDeleteRows = false;
            grdItemGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdItemGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdItemGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItemGroup.Columns.AddRange(new DataGridViewColumn[] { colItem_Group_ID, colItem_Group_Desc });
            grdItemGroup.Location = new Point(21, 65);
            grdItemGroup.Margin = new Padding(3, 4, 3, 4);
            grdItemGroup.Name = "grdItemGroup";
            grdItemGroup.ReadOnly = true;
            grdItemGroup.RowHeadersWidth = 51;
            grdItemGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItemGroup.Size = new Size(537, 469);
            grdItemGroup.TabIndex = 0;
            grdItemGroup.CellContentDoubleClick += grdItemGroup_CellContentDoubleClick;
            grdItemGroup.KeyDown += grdItemGroup_KeyDown;
            // 
            // colItem_Group_ID
            // 
            colItem_Group_ID.DataPropertyName = "Item_Group_ID";
            colItem_Group_ID.HeaderText = "";
            colItem_Group_ID.MinimumWidth = 6;
            colItem_Group_ID.Name = "colItem_Group_ID";
            colItem_Group_ID.ReadOnly = true;
            colItem_Group_ID.Width = 50;
            // 
            // colItem_Group_Desc
            // 
            colItem_Group_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem_Group_Desc.DataPropertyName = "Item_Group_Desc";
            colItem_Group_Desc.HeaderText = "الفئة";
            colItem_Group_Desc.MinimumWidth = 6;
            colItem_Group_Desc.Name = "colItem_Group_Desc";
            colItem_Group_Desc.ReadOnly = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(450, 553);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 5;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(39, 553);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "الفئة";
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.Location = new Point(253, 24);
            txtItem_Group_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.Size = new Size(244, 27);
            txtItem_Group_Desc.TabIndex = 2;
            txtItem_Group_Desc.TextChanged += txtItem_Group_Desc_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(160, 23);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 23);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ItemGroupLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtItem_Group_Desc);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdItemGroup);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemGroupLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة مجموعة /فئة الصنف";
            ((System.ComponentModel.ISupportInitialize)grdItemGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdItemGroup;
        private DataGridViewTextBoxColumn colItem_Group_ID;
        private DataGridViewTextBoxColumn colItem_Group_Desc;
        private Button btnOK;
        private Button btnCancel;
        private Label label1;
        private TextBox txtItem_Group_Desc;
        private Button btnSearch;
        private Button btnAdd;
    }
}