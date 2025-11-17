namespace POS.Windows.Forms
{
    partial class SaleTransactionForm
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
            panel1 = new Panel();
            label9 = new Label();
            txtRemainAmount = new NumericUpDown();
            label8 = new Label();
            txtPaidAmountSum = new NumericUpDown();
            label7 = new Label();
            txtDiscount_Amount = new NumericUpDown();
            txtDelevery_Transaction_No = new TextBox();
            label6 = new Label();
            txtDelevery_Place = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtDelevery_Fees = new NumericUpDown();
            txtCustomerId = new MaskedTextBox();
            lblCustomerName = new TextBox();
            lblPerson = new Label();
            label4 = new Label();
            txtTotal_Amount = new NumericUpDown();
            label2 = new Label();
            txtTransactionDate = new DateTimePicker();
            grdItems = new DataGridView();
            colSale_Transaction_Item_ID = new DataGridViewTextBoxColumn();
            colSale_Transaction_ID = new DataGridViewTextBoxColumn();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colItem_Desc = new DataGridViewTextBoxColumn();
            colUnit_Desc = new DataGridViewTextBoxColumn();
            colQNT = new DataGridViewTextBoxColumn();
            colItem_Unit_Price = new DataGridViewTextBoxColumn();
            colItem_Total_Amount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRemainAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPaidAmountSum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDiscount_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDelevery_Fees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTotal_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDelevery_Transaction_No);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDelevery_Place);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDelevery_Fees);
            panel1.Controls.Add(txtCustomerId);
            panel1.Controls.Add(lblCustomerName);
            panel1.Controls.Add(lblPerson);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTransactionDate);
            panel1.Location = new Point(33, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 99);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(414, 602);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 53;
            label9.Text = "المتبقي";
            // 
            // txtRemainAmount
            // 
            txtRemainAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRemainAmount.Location = new Point(258, 600);
            txtRemainAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtRemainAmount.Name = "txtRemainAmount";
            txtRemainAmount.Size = new Size(150, 27);
            txtRemainAmount.TabIndex = 52;
            txtRemainAmount.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(414, 568);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 51;
            label8.Text = "المقبوض";
            // 
            // txtPaidAmountSum
            // 
            txtPaidAmountSum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPaidAmountSum.Location = new Point(258, 566);
            txtPaidAmountSum.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtPaidAmountSum.Name = "txtPaidAmountSum";
            txtPaidAmountSum.Size = new Size(150, 27);
            txtPaidAmountSum.TabIndex = 50;
            txtPaidAmountSum.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(176, 537);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 49;
            label7.Text = "الخصم";
            // 
            // txtDiscount_Amount
            // 
            txtDiscount_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDiscount_Amount.Location = new Point(63, 535);
            txtDiscount_Amount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtDiscount_Amount.Name = "txtDiscount_Amount";
            txtDiscount_Amount.Size = new Size(107, 27);
            txtDiscount_Amount.TabIndex = 48;
            txtDiscount_Amount.ThousandsSeparator = true;
            // 
            // txtDelevery_Transaction_No
            // 
            txtDelevery_Transaction_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDelevery_Transaction_No.BackColor = Color.White;
            txtDelevery_Transaction_No.Location = new Point(224, 52);
            txtDelevery_Transaction_No.Margin = new Padding(3, 4, 3, 4);
            txtDelevery_Transaction_No.Name = "txtDelevery_Transaction_No";
            txtDelevery_Transaction_No.ReadOnly = true;
            txtDelevery_Transaction_No.Size = new Size(236, 27);
            txtDelevery_Transaction_No.TabIndex = 47;
            txtDelevery_Transaction_No.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(460, 52);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 46;
            label6.Text = "رقم البوليصة";
            // 
            // txtDelevery_Place
            // 
            txtDelevery_Place.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDelevery_Place.BackColor = Color.White;
            txtDelevery_Place.Location = new Point(25, 17);
            txtDelevery_Place.Margin = new Padding(3, 4, 3, 4);
            txtDelevery_Place.Name = "txtDelevery_Place";
            txtDelevery_Place.ReadOnly = true;
            txtDelevery_Place.Size = new Size(236, 27);
            txtDelevery_Place.TabIndex = 45;
            txtDelevery_Place.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(261, 17);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 44;
            label5.Text = "مكان التوصيل";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(466, 17);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 43;
            label3.Text = "اجرة توصيل";
            // 
            // txtDelevery_Fees
            // 
            txtDelevery_Fees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDelevery_Fees.Location = new Point(368, 15);
            txtDelevery_Fees.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtDelevery_Fees.Name = "txtDelevery_Fees";
            txtDelevery_Fees.Size = new Size(92, 27);
            txtDelevery_Fees.TabIndex = 42;
            txtDelevery_Fees.ThousandsSeparator = true;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerId.Location = new Point(810, 52);
            txtCustomerId.Margin = new Padding(3, 4, 3, 4);
            txtCustomerId.Mask = "00000";
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(45, 27);
            txtCustomerId.TabIndex = 39;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerName.BackColor = Color.White;
            lblCustomerName.Location = new Point(568, 52);
            lblCustomerName.Margin = new Padding(3, 4, 3, 4);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.ReadOnly = true;
            lblCustomerName.Size = new Size(236, 27);
            lblCustomerName.TabIndex = 41;
            lblCustomerName.TabStop = false;
            // 
            // lblPerson
            // 
            lblPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(863, 52);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(47, 20);
            lblPerson.TabIndex = 38;
            lblPerson.Text = "الزبون";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(414, 535);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "المبلغ";
            // 
            // txtTotal_Amount
            // 
            txtTotal_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal_Amount.Location = new Point(258, 533);
            txtTotal_Amount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtTotal_Amount.Name = "txtTotal_Amount";
            txtTotal_Amount.Size = new Size(150, 27);
            txtTotal_Amount.TabIndex = 9;
            txtTotal_Amount.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(861, 15);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 8;
            label2.Text = "التاريخ";
            // 
            // txtTransactionDate
            // 
            txtTransactionDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransactionDate.Checked = false;
            txtTransactionDate.CustomFormat = "dd/MM/yyyy";
            txtTransactionDate.Format = DateTimePickerFormat.Custom;
            txtTransactionDate.Location = new Point(708, 14);
            txtTransactionDate.Name = "txtTransactionDate";
            txtTransactionDate.ShowCheckBox = true;
            txtTransactionDate.Size = new Size(147, 27);
            txtTransactionDate.TabIndex = 7;
            // 
            // grdItems
            // 
            grdItems.AllowUserToAddRows = false;
            grdItems.AllowUserToDeleteRows = false;
            grdItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItems.Columns.AddRange(new DataGridViewColumn[] { colSale_Transaction_Item_ID, colSale_Transaction_ID, colItem_Unit_ID, colItem_Desc, colUnit_Desc, colQNT, colItem_Unit_Price, colItem_Total_Amount });
            grdItems.Location = new Point(33, 189);
            grdItems.Name = "grdItems";
            grdItems.ReadOnly = true;
            grdItems.RowHeadersWidth = 51;
            grdItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItems.Size = new Size(925, 329);
            grdItems.TabIndex = 1;
            // 
            // colSale_Transaction_Item_ID
            // 
            colSale_Transaction_Item_ID.DataPropertyName = "Sale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.HeaderText = "Sale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.MinimumWidth = 6;
            colSale_Transaction_Item_ID.Name = "colSale_Transaction_Item_ID";
            colSale_Transaction_Item_ID.ReadOnly = true;
            colSale_Transaction_Item_ID.Visible = false;
            colSale_Transaction_Item_ID.Width = 125;
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
            colItem_Desc.Width = 300;
            // 
            // colUnit_Desc
            // 
            colUnit_Desc.DataPropertyName = "Unit_Desc";
            colUnit_Desc.HeaderText = "الوحدة";
            colUnit_Desc.MinimumWidth = 6;
            colUnit_Desc.Name = "colUnit_Desc";
            colUnit_Desc.ReadOnly = true;
            colUnit_Desc.Width = 125;
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
            // colItem_Unit_Price
            // 
            colItem_Unit_Price.DataPropertyName = "Item_Unit_Price";
            colItem_Unit_Price.HeaderText = "السعر";
            colItem_Unit_Price.MinimumWidth = 6;
            colItem_Unit_Price.Name = "colItem_Unit_Price";
            colItem_Unit_Price.ReadOnly = true;
            colItem_Unit_Price.Width = 125;
            // 
            // colItem_Total_Amount
            // 
            colItem_Total_Amount.DataPropertyName = "Item_Total_Amount";
            colItem_Total_Amount.HeaderText = "المبلغ";
            colItem_Total_Amount.MinimumWidth = 6;
            colItem_Total_Amount.Name = "colItem_Total_Amount";
            colItem_Total_Amount.ReadOnly = true;
            colItem_Total_Amount.Width = 125;
            // 
            // SaleTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 641);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(txtDiscount_Amount);
            Controls.Add(grdItems);
            Controls.Add(txtRemainAmount);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtTotal_Amount);
            Controls.Add(txtPaidAmountSum);
            Controls.Add(label4);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaleTransactionForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حركة البيع";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtRemainAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPaidAmountSum).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDiscount_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDelevery_Fees).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTotal_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private NumericUpDown txtTotal_Amount;
        private Label label2;
        private DateTimePicker txtTransactionDate;
        private MaskedTextBox txtCustomerId;
        private TextBox lblCustomerName;
        private Label lblPerson;
        private Label label3;
        private NumericUpDown txtDelevery_Fees;
        private TextBox txtDelevery_Place;
        private Label label5;
        private TextBox txtDelevery_Transaction_No;
        private Label label6;
        private Label label7;
        private NumericUpDown txtDiscount_Amount;
        private Label label8;
        private NumericUpDown txtPaidAmountSum;
        private Label label9;
        private NumericUpDown txtRemainAmount;
        private DataGridView grdItems;
        private DataGridViewTextBoxColumn colSale_Transaction_Item_ID;
        private DataGridViewTextBoxColumn colSale_Transaction_ID;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colItem_Desc;
        private DataGridViewTextBoxColumn colUnit_Desc;
        private DataGridViewTextBoxColumn colQNT;
        private DataGridViewTextBoxColumn colItem_Unit_Price;
        private DataGridViewTextBoxColumn colItem_Total_Amount;
    }
}