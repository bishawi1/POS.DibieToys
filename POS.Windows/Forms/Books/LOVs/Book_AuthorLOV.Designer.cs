namespace POS.Windows.Forms.Books.LOVs
{
    partial class Book_AuthorLOV
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
            grdList = new DataGridView();
            colBook_Author_ID = new DataGridViewTextBoxColumn();
            colBook_Author_Desc = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnSearch = new Button();
            txtBook_Author_Desc = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdList).BeginInit();
            SuspendLayout();
            // 
            // grdList
            // 
            grdList.AllowUserToAddRows = false;
            grdList.AllowUserToDeleteRows = false;
            grdList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdList.Columns.AddRange(new DataGridViewColumn[] { colBook_Author_ID, colBook_Author_Desc });
            grdList.Location = new Point(22, 66);
            grdList.Margin = new Padding(3, 4, 3, 4);
            grdList.Name = "grdList";
            grdList.ReadOnly = true;
            grdList.RowHeadersWidth = 51;
            grdList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdList.Size = new Size(537, 469);
            grdList.TabIndex = 14;
            grdList.CellContentClick += grdList_CellContentClick;
            grdList.KeyDown += grdList_KeyDown;
            // 
            // colBook_Author_ID
            // 
            colBook_Author_ID.DataPropertyName = "Book_Author_ID";
            colBook_Author_ID.HeaderText = "";
            colBook_Author_ID.MinimumWidth = 6;
            colBook_Author_ID.Name = "colBook_Author_ID";
            colBook_Author_ID.ReadOnly = true;
            colBook_Author_ID.Width = 50;
            // 
            // colBook_Author_Desc
            // 
            colBook_Author_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBook_Author_Desc.DataPropertyName = "Book_Author_Desc";
            colBook_Author_Desc.HeaderText = "الاسم";
            colBook_Author_Desc.MinimumWidth = 6;
            colBook_Author_Desc.Name = "colBook_Author_Desc";
            colBook_Author_Desc.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(64, 12);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 13;
            btnAdd.TabStop = false;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(203, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 12;
            btnSearch.TabStop = false;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBook_Author_Desc
            // 
            txtBook_Author_Desc.Location = new Point(296, 13);
            txtBook_Author_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_Desc.Name = "txtBook_Author_Desc";
            txtBook_Author_Desc.Size = new Size(212, 27);
            txtBook_Author_Desc.TabIndex = 11;
            txtBook_Author_Desc.TextChanged += txtBook_Author_Desc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 17);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 10;
            label1.Text = "المؤلف";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(38, 556);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(449, 556);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 15;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Book_AuthorLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdList);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtBook_Author_Desc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Book_AuthorLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة المؤلفين";
            ((System.ComponentModel.ISupportInitialize)grdList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdList;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtBook_Author_Desc;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colBook_Author_ID;
        private DataGridViewTextBoxColumn colBook_Author_Desc;
    }
}