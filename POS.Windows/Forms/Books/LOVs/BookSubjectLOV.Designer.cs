namespace POS.Windows.Forms.Books.LOVs
{
    partial class BookSubjectLOV
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
            txtBook_Subject_Desc = new TextBox();
            label1 = new Label();
            grdList = new DataGridView();
            colBook_Subject_ID = new DataGridViewTextBoxColumn();
            colBook_Subject_Desc = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(56, 12);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 17;
            btnAdd.TabStop = false;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(195, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 16;
            btnSearch.TabStop = false;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBook_Subject_Desc
            // 
            txtBook_Subject_Desc.Location = new Point(288, 13);
            txtBook_Subject_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Subject_Desc.Name = "txtBook_Subject_Desc";
            txtBook_Subject_Desc.Size = new Size(212, 27);
            txtBook_Subject_Desc.TabIndex = 15;
            txtBook_Subject_Desc.TextChanged += txtBook_Subject_Desc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 17);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 14;
            label1.Text = "المؤلف";
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
            grdList.Columns.AddRange(new DataGridViewColumn[] { colBook_Subject_ID, colBook_Subject_Desc });
            grdList.Location = new Point(17, 66);
            grdList.Margin = new Padding(3, 4, 3, 4);
            grdList.Name = "grdList";
            grdList.ReadOnly = true;
            grdList.RowHeadersWidth = 51;
            grdList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdList.Size = new Size(537, 469);
            grdList.TabIndex = 18;
            grdList.CellContentClick += grdList_CellContentClick;
            grdList.KeyDown += grdList_KeyDown;
            // 
            // colBook_Subject_ID
            // 
            colBook_Subject_ID.DataPropertyName = "Book_Subject_ID";
            colBook_Subject_ID.HeaderText = "";
            colBook_Subject_ID.MinimumWidth = 6;
            colBook_Subject_ID.Name = "colBook_Subject_ID";
            colBook_Subject_ID.ReadOnly = true;
            colBook_Subject_ID.Width = 50;
            // 
            // colBook_Subject_Desc
            // 
            colBook_Subject_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBook_Subject_Desc.DataPropertyName = "Book_Subject_Desc";
            colBook_Subject_Desc.HeaderText = "الاسم";
            colBook_Subject_Desc.MinimumWidth = 6;
            colBook_Subject_Desc.Name = "colBook_Subject_Desc";
            colBook_Subject_Desc.ReadOnly = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(39, 556);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(450, 556);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 19;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // BookSubjectLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdList);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtBook_Subject_Desc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookSubjectLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة المواضيع";
            ((System.ComponentModel.ISupportInitialize)grdList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtBook_Subject_Desc;
        private Label label1;
        private DataGridView grdList;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colBook_Subject_ID;
        private DataGridViewTextBoxColumn colBook_Subject_Desc;
    }
}