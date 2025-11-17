namespace POS.Windows.Forms.Books.LOVs
{
    partial class PublisherLov
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
            txtPublisherName = new TextBox();
            label1 = new Label();
            grdList = new DataGridView();
            colPublisher_ID = new DataGridViewTextBoxColumn();
            colPublisher_Desc = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(59, 12);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 8;
            btnAdd.TabStop = false;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(198, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 7;
            btnSearch.TabStop = false;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(291, 13);
            txtPublisherName.Margin = new Padding(3, 4, 3, 4);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(212, 27);
            txtPublisherName.TabIndex = 6;
            txtPublisherName.TextChanged += txtPublisherName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 17);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 5;
            label1.Text = "الناشر";
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
            grdList.Columns.AddRange(new DataGridViewColumn[] { colPublisher_ID, colPublisher_Desc });
            grdList.Location = new Point(17, 66);
            grdList.Margin = new Padding(3, 4, 3, 4);
            grdList.Name = "grdList";
            grdList.ReadOnly = true;
            grdList.RowHeadersWidth = 51;
            grdList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdList.Size = new Size(537, 469);
            grdList.TabIndex = 9;
            grdList.CellContentClick += grdList_CellContentClick;
            grdList.CellDoubleClick += grdList_CellDoubleClick;
            grdList.KeyDown += grdList_KeyDown;
            // 
            // colPublisher_ID
            // 
            colPublisher_ID.DataPropertyName = "Publisher_ID";
            colPublisher_ID.HeaderText = "";
            colPublisher_ID.MinimumWidth = 6;
            colPublisher_ID.Name = "colPublisher_ID";
            colPublisher_ID.ReadOnly = true;
            colPublisher_ID.Width = 50;
            // 
            // colPublisher_Desc
            // 
            colPublisher_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPublisher_Desc.DataPropertyName = "Publisher_Desc";
            colPublisher_Desc.HeaderText = "الاسم";
            colPublisher_Desc.MinimumWidth = 6;
            colPublisher_Desc.Name = "colPublisher_Desc";
            colPublisher_Desc.ReadOnly = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(40, 556);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(451, 556);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 10;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // PublisherLov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdList);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtPublisherName);
            Controls.Add(label1);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PublisherLov";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الناشرين";
            ((System.ComponentModel.ISupportInitialize)grdList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtPublisherName;
        private Label label1;
        private DataGridView grdList;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colPublisher_ID;
        private DataGridViewTextBoxColumn colPublisher_Desc;
    }
}