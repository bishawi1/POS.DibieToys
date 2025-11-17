namespace POS.Windows.LOVs
{
    partial class BankLov
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
            grdBankList = new DataGridView();
            btnSearch = new Button();
            txtBankName = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            btnAdd = new Button();
            colBank_No = new DataGridViewTextBoxColumn();
            colBank_Name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdBankList).BeginInit();
            SuspendLayout();
            // 
            // grdBankList
            // 
            grdBankList.AllowUserToAddRows = false;
            grdBankList.AllowUserToDeleteRows = false;
            grdBankList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdBankList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBankList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBankList.Columns.AddRange(new DataGridViewColumn[] { colBank_No, colBank_Name });
            grdBankList.Location = new Point(14, 71);
            grdBankList.Margin = new Padding(3, 4, 3, 4);
            grdBankList.Name = "grdBankList";
            grdBankList.ReadOnly = true;
            grdBankList.RowHeadersWidth = 51;
            grdBankList.RowTemplate.Height = 25;
            grdBankList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBankList.Size = new Size(544, 460);
            grdBankList.TabIndex = 27;
            grdBankList.CellContentDoubleClick += grdBankList_CellContentDoubleClick;
            grdBankList.CellDoubleClick += grdBankList_CellDoubleClick;
            grdBankList.KeyDown += grdBankList_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(151, 21);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBankName
            // 
            txtBankName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBankName.Location = new Point(243, 21);
            txtBankName.Margin = new Padding(3, 4, 3, 4);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(213, 27);
            txtBankName.TabIndex = 25;
            txtBankName.TextChanged += txtBankName_TextChanged;
            txtBankName.KeyDown += txtBankName_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(464, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 24;
            label1.Text = "البنك";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 551);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 29;
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
            btnOK.TabIndex = 28;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(14, 20);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // colBank_No
            // 
            colBank_No.DataPropertyName = "Bank_No";
            colBank_No.HeaderText = "الرمز";
            colBank_No.MinimumWidth = 6;
            colBank_No.Name = "colBank_No";
            colBank_No.ReadOnly = true;
            colBank_No.Width = 125;
            // 
            // colBank_Name
            // 
            colBank_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBank_Name.DataPropertyName = "Bank_Name";
            colBank_Name.HeaderText = "الوصف";
            colBank_Name.MinimumWidth = 6;
            colBank_Name.Name = "colBank_Name";
            colBank_Name.ReadOnly = true;
            // 
            // BankLov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnAdd);
            Controls.Add(grdBankList);
            Controls.Add(btnSearch);
            Controls.Add(txtBankName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BankLov";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة البنوك";
            ((System.ComponentModel.ISupportInitialize)grdBankList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView grdBankList;
        private Button btnSearch;
        private TextBox txtBankName;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private Button btnAdd;
        private DataGridViewTextBoxColumn colBank_No;
        private DataGridViewTextBoxColumn colBank_Name;
    }
}