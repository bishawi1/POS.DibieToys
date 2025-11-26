namespace POS.Windows.Forms
{
    partial class ReservToysRoomListForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbtnNew_Item = new ToolStripButton();
            tsbtnShowItemDetails = new ToolStripButton();
            panel1 = new Panel();
            label2 = new Label();
            txtReserver_Name = new TextBox();
            label1 = new Label();
            cmbStatus = new ComboBox();
            btnGetData = new Button();
            grdLIst = new DataGridView();
            colReserve_Toy_Room_ID = new DataGridViewTextBoxColumn();
            colKids_No = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colReserver_Name = new DataGridViewTextBoxColumn();
            colDue_Date = new DataGridViewTextBoxColumn();
            colDone = new DataGridViewCheckBoxColumn();
            colCanceled = new DataGridViewCheckBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLIst).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNew_Item, tsbtnShowItemDetails });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1064, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew_Item
            // 
            tsbtnNew_Item.Image = Properties.Resources.Add_Order;
            tsbtnNew_Item.ImageTransparentColor = Color.Magenta;
            tsbtnNew_Item.Name = "tsbtnNew_Item";
            tsbtnNew_Item.Size = new Size(91, 52);
            tsbtnNew_Item.Text = "جديد";
            tsbtnNew_Item.Click += tsbtnNew_Item_Click;
            // 
            // tsbtnShowItemDetails
            // 
            tsbtnShowItemDetails.Image = Properties.Resources.EditRecord;
            tsbtnShowItemDetails.ImageTransparentColor = Color.Magenta;
            tsbtnShowItemDetails.Name = "tsbtnShowItemDetails";
            tsbtnShowItemDetails.Size = new Size(108, 52);
            tsbtnShowItemDetails.Text = "تفاصيل";
            tsbtnShowItemDetails.Click += tsbtnShowItemDetails_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtReserver_Name);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(btnGetData);
            panel1.Location = new Point(453, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 103);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(482, 14);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "الحالة";
            // 
            // txtReserver_Name
            // 
            txtReserver_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtReserver_Name.Location = new Point(118, 54);
            txtReserver_Name.Name = "txtReserver_Name";
            txtReserver_Name.Size = new Size(358, 27);
            txtReserver_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(482, 54);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "طالب الحجز";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "الجميع", "بالانتظار", "المنجز", "الملغي" });
            cmbStatus.Location = new Point(325, 14);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 1;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.Location = new Point(18, 54);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(94, 29);
            btnGetData.TabIndex = 0;
            btnGetData.Text = "بحث";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // grdLIst
            // 
            grdLIst.AllowUserToAddRows = false;
            grdLIst.AllowUserToDeleteRows = false;
            grdLIst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdLIst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdLIst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLIst.Columns.AddRange(new DataGridViewColumn[] { colReserve_Toy_Room_ID, colKids_No, colAmount, colReserver_Name, colDue_Date, colDone, colCanceled, colNotes });
            grdLIst.Location = new Point(23, 190);
            grdLIst.Name = "grdLIst";
            grdLIst.ReadOnly = true;
            grdLIst.RowHeadersWidth = 51;
            grdLIst.Size = new Size(1029, 425);
            grdLIst.TabIndex = 3;
            // 
            // colReserve_Toy_Room_ID
            // 
            colReserve_Toy_Room_ID.DataPropertyName = "Reserve_Toy_Room_ID";
            colReserve_Toy_Room_ID.HeaderText = "Reserve_Toy_Room_ID";
            colReserve_Toy_Room_ID.MinimumWidth = 6;
            colReserve_Toy_Room_ID.Name = "colReserve_Toy_Room_ID";
            colReserve_Toy_Room_ID.ReadOnly = true;
            colReserve_Toy_Room_ID.Visible = false;
            colReserve_Toy_Room_ID.Width = 125;
            // 
            // colKids_No
            // 
            colKids_No.DataPropertyName = "Kids_No";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            colKids_No.DefaultCellStyle = dataGridViewCellStyle2;
            colKids_No.HeaderText = "العدد";
            colKids_No.MinimumWidth = 6;
            colKids_No.Name = "colKids_No";
            colKids_No.ReadOnly = true;
            colKids_No.Width = 125;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colAmount.DefaultCellStyle = dataGridViewCellStyle3;
            colAmount.HeaderText = "المبلغ";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 125;
            // 
            // colReserver_Name
            // 
            colReserver_Name.DataPropertyName = "Reserver_Name";
            colReserver_Name.HeaderText = "طالب الحجز";
            colReserver_Name.MinimumWidth = 6;
            colReserver_Name.Name = "colReserver_Name";
            colReserver_Name.ReadOnly = true;
            colReserver_Name.Width = 200;
            // 
            // colDue_Date
            // 
            colDue_Date.DataPropertyName = "Due_Date";
            colDue_Date.HeaderText = "تاريخ الحجز";
            colDue_Date.MinimumWidth = 6;
            colDue_Date.Name = "colDue_Date";
            colDue_Date.ReadOnly = true;
            colDue_Date.Width = 125;
            // 
            // colDone
            // 
            colDone.DataPropertyName = "Done";
            colDone.HeaderText = "تم";
            colDone.MinimumWidth = 6;
            colDone.Name = "colDone";
            colDone.ReadOnly = true;
            colDone.Width = 50;
            // 
            // colCanceled
            // 
            colCanceled.DataPropertyName = "Canceled";
            colCanceled.HeaderText = "ملغي";
            colCanceled.MinimumWidth = 6;
            colCanceled.Name = "colCanceled";
            colCanceled.ReadOnly = true;
            colCanceled.Width = 50;
            // 
            // colNotes
            // 
            colNotes.DataPropertyName = "Notes";
            colNotes.HeaderText = "ملاحظات";
            colNotes.MinimumWidth = 6;
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            colNotes.Width = 150;
            // 
            // ReservToysRoomListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 627);
            Controls.Add(grdLIst);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Name = "ReservToysRoomListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حجز قاعة الالعاب";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLIst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNew_Item;
        private ToolStripButton tsbtnShowItemDetails;
        private Panel panel1;
        private Button btnGetData;
        private DataGridView grdLIst;
        private DataGridViewTextBoxColumn colReserve_Toy_Room_ID;
        private DataGridViewTextBoxColumn colKids_No;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colReserver_Name;
        private DataGridViewTextBoxColumn colDue_Date;
        private DataGridViewCheckBoxColumn colDone;
        private DataGridViewCheckBoxColumn colCanceled;
        private DataGridViewTextBoxColumn colNotes;
        private ComboBox cmbStatus;
        private TextBox txtReserver_Name;
        private Label label1;
        private Label label2;
    }
}