namespace POS.Windows.LOVs
{
    partial class CurrencyLOV
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
            grdCurrencyList = new DataGridView();
            colCurrency_ID = new DataGridViewTextBoxColumn();
            colCurrency_Name = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtCurrencyName = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCurrencyList).BeginInit();
            SuspendLayout();
            // 
            // grdCurrencyList
            // 
            grdCurrencyList.AllowUserToAddRows = false;
            grdCurrencyList.AllowUserToDeleteRows = false;
            grdCurrencyList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdCurrencyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdCurrencyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCurrencyList.Columns.AddRange(new DataGridViewColumn[] { colCurrency_ID, colCurrency_Name });
            grdCurrencyList.Location = new Point(12, 53);
            grdCurrencyList.Name = "grdCurrencyList";
            grdCurrencyList.ReadOnly = true;
            grdCurrencyList.RowTemplate.Height = 25;
            grdCurrencyList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCurrencyList.Size = new Size(476, 345);
            grdCurrencyList.TabIndex = 15;
            grdCurrencyList.CellContentDoubleClick += grdCurrencyList_CellContentDoubleClick;
            grdCurrencyList.CellDoubleClick += grdCurrencyList_CellDoubleClick;
            grdCurrencyList.KeyDown += grdCurrencyList_KeyDown;
            // 
            // colCurrency_ID
            // 
            colCurrency_ID.DataPropertyName = "Currency_ID";
            colCurrency_ID.HeaderText = "الرمز";
            colCurrency_ID.Name = "colCurrency_ID";
            colCurrency_ID.ReadOnly = true;
            // 
            // colCurrency_Name
            // 
            colCurrency_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCurrency_Name.DataPropertyName = "Currency_Name";
            colCurrency_Name.HeaderText = "الوصف";
            colCurrency_Name.Name = "colCurrency_Name";
            colCurrency_Name.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(68, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCurrencyName
            // 
            txtCurrencyName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrencyName.Location = new Point(149, 16);
            txtCurrencyName.Name = "txtCurrencyName";
            txtCurrencyName.Size = new Size(251, 23);
            txtCurrencyName.TabIndex = 13;
            txtCurrencyName.TextChanged += txtCurrencyName_TextChanged;
            txtCurrencyName.KeyDown += txtCurrencyName_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(406, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "العملة";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(406, 413);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 16;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CurrencyLOV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(grdCurrencyList);
            Controls.Add(btnSearch);
            Controls.Add(txtCurrencyName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CurrencyLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة العملات";
            ((System.ComponentModel.ISupportInitialize)grdCurrencyList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView grdCurrencyList;
        private Button btnSearch;
        private TextBox txtCurrencyName;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colCurrency_ID;
        private DataGridViewTextBoxColumn colCurrency_Name;
    }
}