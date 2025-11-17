namespace POS.Windows.LOVs
{
    partial class UnitLOV
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
            txtUnit_Desc = new TextBox();
            label1 = new Label();
            grdUnitLIst = new DataGridView();
            colUnit_ID = new DataGridViewTextBoxColumn();
            colUnit_Desc = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdUnitLIst).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "جديد";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(178, 15);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUnit_Desc
            // 
            txtUnit_Desc.Location = new Point(271, 16);
            txtUnit_Desc.Margin = new Padding(3, 4, 3, 4);
            txtUnit_Desc.Name = "txtUnit_Desc";
            txtUnit_Desc.Size = new Size(244, 27);
            txtUnit_Desc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "الوحدة";
            // 
            // grdUnitLIst
            // 
            grdUnitLIst.AllowUserToAddRows = false;
            grdUnitLIst.AllowUserToDeleteRows = false;
            grdUnitLIst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdUnitLIst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdUnitLIst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUnitLIst.Columns.AddRange(new DataGridViewColumn[] { colUnit_ID, colUnit_Desc });
            grdUnitLIst.Location = new Point(17, 65);
            grdUnitLIst.Margin = new Padding(3, 4, 3, 4);
            grdUnitLIst.Name = "grdUnitLIst";
            grdUnitLIst.ReadOnly = true;
            grdUnitLIst.RowHeadersWidth = 51;
            grdUnitLIst.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUnitLIst.Size = new Size(537, 469);
            grdUnitLIst.TabIndex = 0;
            grdUnitLIst.CellContentDoubleClick += grdUnitLIst_CellContentDoubleClick;
            grdUnitLIst.KeyDown += grdUnitLIst_KeyDown;
            // 
            // colUnit_ID
            // 
            colUnit_ID.DataPropertyName = "Unit_ID";
            colUnit_ID.HeaderText = "";
            colUnit_ID.MinimumWidth = 6;
            colUnit_ID.Name = "colUnit_ID";
            colUnit_ID.ReadOnly = true;
            colUnit_ID.Width = 50;
            // 
            // colUnit_Desc
            // 
            colUnit_Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit_Desc.DataPropertyName = "Unit_Desc";
            colUnit_Desc.HeaderText = "الوحدة";
            colUnit_Desc.MinimumWidth = 6;
            colUnit_Desc.Name = "colUnit_Desc";
            colUnit_Desc.ReadOnly = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(42, 553);
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
            btnOK.Location = new Point(454, 553);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 5;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // UnitLOV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(grdUnitLIst);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtUnit_Desc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnitLOV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الوحدات";
            ((System.ComponentModel.ISupportInitialize)grdUnitLIst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtUnit_Desc;
        private Label label1;
        private DataGridView grdUnitLIst;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewTextBoxColumn colUnit_ID;
        private DataGridViewTextBoxColumn colUnit_Desc;
    }
}