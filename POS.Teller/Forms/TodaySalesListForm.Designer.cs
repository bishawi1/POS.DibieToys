namespace POS.Windows.Forms
{
    partial class TodaySalesListForm
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
            grdSales = new DataGridView();
            toolStrip1 = new ToolStrip();
            tsbtnEditSaleTransaction = new ToolStripButton();
            colSale_Transaction_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_No = new DataGridViewTextBoxColumn();
            colTeller_ID = new DataGridViewTextBoxColumn();
            colTeller_Name = new DataGridViewTextBoxColumn();
            colTransaction_Date = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colTransaction_Notes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdSales).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdSales
            // 
            grdSales.AllowUserToAddRows = false;
            grdSales.AllowUserToDeleteRows = false;
            grdSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSales.Columns.AddRange(new DataGridViewColumn[] { colSale_Transaction_ID, colSale_Transaction_No, colTeller_ID, colTeller_Name, colTransaction_Date, colAmount, colTransaction_Notes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdSales.DefaultCellStyle = dataGridViewCellStyle2;
            grdSales.Location = new Point(19, 70);
            grdSales.Name = "grdSales";
            grdSales.ReadOnly = true;
            grdSales.RowHeadersWidth = 51;
            grdSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSales.Size = new Size(561, 353);
            grdSales.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnEditSaleTransaction });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(603, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnEditSaleTransaction
            // 
            tsbtnEditSaleTransaction.Image = Properties.Resources.EditRecord;
            tsbtnEditSaleTransaction.ImageTransparentColor = Color.Magenta;
            tsbtnEditSaleTransaction.Name = "tsbtnEditSaleTransaction";
            tsbtnEditSaleTransaction.Size = new Size(98, 52);
            tsbtnEditSaleTransaction.Text = "تعديل";
            tsbtnEditSaleTransaction.Click += tsbtnEditSaleTransaction_Click;
            // 
            // colSale_Transaction_ID
            // 
            colSale_Transaction_ID.DataPropertyName = "Sale_Transaction_ID";
            colSale_Transaction_ID.HeaderText = "Sale_Transaction_ID";
            colSale_Transaction_ID.MinimumWidth = 6;
            colSale_Transaction_ID.Name = "colSale_Transaction_ID";
            colSale_Transaction_ID.ReadOnly = true;
            colSale_Transaction_ID.Visible = false;
            colSale_Transaction_ID.Width = 125;
            // 
            // colSale_Transaction_No
            // 
            colSale_Transaction_No.DataPropertyName = "Sale_Transaction_No";
            colSale_Transaction_No.HeaderText = "رقم الحركة";
            colSale_Transaction_No.MinimumWidth = 6;
            colSale_Transaction_No.Name = "colSale_Transaction_No";
            colSale_Transaction_No.ReadOnly = true;
            colSale_Transaction_No.Visible = false;
            colSale_Transaction_No.Width = 125;
            // 
            // colTeller_ID
            // 
            colTeller_ID.DataPropertyName = "Teller_ID";
            colTeller_ID.HeaderText = "Teller_ID";
            colTeller_ID.MinimumWidth = 6;
            colTeller_ID.Name = "colTeller_ID";
            colTeller_ID.ReadOnly = true;
            colTeller_ID.Visible = false;
            colTeller_ID.Width = 125;
            // 
            // colTeller_Name
            // 
            colTeller_Name.DataPropertyName = "Teller_Name";
            colTeller_Name.HeaderText = "نقطة البيع";
            colTeller_Name.MinimumWidth = 6;
            colTeller_Name.Name = "colTeller_Name";
            colTeller_Name.ReadOnly = true;
            colTeller_Name.Visible = false;
            colTeller_Name.Width = 125;
            // 
            // colTransaction_Date
            // 
            colTransaction_Date.DataPropertyName = "Transaction_Date";
            colTransaction_Date.HeaderText = "التاريخ";
            colTransaction_Date.MinimumWidth = 6;
            colTransaction_Date.Name = "colTransaction_Date";
            colTransaction_Date.ReadOnly = true;
            colTransaction_Date.Width = 200;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            colAmount.HeaderText = "المبلغ";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 125;
            // 
            // colTransaction_Notes
            // 
            colTransaction_Notes.DataPropertyName = "Transaction_Notes";
            colTransaction_Notes.HeaderText = "ملاحظات";
            colTransaction_Notes.MinimumWidth = 6;
            colTransaction_Notes.Name = "colTransaction_Notes";
            colTransaction_Notes.ReadOnly = true;
            colTransaction_Notes.Width = 125;
            // 
            // TodaySalesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(toolStrip1);
            Controls.Add(grdSales);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TodaySalesListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مبيعات اليوم";
            ((System.ComponentModel.ISupportInitialize)grdSales).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSales;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnEditSaleTransaction;
        private DataGridViewTextBoxColumn colSale_Transaction_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_No;
        private DataGridViewTextBoxColumn colTeller_ID;
        private DataGridViewTextBoxColumn colTeller_Name;
        private DataGridViewTextBoxColumn colTransaction_Date;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colTransaction_Notes;
    }
}