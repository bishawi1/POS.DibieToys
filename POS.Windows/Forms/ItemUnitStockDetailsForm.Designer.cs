namespace POS.Windows.Forms
{
    partial class ItemUnitStockDetailsForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grdDetails = new DataGridView();
            colStock_ID = new DataGridViewTextBoxColumn();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colIn_QNT = new DataGridViewTextBoxColumn();
            colOut_QNT = new DataGridViewTextBoxColumn();
            colTransaction_Type_ID = new DataGridViewTextBoxColumn();
            colTransaction_Type_Desc = new DataGridViewTextBoxColumn();
            colTransaction_ID = new DataGridViewTextBoxColumn();
            colUser_Name = new DataGridViewTextBoxColumn();
            colTime_Stamp = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)grdDetails).BeginInit();
            SuspendLayout();
            // 
            // grdDetails
            // 
            grdDetails.AllowUserToAddRows = false;
            grdDetails.AllowUserToDeleteRows = false;
            grdDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDetails.Columns.AddRange(new DataGridViewColumn[] { colStock_ID, colItem_Unit_ID, colDate, colIn_QNT, colOut_QNT, colTransaction_Type_ID, colTransaction_Type_Desc, colTransaction_ID, colUser_Name, colTime_Stamp });
            grdDetails.Location = new Point(12, 12);
            grdDetails.Name = "grdDetails";
            grdDetails.ReadOnly = true;
            grdDetails.RowHeadersWidth = 51;
            grdDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDetails.Size = new Size(623, 376);
            grdDetails.TabIndex = 0;
            // 
            // colStock_ID
            // 
            colStock_ID.DataPropertyName = "Stock_ID";
            colStock_ID.HeaderText = "Stock_ID";
            colStock_ID.MinimumWidth = 6;
            colStock_ID.Name = "colStock_ID";
            colStock_ID.ReadOnly = true;
            colStock_ID.Visible = false;
            colStock_ID.Width = 125;
            // 
            // colItem_Unit_ID
            // 
            colItem_Unit_ID.DataPropertyName = "Item_Unit_ID";
            colItem_Unit_ID.HeaderText = "Item_Unit_ID";
            colItem_Unit_ID.MinimumWidth = 6;
            colItem_Unit_ID.Name = "colItem_Unit_ID";
            colItem_Unit_ID.ReadOnly = true;
            colItem_Unit_ID.Visible = false;
            colItem_Unit_ID.Width = 125;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "Time_Stamp";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colDate.DefaultCellStyle = dataGridViewCellStyle2;
            colDate.HeaderText = "التاريخ";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 125;
            // 
            // colIn_QNT
            // 
            colIn_QNT.DataPropertyName = "In_QNT";
            colIn_QNT.HeaderText = "داخل";
            colIn_QNT.MinimumWidth = 6;
            colIn_QNT.Name = "colIn_QNT";
            colIn_QNT.ReadOnly = true;
            colIn_QNT.Width = 125;
            // 
            // colOut_QNT
            // 
            colOut_QNT.DataPropertyName = "Out_QNT";
            colOut_QNT.HeaderText = "خارج";
            colOut_QNT.MinimumWidth = 6;
            colOut_QNT.Name = "colOut_QNT";
            colOut_QNT.ReadOnly = true;
            colOut_QNT.Width = 125;
            // 
            // colTransaction_Type_ID
            // 
            colTransaction_Type_ID.DataPropertyName = "Transaction_Type_ID";
            colTransaction_Type_ID.HeaderText = "Transaction_Type_ID";
            colTransaction_Type_ID.MinimumWidth = 6;
            colTransaction_Type_ID.Name = "colTransaction_Type_ID";
            colTransaction_Type_ID.ReadOnly = true;
            colTransaction_Type_ID.Visible = false;
            colTransaction_Type_ID.Width = 125;
            // 
            // colTransaction_Type_Desc
            // 
            colTransaction_Type_Desc.DataPropertyName = "Transaction_Type_Desc";
            colTransaction_Type_Desc.HeaderText = "الحركة";
            colTransaction_Type_Desc.MinimumWidth = 6;
            colTransaction_Type_Desc.Name = "colTransaction_Type_Desc";
            colTransaction_Type_Desc.ReadOnly = true;
            colTransaction_Type_Desc.Width = 125;
            // 
            // colTransaction_ID
            // 
            colTransaction_ID.DataPropertyName = "Transaction_ID";
            colTransaction_ID.HeaderText = "Transaction_ID";
            colTransaction_ID.MinimumWidth = 6;
            colTransaction_ID.Name = "colTransaction_ID";
            colTransaction_ID.ReadOnly = true;
            colTransaction_ID.Visible = false;
            colTransaction_ID.Width = 125;
            // 
            // colUser_Name
            // 
            colUser_Name.DataPropertyName = "User_Name";
            colUser_Name.HeaderText = "المستخدم";
            colUser_Name.MinimumWidth = 6;
            colUser_Name.Name = "colUser_Name";
            colUser_Name.ReadOnly = true;
            colUser_Name.Width = 125;
            // 
            // colTime_Stamp
            // 
            colTime_Stamp.DataPropertyName = "Time_Stamp";
            colTime_Stamp.HeaderText = "الوقت";
            colTime_Stamp.MinimumWidth = 6;
            colTime_Stamp.Name = "colTime_Stamp";
            colTime_Stamp.ReadOnly = true;
            colTime_Stamp.Width = 125;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(522, 409);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ItemUnitStockDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(btnOK);
            Controls.Add(grdDetails);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemUnitStockDetailsForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل المخزون";
            ((System.ComponentModel.ISupportInitialize)grdDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdDetails;
        private DataGridViewTextBoxColumn colStock_ID;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colIn_QNT;
        private DataGridViewTextBoxColumn colOut_QNT;
        private DataGridViewTextBoxColumn colTransaction_Type_ID;
        private DataGridViewTextBoxColumn colTransaction_Type_Desc;
        private DataGridViewTextBoxColumn colTransaction_ID;
        private DataGridViewTextBoxColumn colUser_Name;
        private DataGridViewTextBoxColumn colTime_Stamp;
        private Button btnOK;
    }
}