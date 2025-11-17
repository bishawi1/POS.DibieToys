namespace POS.Windows.LOVs
{
    partial class CityLOV
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
            grdCityList = new DataGridView();
            colCity_ID = new DataGridViewTextBoxColumn();
            colCity_Name = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtCityName = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCityList).BeginInit();
            SuspendLayout();
            // 
            // grdCityList
            // 
            grdCityList.AllowUserToAddRows = false;
            grdCityList.AllowUserToDeleteRows = false;
            grdCityList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdCityList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdCityList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCityList.Columns.AddRange(new DataGridViewColumn[] { colCity_ID, colCity_Name });
            grdCityList.Location = new Point(12, 53);
            grdCityList.Name = "grdCityList";
            grdCityList.ReadOnly = true;
            grdCityList.RowTemplate.Height = 25;
            grdCityList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCityList.Size = new Size(476, 345);
            grdCityList.TabIndex = 21;
            grdCityList.CellContentClick += grdCityList_CellContentClick;
            grdCityList.CellContentDoubleClick += grdCityList_CellContentDoubleClick;
            grdCityList.CellDoubleClick += grdCityList_CellDoubleClick;
            grdCityList.KeyDown += grdCityList_KeyDown;
            // 
            // colCity_ID
            // 
            colCity_ID.DataPropertyName = "City_ID";
            colCity_ID.HeaderText = "الرمز";
            colCity_ID.Name = "colCity_ID";
            colCity_ID.ReadOnly = true;
            // 
            // colCity_Name
            // 
            colCity_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCity_Name.DataPropertyName = "City_Name";
            colCity_Name.HeaderText = "الوصف";
            colCity_Name.Name = "colCity_Name";
            colCity_Name.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(157, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCityName
            // 
            txtCityName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCityName.Location = new Point(238, 16);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(162, 23);
            txtCityName.TabIndex = 19;
            txtCityName.TextChanged += txtCityName_TextChanged;
            txtCityName.KeyDown += txtCityName_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(406, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 18;
            label1.Text = "المدينة";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(406, 413);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 22;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(12, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // CityLOV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(btnAdd);
            Controls.Add(grdCityList);
            Controls.Add(btnSearch);
            Controls.Add(txtCityName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CityLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة المدن";
            ((System.ComponentModel.ISupportInitialize)grdCityList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView grdCityList;
        private DataGridViewTextBoxColumn colCity_ID;
        private DataGridViewTextBoxColumn colCity_Name;
        private Button btnSearch;
        private TextBox txtCityName;
        private Label label1;
        private Button btnCancel;
        private Button btnOK;
        private Button btnAdd;
    }
}