namespace POS.Windows.Forms
{
    partial class TicketListForm
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
            panel1 = new Panel();
            btnApplySearch = new Button();
            label1 = new Label();
            txtToTicketDate = new DateTimePicker();
            label6 = new Label();
            txtFromTicketDate = new DateTimePicker();
            grdTicketList = new DataGridView();
            colTicket_ID = new DataGridViewTextBoxColumn();
            colTicket_Date = new DataGridViewTextBoxColumn();
            colBatch_No = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDiscount = new DataGridViewTextBoxColumn();
            colKids_Count = new DataGridViewTextBoxColumn();
            colTicket_No = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTicketList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnApplySearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtToTicketDate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFromTicketDate);
            panel1.Location = new Point(57, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 74);
            panel1.TabIndex = 0;
            // 
            // btnApplySearch
            // 
            btnApplySearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApplySearch.Location = new Point(20, 17);
            btnApplySearch.Name = "btnApplySearch";
            btnApplySearch.Size = new Size(126, 29);
            btnApplySearch.TabIndex = 53;
            btnApplySearch.Text = "بحث";
            btnApplySearch.UseVisualStyleBackColor = true;
            btnApplySearch.Click += btnApplySearch_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(349, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 52;
            label1.Text = "الى";
            // 
            // txtToTicketDate
            // 
            txtToTicketDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtToTicketDate.CustomFormat = "dd/MM/yyyy";
            txtToTicketDate.Format = DateTimePickerFormat.Custom;
            txtToTicketDate.Location = new Point(184, 17);
            txtToTicketDate.Name = "txtToTicketDate";
            txtToTicketDate.ShowCheckBox = true;
            txtToTicketDate.Size = new Size(159, 27);
            txtToTicketDate.TabIndex = 51;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(569, 16);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 50;
            label6.Text = "التاريخ   من";
            // 
            // txtFromTicketDate
            // 
            txtFromTicketDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFromTicketDate.CustomFormat = "dd/MM/yyyy";
            txtFromTicketDate.Format = DateTimePickerFormat.Custom;
            txtFromTicketDate.Location = new Point(400, 16);
            txtFromTicketDate.Name = "txtFromTicketDate";
            txtFromTicketDate.ShowCheckBox = true;
            txtFromTicketDate.Size = new Size(159, 27);
            txtFromTicketDate.TabIndex = 49;
            // 
            // grdTicketList
            // 
            grdTicketList.AllowUserToAddRows = false;
            grdTicketList.AllowUserToDeleteRows = false;
            grdTicketList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTicketList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTicketList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTicketList.Columns.AddRange(new DataGridViewColumn[] { colTicket_ID, colTicket_Date, colBatch_No, colAmount, colDiscount, colKids_Count, colTicket_No });
            grdTicketList.Location = new Point(26, 116);
            grdTicketList.Name = "grdTicketList";
            grdTicketList.ReadOnly = true;
            grdTicketList.RowHeadersWidth = 51;
            grdTicketList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTicketList.Size = new Size(701, 463);
            grdTicketList.TabIndex = 1;
            // 
            // colTicket_ID
            // 
            colTicket_ID.DataPropertyName = "Ticket_ID";
            colTicket_ID.HeaderText = "Ticket_ID";
            colTicket_ID.MinimumWidth = 6;
            colTicket_ID.Name = "colTicket_ID";
            colTicket_ID.ReadOnly = true;
            colTicket_ID.Visible = false;
            colTicket_ID.Width = 125;
            // 
            // colTicket_Date
            // 
            colTicket_Date.DataPropertyName = "Ticket_Date";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colTicket_Date.DefaultCellStyle = dataGridViewCellStyle2;
            colTicket_Date.HeaderText = "التاريخ";
            colTicket_Date.MinimumWidth = 6;
            colTicket_Date.Name = "colTicket_Date";
            colTicket_Date.ReadOnly = true;
            colTicket_Date.Width = 125;
            // 
            // colBatch_No
            // 
            colBatch_No.DataPropertyName = "Batch_No";
            colBatch_No.HeaderText = "الحزمة";
            colBatch_No.MinimumWidth = 6;
            colBatch_No.Name = "colBatch_No";
            colBatch_No.ReadOnly = true;
            colBatch_No.Visible = false;
            colBatch_No.Width = 125;
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
            // colDiscount
            // 
            colDiscount.DataPropertyName = "Discount";
            colDiscount.HeaderText = "خصم";
            colDiscount.MinimumWidth = 6;
            colDiscount.Name = "colDiscount";
            colDiscount.ReadOnly = true;
            colDiscount.Width = 125;
            // 
            // colKids_Count
            // 
            colKids_Count.DataPropertyName = "Kids_Count";
            colKids_Count.HeaderText = "العدد";
            colKids_Count.MinimumWidth = 6;
            colKids_Count.Name = "colKids_Count";
            colKids_Count.ReadOnly = true;
            colKids_Count.Visible = false;
            colKids_Count.Width = 125;
            // 
            // colTicket_No
            // 
            colTicket_No.DataPropertyName = "Ticket_No";
            colTicket_No.HeaderText = "رقم التذكرة";
            colTicket_No.MinimumWidth = 6;
            colTicket_No.Name = "colTicket_No";
            colTicket_No.ReadOnly = true;
            colTicket_No.Width = 125;
            // 
            // TicketListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 610);
            Controls.Add(grdTicketList);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "TicketListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة التذاكر";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTicketList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grdTicketList;
        private Label label1;
        private DateTimePicker txtToTicketDate;
        private Label label6;
        private DateTimePicker txtFromTicketDate;
        private Button btnApplySearch;
        private DataGridViewTextBoxColumn colTicket_ID;
        private DataGridViewTextBoxColumn colTicket_Date;
        private DataGridViewTextBoxColumn colBatch_No;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colKids_Count;
        private DataGridViewTextBoxColumn colTicket_No;
    }
}