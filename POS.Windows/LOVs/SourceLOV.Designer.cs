namespace POS.Windows.LOVs
{
    partial class SourceLOV
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
            grdBookSourceList = new DataGridView();
            colBook_Source_ID = new DataGridViewTextBoxColumn();
            colBook_Source_Desc = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtBooktxtSource_Name = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)grdBookSourceList).BeginInit();
            SuspendLayout();
            // 
            // grdBookSourceList
            // 
            grdBookSourceList.AllowUserToAddRows = false;
            grdBookSourceList.AllowUserToDeleteRows = false;
            grdBookSourceList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdBookSourceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBookSourceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBookSourceList.Columns.AddRange(new DataGridViewColumn[] { colBook_Source_ID, colBook_Source_Desc });
            grdBookSourceList.Location = new Point(14, 71);
            grdBookSourceList.Margin = new Padding(3, 4, 3, 4);
            grdBookSourceList.Name = "grdBookSourceList";
            grdBookSourceList.ReadOnly = true;
            grdBookSourceList.RowHeadersWidth = 51;
            grdBookSourceList.RowTemplate.Height = 25;
            grdBookSourceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBookSourceList.Size = new Size(544, 460);
            grdBookSourceList.TabIndex = 0;
            grdBookSourceList.CellContentDoubleClick += grdBookSourceList_CellContentDoubleClick;
            grdBookSourceList.CellDoubleClick += grdBookSourceList_CellDoubleClick;
            grdBookSourceList.KeyDown += grdBookSourceList_KeyDown;
            // 
            // colBook_Source_ID
            // 
            colBook_Source_ID.DataPropertyName = "Book_Source_ID";
            colBook_Source_ID.HeaderText = "الرمز";
            colBook_Source_ID.MinimumWidth = 6;
            colBook_Source_ID.Name = "colBook_Source_ID";
            colBook_Source_ID.ReadOnly = true;
            colBook_Source_ID.Width = 125;
            // 
            // colBook_Source_Desc
            // 
            colBook_Source_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBook_Source_Desc.DataPropertyName = "Book_Source_Desc";
            colBook_Source_Desc.HeaderText = "الوصف";
            colBook_Source_Desc.MinimumWidth = 6;
            colBook_Source_Desc.Name = "colBook_Source_Desc";
            colBook_Source_Desc.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(154, 21);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBooktxtSource_Name
            // 
            txtBooktxtSource_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBooktxtSource_Name.Location = new Point(247, 21);
            txtBooktxtSource_Name.Margin = new Padding(3, 4, 3, 4);
            txtBooktxtSource_Name.Name = "txtBooktxtSource_Name";
            txtBooktxtSource_Name.Size = new Size(210, 27);
            txtBooktxtSource_Name.TabIndex = 2;
            txtBooktxtSource_Name.TextChanged += txtBooktxtSource_Name_TextChanged;
            txtBooktxtSource_Name.KeyDown += txtBooktxtSource_Name_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(464, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "المورد";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 539);
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
            btnOK.Location = new Point(464, 551);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 5;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(14, 21);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // SourceLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnAdd);
            Controls.Add(grdBookSourceList);
            Controls.Add(btnSearch);
            Controls.Add(txtBooktxtSource_Name);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SourceLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الموردين";
            ((System.ComponentModel.ISupportInitialize)grdBookSourceList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView grdBookSourceList;
        private Button btnSearch;
        private TextBox txtBooktxtSource_Name;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colBook_Source_ID;
        private DataGridViewTextBoxColumn colBook_Source_Desc;
        private Button btnAdd;
    }
}