namespace POS.Windows.LOVs
{
    partial class CustomerLov
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
            grdCustomerList = new DataGridView();
            colPerson_ID = new DataGridViewTextBoxColumn();
            colPerson_Name = new DataGridViewTextBoxColumn();
            colSell_Discount_Percent = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtPerson_Name = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCustomerList).BeginInit();
            SuspendLayout();
            // 
            // grdCustomerList
            // 
            grdCustomerList.AllowUserToAddRows = false;
            grdCustomerList.AllowUserToDeleteRows = false;
            grdCustomerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCustomerList.Columns.AddRange(new DataGridViewColumn[] { colPerson_ID, colPerson_Name, colSell_Discount_Percent });
            grdCustomerList.Location = new Point(12, 55);
            grdCustomerList.Name = "grdCustomerList";
            grdCustomerList.ReadOnly = true;
            grdCustomerList.RowTemplate.Height = 25;
            grdCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCustomerList.Size = new Size(476, 345);
            grdCustomerList.TabIndex = 9;
            grdCustomerList.CellContentClick += grdCustomerList_CellContentClick;
            grdCustomerList.CellContentDoubleClick += grdCustomerList_CellContentDoubleClick;
            grdCustomerList.CellDoubleClick += grdCustomerList_CellDoubleClick;
            grdCustomerList.KeyDown += grdCustomerList_KeyDown;
            // 
            // colPerson_ID
            // 
            colPerson_ID.DataPropertyName = "Person_ID";
            colPerson_ID.HeaderText = "الرمز";
            colPerson_ID.Name = "colPerson_ID";
            colPerson_ID.ReadOnly = true;
            // 
            // colPerson_Name
            // 
            colPerson_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPerson_Name.DataPropertyName = "Person_Name";
            colPerson_Name.HeaderText = "الاسم";
            colPerson_Name.Name = "colPerson_Name";
            colPerson_Name.ReadOnly = true;
            // 
            // colSell_Discount_Percent
            // 
            colSell_Discount_Percent.DataPropertyName = "Sell_Discount_Percent";
            colSell_Discount_Percent.HeaderText = "colSell_Discount_Percent";
            colSell_Discount_Percent.Name = "colSell_Discount_Percent";
            colSell_Discount_Percent.ReadOnly = true;
            colSell_Discount_Percent.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(31, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPerson_Name
            // 
            txtPerson_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerson_Name.Location = new Point(152, 17);
            txtPerson_Name.Name = "txtPerson_Name";
            txtPerson_Name.Size = new Size(251, 23);
            txtPerson_Name.TabIndex = 7;
            txtPerson_Name.TextChanged += txtPerson_Name_TextChanged;
            txtPerson_Name.KeyDown += txtPerson_Name_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(422, 17);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "اسم الزبون";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(31, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(396, 415);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CustomerLov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(grdCustomerList);
            Controls.Add(btnSearch);
            Controls.Add(txtPerson_Name);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerLov";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الزبائن";
            ((System.ComponentModel.ISupportInitialize)grdCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView grdCustomerList;
        private Button btnSearch;
        private TextBox txtPerson_Name;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colPerson_ID;
        private DataGridViewTextBoxColumn colPerson_Name;
        private DataGridViewTextBoxColumn colSell_Discount_Percent;
    }
}