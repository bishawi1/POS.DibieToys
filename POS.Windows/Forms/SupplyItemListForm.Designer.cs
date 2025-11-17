namespace POS.Windows.Forms
{
    partial class SupplyItemListForm
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
            btnGetData = new Button();
            panel1 = new Panel();
            cmbBranch_ID = new ComboBox();
            txtTo_Transaction_Date = new DateTimePicker();
            label3 = new Label();
            btnShow_Item_Unit_ID_LOV = new Button();
            txtQNT = new MaskedTextBox();
            txtItem_Unit_ID = new MaskedTextBox();
            txtItem_Desc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtSupply_Transaction_ID = new TextBox();
            label1 = new Label();
            label10 = new Label();
            txtFrom_Transaction_Date = new DateTimePicker();
            txtSource_Name = new TextBox();
            label2 = new Label();
            txtSource_ID = new MaskedTextBox();
            btnShow_Book_Source_ID_LOV = new Button();
            grdTransactionList = new DataGridView();
            colSupply_Transaction_ID = new DataGridViewTextBoxColumn();
            colSource_ID = new DataGridViewTextBoxColumn();
            colTransaction_Date = new DataGridViewTextBoxColumn();
            colBook_Source_Desc = new DataGridViewTextBoxColumn();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colItem_Desc = new DataGridViewTextBoxColumn();
            colQNT = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewCheckBoxColumn();
            colTransaction_Notes = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            tsbtnNew = new ToolStripButton();
            tsbtnDetails = new ToolStripButton();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTransactionList).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(73, 90);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(111, 29);
            btnGetData.TabIndex = 0;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbBranch_ID);
            panel1.Controls.Add(txtTo_Transaction_Date);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnShow_Item_Unit_ID_LOV);
            panel1.Controls.Add(txtQNT);
            panel1.Controls.Add(btnGetData);
            panel1.Controls.Add(txtItem_Unit_ID);
            panel1.Controls.Add(txtItem_Desc);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSupply_Transaction_ID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtFrom_Transaction_Date);
            panel1.Controls.Add(txtSource_Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSource_ID);
            panel1.Controls.Add(btnShow_Book_Source_ID_LOV);
            panel1.Location = new Point(206, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 136);
            panel1.TabIndex = 1;
            // 
            // cmbBranch_ID
            // 
            cmbBranch_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch_ID.FormattingEnabled = true;
            cmbBranch_ID.Location = new Point(82, 16);
            cmbBranch_ID.Name = "cmbBranch_ID";
            cmbBranch_ID.Size = new Size(227, 28);
            cmbBranch_ID.TabIndex = 58;
            // 
            // txtTo_Transaction_Date
            // 
            txtTo_Transaction_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTo_Transaction_Date.CustomFormat = "dd/MM/yyyy";
            txtTo_Transaction_Date.Format = DateTimePickerFormat.Custom;
            txtTo_Transaction_Date.Location = new Point(376, 54);
            txtTo_Transaction_Date.Name = "txtTo_Transaction_Date";
            txtTo_Transaction_Date.ShowCheckBox = true;
            txtTo_Transaction_Date.Size = new Size(140, 27);
            txtTo_Transaction_Date.TabIndex = 56;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(524, 56);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 57;
            label3.Text = "الى";
            // 
            // btnShow_Item_Unit_ID_LOV
            // 
            btnShow_Item_Unit_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Unit_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Unit_ID_LOV.Location = new Point(646, 88);
            btnShow_Item_Unit_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Unit_ID_LOV.Name = "btnShow_Item_Unit_ID_LOV";
            btnShow_Item_Unit_ID_LOV.Size = new Size(31, 31);
            btnShow_Item_Unit_ID_LOV.TabIndex = 52;
            btnShow_Item_Unit_ID_LOV.TabStop = false;
            btnShow_Item_Unit_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Unit_ID_LOV.Click += btnShow_Item_Unit_ID_LOV_Click;
            // 
            // txtQNT
            // 
            txtQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQNT.Location = new Point(648, 16);
            txtQNT.Margin = new Padding(3, 4, 3, 4);
            txtQNT.Mask = "00000";
            txtQNT.Name = "txtQNT";
            txtQNT.Size = new Size(67, 27);
            txtQNT.TabIndex = 55;
            txtQNT.Text = "0";
            // 
            // txtItem_Unit_ID
            // 
            txtItem_Unit_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_ID.Location = new Point(679, 88);
            txtItem_Unit_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_ID.Mask = "00000";
            txtItem_Unit_ID.Name = "txtItem_Unit_ID";
            txtItem_Unit_ID.Size = new Size(34, 27);
            txtItem_Unit_ID.TabIndex = 51;
            txtItem_Unit_ID.Text = "0";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.BackColor = Color.White;
            txtItem_Desc.Location = new Point(376, 88);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.ReadOnly = true;
            txtItem_Desc.Size = new Size(267, 27);
            txtItem_Desc.TabIndex = 53;
            txtItem_Desc.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(749, 16);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 54;
            label5.Text = "الكمية";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(720, 88);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 50;
            label4.Text = "الصنف";
            // 
            // txtSupply_Transaction_ID
            // 
            txtSupply_Transaction_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupply_Transaction_ID.Location = new Point(393, 17);
            txtSupply_Transaction_ID.Name = "txtSupply_Transaction_ID";
            txtSupply_Transaction_ID.Size = new Size(125, 27);
            txtSupply_Transaction_ID.TabIndex = 43;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(524, 16);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 42;
            label1.Text = "الرمز";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(314, 56);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 44;
            label10.Text = "المصدر";
            // 
            // txtFrom_Transaction_Date
            // 
            txtFrom_Transaction_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFrom_Transaction_Date.CustomFormat = "dd/MM/yyyy";
            txtFrom_Transaction_Date.Format = DateTimePickerFormat.Custom;
            txtFrom_Transaction_Date.Location = new Point(575, 54);
            txtFrom_Transaction_Date.Name = "txtFrom_Transaction_Date";
            txtFrom_Transaction_Date.ShowCheckBox = true;
            txtFrom_Transaction_Date.Size = new Size(140, 27);
            txtFrom_Transaction_Date.TabIndex = 48;
            // 
            // txtSource_Name
            // 
            txtSource_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_Name.BackColor = Color.White;
            txtSource_Name.Location = new Point(20, 56);
            txtSource_Name.Margin = new Padding(3, 4, 3, 4);
            txtSource_Name.Name = "txtSource_Name";
            txtSource_Name.ReadOnly = true;
            txtSource_Name.Size = new Size(217, 27);
            txtSource_Name.TabIndex = 47;
            txtSource_Name.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(721, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 49;
            label2.Text = "التاريخ   من";
            // 
            // txtSource_ID
            // 
            txtSource_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_ID.Location = new Point(273, 56);
            txtSource_ID.Margin = new Padding(3, 4, 3, 4);
            txtSource_ID.Mask = "00000";
            txtSource_ID.Name = "txtSource_ID";
            txtSource_ID.Size = new Size(34, 27);
            txtSource_ID.TabIndex = 45;
            txtSource_ID.Text = "0";
            // 
            // btnShow_Book_Source_ID_LOV
            // 
            btnShow_Book_Source_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Source_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Source_ID_LOV.Location = new Point(240, 56);
            btnShow_Book_Source_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Source_ID_LOV.Name = "btnShow_Book_Source_ID_LOV";
            btnShow_Book_Source_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Source_ID_LOV.TabIndex = 46;
            btnShow_Book_Source_ID_LOV.TabStop = false;
            btnShow_Book_Source_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Source_ID_LOV.Click += btnShow_Book_Source_ID_LOV_Click;
            // 
            // grdTransactionList
            // 
            grdTransactionList.AllowUserToAddRows = false;
            grdTransactionList.AllowUserToDeleteRows = false;
            grdTransactionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTransactionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTransactionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTransactionList.Columns.AddRange(new DataGridViewColumn[] { colSupply_Transaction_ID, colSource_ID, colTransaction_Date, colBook_Source_Desc, colItem_Unit_ID, colItem_Desc, colQNT, colIsActive, colTransaction_Notes });
            grdTransactionList.Location = new Point(12, 214);
            grdTransactionList.Name = "grdTransactionList";
            grdTransactionList.ReadOnly = true;
            grdTransactionList.RowHeadersWidth = 51;
            grdTransactionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTransactionList.Size = new Size(1007, 346);
            grdTransactionList.TabIndex = 2;
            // 
            // colSupply_Transaction_ID
            // 
            colSupply_Transaction_ID.DataPropertyName = "Supply_Transaction_ID";
            colSupply_Transaction_ID.HeaderText = "Supply_Transaction_ID";
            colSupply_Transaction_ID.MinimumWidth = 6;
            colSupply_Transaction_ID.Name = "colSupply_Transaction_ID";
            colSupply_Transaction_ID.ReadOnly = true;
            colSupply_Transaction_ID.Visible = false;
            colSupply_Transaction_ID.Width = 125;
            // 
            // colSource_ID
            // 
            colSource_ID.DataPropertyName = "Source_ID";
            colSource_ID.HeaderText = "Source_ID";
            colSource_ID.MinimumWidth = 6;
            colSource_ID.Name = "colSource_ID";
            colSource_ID.ReadOnly = true;
            colSource_ID.Visible = false;
            colSource_ID.Width = 125;
            // 
            // colTransaction_Date
            // 
            colTransaction_Date.DataPropertyName = "Transaction_Date";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colTransaction_Date.DefaultCellStyle = dataGridViewCellStyle2;
            colTransaction_Date.HeaderText = "التاريخ";
            colTransaction_Date.MinimumWidth = 6;
            colTransaction_Date.Name = "colTransaction_Date";
            colTransaction_Date.ReadOnly = true;
            colTransaction_Date.Width = 125;
            // 
            // colBook_Source_Desc
            // 
            colBook_Source_Desc.DataPropertyName = "Book_Source_Desc";
            colBook_Source_Desc.HeaderText = "المصدر";
            colBook_Source_Desc.MinimumWidth = 6;
            colBook_Source_Desc.Name = "colBook_Source_Desc";
            colBook_Source_Desc.ReadOnly = true;
            colBook_Source_Desc.Width = 200;
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
            // colItem_Desc
            // 
            colItem_Desc.DataPropertyName = "Item_Desc";
            colItem_Desc.HeaderText = "الصنف";
            colItem_Desc.MinimumWidth = 6;
            colItem_Desc.Name = "colItem_Desc";
            colItem_Desc.ReadOnly = true;
            colItem_Desc.Width = 250;
            // 
            // colQNT
            // 
            colQNT.DataPropertyName = "QNT";
            colQNT.HeaderText = "الكمية";
            colQNT.MinimumWidth = 6;
            colQNT.Name = "colQNT";
            colQNT.ReadOnly = true;
            colQNT.Width = 125;
            // 
            // colIsActive
            // 
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "فعال؟";
            colIsActive.MinimumWidth = 6;
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            colIsActive.Width = 125;
            // 
            // colTransaction_Notes
            // 
            colTransaction_Notes.DataPropertyName = "Transaction_Notes";
            colTransaction_Notes.HeaderText = "ملاحظات";
            colTransaction_Notes.MinimumWidth = 6;
            colTransaction_Notes.Name = "colTransaction_Notes";
            colTransaction_Notes.ReadOnly = true;
            colTransaction_Notes.Resizable = DataGridViewTriState.True;
            colTransaction_Notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTransaction_Notes.Width = 200;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNew, tsbtnDetails });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1031, 55);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            tsbtnNew.Image = Properties.Resources.Add_Order;
            tsbtnNew.ImageTransparentColor = Color.Magenta;
            tsbtnNew.Name = "tsbtnNew";
            tsbtnNew.Size = new Size(91, 52);
            tsbtnNew.Text = "جديد";
            tsbtnNew.Click += tsbtnNew_Click;
            // 
            // tsbtnDetails
            // 
            tsbtnDetails.Image = Properties.Resources.EditRecord;
            tsbtnDetails.ImageTransparentColor = Color.Magenta;
            tsbtnDetails.Name = "tsbtnDetails";
            tsbtnDetails.Size = new Size(108, 52);
            tsbtnDetails.Text = "تفاصيل";
            tsbtnDetails.Click += tsbtnDetails_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(315, 16);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 59;
            label6.Text = "الفرع";
            // 
            // SupplyItemListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 587);
            Controls.Add(toolStrip1);
            Controls.Add(grdTransactionList);
            Controls.Add(panel1);
            Name = "SupplyItemListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "توريد الاصناف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTransactionList).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetData;
        private Panel panel1;
        private DataGridView grdTransactionList;
        private DataGridViewTextBoxColumn colSupply_Transaction_ID;
        private DataGridViewTextBoxColumn colSource_ID;
        private DataGridViewTextBoxColumn colTransaction_Date;
        private DataGridViewTextBoxColumn colBook_Source_Desc;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colItem_Desc;
        private DataGridViewTextBoxColumn colQNT;
        private DataGridViewCheckBoxColumn colIsActive;
        private DataGridViewTextBoxColumn colTransaction_Notes;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNew;
        private ToolStripButton tsbtnDetails;
        private DateTimePicker txtTo_Transaction_Date;
        private Label label3;
        private Button btnShow_Item_Unit_ID_LOV;
        private MaskedTextBox txtQNT;
        private MaskedTextBox txtItem_Unit_ID;
        private TextBox txtItem_Desc;
        private Label label5;
        private Label label4;
        private TextBox txtSupply_Transaction_ID;
        private Label label1;
        private Label label10;
        private DateTimePicker txtFrom_Transaction_Date;
        private TextBox txtSource_Name;
        private Label label2;
        private MaskedTextBox txtSource_ID;
        private Button btnShow_Book_Source_ID_LOV;
        private ComboBox cmbBranch_ID;
        private Label label6;
    }
}