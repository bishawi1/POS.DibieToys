namespace POS.Windows.Forms.Books
{
    partial class BookListForm
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
            panel1 = new Panel();
            txtBarcode = new TextBox();
            label11 = new Label();
            txtToBookPrice = new MaskedTextBox();
            label9 = new Label();
            txtFromBookPrice = new MaskedTextBox();
            label10 = new Label();
            txtToRemainQNT = new MaskedTextBox();
            label7 = new Label();
            txtFromRemainQNT = new MaskedTextBox();
            label6 = new Label();
            btnShow_Book_Publisher_ID_LOV = new Button();
            txtBook_Publisher_ID = new MaskedTextBox();
            txtPublisher_Desc = new TextBox();
            label4 = new Label();
            btnShow_Book_Author_ID_LOV = new Button();
            txtBook_Author_ID = new MaskedTextBox();
            txtBook_Author_Desc = new TextBox();
            label5 = new Label();
            btnShow_Book_Subject_ID_LOV = new Button();
            txtBook_Subject_ID = new MaskedTextBox();
            txtBook_Subject_Desc = new TextBox();
            label8 = new Label();
            txtBook_Title = new TextBox();
            label3 = new Label();
            txtBook_ID = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            toolStrip1 = new ToolStrip();
            tsbtnNew = new ToolStripButton();
            tsbtnEdit = new ToolStripButton();
            tsbtnBeginingQnt = new ToolStripButton();
            grdBookList = new DataGridView();
            colBook_ID = new DataGridViewTextBoxColumn();
            colItem_ID = new DataGridViewTextBoxColumn();
            colItem_Unit_ID = new DataGridViewTextBoxColumn();
            colBook_Author_ID = new DataGridViewTextBoxColumn();
            colBook_Title = new DataGridViewTextBoxColumn();
            colBook_Author_Desc = new DataGridViewTextBoxColumn();
            colBook_Cat_ID = new DataGridViewTextBoxColumn();
            colBook_Cat_Desc = new DataGridViewTextBoxColumn();
            colBook_Subject_ID = new DataGridViewTextBoxColumn();
            colBook_Subject_Desc = new DataGridViewTextBoxColumn();
            colBook_Publisher_ID = new DataGridViewTextBoxColumn();
            colPublisher_Desc = new DataGridViewTextBoxColumn();
            colItem_Unit_Price = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colItem_Unit_Cost = new DataGridViewTextBoxColumn();
            colRemainQNT = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtRecordCount = new TextBox();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdBookList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtToBookPrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtFromBookPrice);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtToRemainQNT);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtFromRemainQNT);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnShow_Book_Publisher_ID_LOV);
            panel1.Controls.Add(txtBook_Publisher_ID);
            panel1.Controls.Add(txtPublisher_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnShow_Book_Author_ID_LOV);
            panel1.Controls.Add(txtBook_Author_ID);
            panel1.Controls.Add(txtBook_Author_Desc);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnShow_Book_Subject_ID_LOV);
            panel1.Controls.Add(txtBook_Subject_ID);
            panel1.Controls.Add(txtBook_Subject_Desc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBook_Title);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBook_ID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(163, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 158);
            panel1.TabIndex = 0;
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Location = new Point(529, 10);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(208, 27);
            txtBarcode.TabIndex = 53;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(743, 10);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 52;
            label11.Text = "باركود";
            // 
            // txtToBookPrice
            // 
            txtToBookPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtToBookPrice.Location = new Point(262, 116);
            txtToBookPrice.Margin = new Padding(3, 4, 3, 4);
            txtToBookPrice.Mask = "00000";
            txtToBookPrice.Name = "txtToBookPrice";
            txtToBookPrice.Size = new Size(48, 27);
            txtToBookPrice.TabIndex = 51;
            txtToBookPrice.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(317, 116);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 50;
            label9.Text = "الى";
            // 
            // txtFromBookPrice
            // 
            txtFromBookPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFromBookPrice.Location = new Point(366, 116);
            txtFromBookPrice.Margin = new Padding(3, 4, 3, 4);
            txtFromBookPrice.Mask = "00000";
            txtFromBookPrice.Name = "txtFromBookPrice";
            txtFromBookPrice.Size = new Size(48, 27);
            txtFromBookPrice.TabIndex = 49;
            txtFromBookPrice.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(421, 116);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 48;
            label10.Text = "السعر";
            // 
            // txtToRemainQNT
            // 
            txtToRemainQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtToRemainQNT.Location = new Point(262, 81);
            txtToRemainQNT.Margin = new Padding(3, 4, 3, 4);
            txtToRemainQNT.Mask = "00000";
            txtToRemainQNT.Name = "txtToRemainQNT";
            txtToRemainQNT.Size = new Size(48, 27);
            txtToRemainQNT.TabIndex = 47;
            txtToRemainQNT.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(317, 81);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 46;
            label7.Text = "الى";
            // 
            // txtFromRemainQNT
            // 
            txtFromRemainQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFromRemainQNT.Location = new Point(366, 81);
            txtFromRemainQNT.Margin = new Padding(3, 4, 3, 4);
            txtFromRemainQNT.Mask = "00000";
            txtFromRemainQNT.Name = "txtFromRemainQNT";
            txtFromRemainQNT.Size = new Size(48, 27);
            txtFromRemainQNT.TabIndex = 45;
            txtFromRemainQNT.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(421, 81);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 44;
            label6.Text = "العدد المتبقي   من";
            // 
            // btnShow_Book_Publisher_ID_LOV
            // 
            btnShow_Book_Publisher_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Publisher_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Publisher_ID_LOV.Location = new Point(329, 46);
            btnShow_Book_Publisher_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Publisher_ID_LOV.Name = "btnShow_Book_Publisher_ID_LOV";
            btnShow_Book_Publisher_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Publisher_ID_LOV.TabIndex = 42;
            btnShow_Book_Publisher_ID_LOV.TabStop = false;
            btnShow_Book_Publisher_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Publisher_ID_LOV.Click += btnShow_Book_Publisher_ID_LOV_Click;
            // 
            // txtBook_Publisher_ID
            // 
            txtBook_Publisher_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Publisher_ID.Location = new Point(366, 46);
            txtBook_Publisher_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Publisher_ID.Mask = "00000";
            txtBook_Publisher_ID.Name = "txtBook_Publisher_ID";
            txtBook_Publisher_ID.Size = new Size(48, 27);
            txtBook_Publisher_ID.TabIndex = 41;
            txtBook_Publisher_ID.Text = "0";
            // 
            // txtPublisher_Desc
            // 
            txtPublisher_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPublisher_Desc.BackColor = Color.White;
            txtPublisher_Desc.Location = new Point(13, 46);
            txtPublisher_Desc.Margin = new Padding(3, 4, 3, 4);
            txtPublisher_Desc.Name = "txtPublisher_Desc";
            txtPublisher_Desc.ReadOnly = true;
            txtPublisher_Desc.Size = new Size(313, 27);
            txtPublisher_Desc.TabIndex = 43;
            txtPublisher_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(421, 46);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 40;
            label4.Text = "الناشر";
            // 
            // btnShow_Book_Author_ID_LOV
            // 
            btnShow_Book_Author_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Author_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Author_ID_LOV.Location = new Point(861, 76);
            btnShow_Book_Author_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Author_ID_LOV.Name = "btnShow_Book_Author_ID_LOV";
            btnShow_Book_Author_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Author_ID_LOV.TabIndex = 38;
            btnShow_Book_Author_ID_LOV.TabStop = false;
            btnShow_Book_Author_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Author_ID_LOV.Click += btnShow_Book_Author_ID_LOV_Click;
            // 
            // txtBook_Author_ID
            // 
            txtBook_Author_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Author_ID.Location = new Point(898, 76);
            txtBook_Author_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_ID.Mask = "00000";
            txtBook_Author_ID.Name = "txtBook_Author_ID";
            txtBook_Author_ID.Size = new Size(48, 27);
            txtBook_Author_ID.TabIndex = 37;
            txtBook_Author_ID.Text = "0";
            // 
            // txtBook_Author_Desc
            // 
            txtBook_Author_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Author_Desc.BackColor = Color.White;
            txtBook_Author_Desc.Location = new Point(591, 76);
            txtBook_Author_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_Desc.Name = "txtBook_Author_Desc";
            txtBook_Author_Desc.Size = new Size(267, 27);
            txtBook_Author_Desc.TabIndex = 39;
            txtBook_Author_Desc.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(953, 76);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 36;
            label5.Text = "المؤلف";
            // 
            // btnShow_Book_Subject_ID_LOV
            // 
            btnShow_Book_Subject_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Subject_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Subject_ID_LOV.Location = new Point(861, 109);
            btnShow_Book_Subject_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Subject_ID_LOV.Name = "btnShow_Book_Subject_ID_LOV";
            btnShow_Book_Subject_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Subject_ID_LOV.TabIndex = 34;
            btnShow_Book_Subject_ID_LOV.TabStop = false;
            btnShow_Book_Subject_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Subject_ID_LOV.Click += btnShow_Book_Subject_ID_LOV_Click;
            // 
            // txtBook_Subject_ID
            // 
            txtBook_Subject_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Subject_ID.Location = new Point(898, 109);
            txtBook_Subject_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Subject_ID.Mask = "00000";
            txtBook_Subject_ID.Name = "txtBook_Subject_ID";
            txtBook_Subject_ID.Size = new Size(48, 27);
            txtBook_Subject_ID.TabIndex = 33;
            txtBook_Subject_ID.Text = "0";
            // 
            // txtBook_Subject_Desc
            // 
            txtBook_Subject_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Subject_Desc.BackColor = Color.White;
            txtBook_Subject_Desc.Location = new Point(591, 109);
            txtBook_Subject_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Subject_Desc.Name = "txtBook_Subject_Desc";
            txtBook_Subject_Desc.ReadOnly = true;
            txtBook_Subject_Desc.Size = new Size(267, 27);
            txtBook_Subject_Desc.TabIndex = 35;
            txtBook_Subject_Desc.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(953, 109);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 32;
            label8.Text = "الموضوع";
            // 
            // txtBook_Title
            // 
            txtBook_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Title.Location = new Point(529, 43);
            txtBook_Title.Name = "txtBook_Title";
            txtBook_Title.Size = new Size(417, 27);
            txtBook_Title.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(964, 43);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "العنوان";
            // 
            // txtBook_ID
            // 
            txtBook_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_ID.Location = new Point(821, 10);
            txtBook_ID.Name = "txtBook_ID";
            txtBook_ID.Size = new Size(125, 27);
            txtBook_ID.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(964, 10);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "الرمز";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(13, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNew, tsbtnEdit, tsbtnBeginingQnt });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1219, 55);
            toolStrip1.TabIndex = 1;
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
            // tsbtnEdit
            // 
            tsbtnEdit.Image = Properties.Resources.EditRecord;
            tsbtnEdit.ImageTransparentColor = Color.Magenta;
            tsbtnEdit.Name = "tsbtnEdit";
            tsbtnEdit.Size = new Size(98, 52);
            tsbtnEdit.Text = "تعديل";
            tsbtnEdit.Click += tsbtnEdit_Click;
            // 
            // tsbtnBeginingQnt
            // 
            tsbtnBeginingQnt.Image = Properties.Resources.icons8_quantity_50;
            tsbtnBeginingQnt.ImageTransparentColor = Color.Magenta;
            tsbtnBeginingQnt.Name = "tsbtnBeginingQnt";
            tsbtnBeginingQnt.Size = new Size(143, 52);
            tsbtnBeginingQnt.Text = "كمية افتتاحية";
            tsbtnBeginingQnt.Click += tsbtnBeginingQnt_Click;
            // 
            // grdBookList
            // 
            grdBookList.AllowUserToAddRows = false;
            grdBookList.AllowUserToDeleteRows = false;
            grdBookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBookList.Columns.AddRange(new DataGridViewColumn[] { colBook_ID, colItem_ID, colItem_Unit_ID, colBook_Author_ID, colBook_Title, colBook_Author_Desc, colBook_Cat_ID, colBook_Cat_Desc, colBook_Subject_ID, colBook_Subject_Desc, colBook_Publisher_ID, colPublisher_Desc, colItem_Unit_Price, colBarcode, colItem_Unit_Cost, colRemainQNT });
            grdBookList.Location = new Point(12, 231);
            grdBookList.Name = "grdBookList";
            grdBookList.ReadOnly = true;
            grdBookList.RowHeadersWidth = 51;
            grdBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBookList.Size = new Size(1198, 459);
            grdBookList.TabIndex = 2;
            // 
            // colBook_ID
            // 
            colBook_ID.DataPropertyName = "Book_ID";
            colBook_ID.HeaderText = "Book_ID";
            colBook_ID.MinimumWidth = 6;
            colBook_ID.Name = "colBook_ID";
            colBook_ID.ReadOnly = true;
            colBook_ID.Visible = false;
            colBook_ID.Width = 125;
            // 
            // colItem_ID
            // 
            colItem_ID.DataPropertyName = "Item_ID";
            colItem_ID.HeaderText = "Item_ID";
            colItem_ID.MinimumWidth = 6;
            colItem_ID.Name = "colItem_ID";
            colItem_ID.ReadOnly = true;
            colItem_ID.Visible = false;
            colItem_ID.Width = 125;
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
            // colBook_Author_ID
            // 
            colBook_Author_ID.DataPropertyName = "Book_Author_ID";
            colBook_Author_ID.HeaderText = "Book_Author_ID";
            colBook_Author_ID.MinimumWidth = 6;
            colBook_Author_ID.Name = "colBook_Author_ID";
            colBook_Author_ID.ReadOnly = true;
            colBook_Author_ID.Visible = false;
            colBook_Author_ID.Width = 125;
            // 
            // colBook_Title
            // 
            colBook_Title.DataPropertyName = "Book_Title";
            colBook_Title.HeaderText = "العنوان";
            colBook_Title.MinimumWidth = 6;
            colBook_Title.Name = "colBook_Title";
            colBook_Title.ReadOnly = true;
            colBook_Title.Width = 200;
            // 
            // colBook_Author_Desc
            // 
            colBook_Author_Desc.DataPropertyName = "Book_Author_Desc";
            colBook_Author_Desc.HeaderText = "المؤلف";
            colBook_Author_Desc.MinimumWidth = 6;
            colBook_Author_Desc.Name = "colBook_Author_Desc";
            colBook_Author_Desc.ReadOnly = true;
            colBook_Author_Desc.Width = 150;
            // 
            // colBook_Cat_ID
            // 
            colBook_Cat_ID.DataPropertyName = "Book_Cat_ID";
            colBook_Cat_ID.HeaderText = "Book_Cat_ID";
            colBook_Cat_ID.MinimumWidth = 6;
            colBook_Cat_ID.Name = "colBook_Cat_ID";
            colBook_Cat_ID.ReadOnly = true;
            colBook_Cat_ID.Visible = false;
            colBook_Cat_ID.Width = 125;
            // 
            // colBook_Cat_Desc
            // 
            colBook_Cat_Desc.DataPropertyName = "Book_Cat_Desc";
            colBook_Cat_Desc.HeaderText = "الفئة";
            colBook_Cat_Desc.MinimumWidth = 6;
            colBook_Cat_Desc.Name = "colBook_Cat_Desc";
            colBook_Cat_Desc.ReadOnly = true;
            colBook_Cat_Desc.Width = 125;
            // 
            // colBook_Subject_ID
            // 
            colBook_Subject_ID.DataPropertyName = "Book_Subject_ID";
            colBook_Subject_ID.HeaderText = "Book_Subject_ID";
            colBook_Subject_ID.MinimumWidth = 6;
            colBook_Subject_ID.Name = "colBook_Subject_ID";
            colBook_Subject_ID.ReadOnly = true;
            colBook_Subject_ID.Visible = false;
            colBook_Subject_ID.Width = 125;
            // 
            // colBook_Subject_Desc
            // 
            colBook_Subject_Desc.DataPropertyName = "Book_Subject_Desc";
            colBook_Subject_Desc.HeaderText = "الموضوع";
            colBook_Subject_Desc.MinimumWidth = 6;
            colBook_Subject_Desc.Name = "colBook_Subject_Desc";
            colBook_Subject_Desc.ReadOnly = true;
            colBook_Subject_Desc.Width = 125;
            // 
            // colBook_Publisher_ID
            // 
            colBook_Publisher_ID.DataPropertyName = "Book_Publisher_ID";
            colBook_Publisher_ID.HeaderText = "Book_Publisher_ID";
            colBook_Publisher_ID.MinimumWidth = 6;
            colBook_Publisher_ID.Name = "colBook_Publisher_ID";
            colBook_Publisher_ID.ReadOnly = true;
            colBook_Publisher_ID.Visible = false;
            colBook_Publisher_ID.Width = 125;
            // 
            // colPublisher_Desc
            // 
            colPublisher_Desc.DataPropertyName = "Publisher_Desc";
            colPublisher_Desc.HeaderText = "الناشر";
            colPublisher_Desc.MinimumWidth = 6;
            colPublisher_Desc.Name = "colPublisher_Desc";
            colPublisher_Desc.ReadOnly = true;
            colPublisher_Desc.Width = 125;
            // 
            // colItem_Unit_Price
            // 
            colItem_Unit_Price.DataPropertyName = "Item_Unit_Price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            colItem_Unit_Price.DefaultCellStyle = dataGridViewCellStyle2;
            colItem_Unit_Price.HeaderText = "السعر";
            colItem_Unit_Price.MinimumWidth = 6;
            colItem_Unit_Price.Name = "colItem_Unit_Price";
            colItem_Unit_Price.ReadOnly = true;
            colItem_Unit_Price.Width = 125;
            // 
            // colBarcode
            // 
            colBarcode.DataPropertyName = "Barcode";
            colBarcode.HeaderText = "باركود";
            colBarcode.MinimumWidth = 6;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Width = 125;
            // 
            // colItem_Unit_Cost
            // 
            colItem_Unit_Cost.DataPropertyName = "Item_Unit_Cost";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            colItem_Unit_Cost.DefaultCellStyle = dataGridViewCellStyle3;
            colItem_Unit_Cost.HeaderText = "التكلفة";
            colItem_Unit_Cost.MinimumWidth = 6;
            colItem_Unit_Cost.Name = "colItem_Unit_Cost";
            colItem_Unit_Cost.ReadOnly = true;
            colItem_Unit_Cost.Width = 125;
            // 
            // colRemainQNT
            // 
            colRemainQNT.DataPropertyName = "RemainQNT";
            colRemainQNT.HeaderText = "المتبقي";
            colRemainQNT.MinimumWidth = 6;
            colRemainQNT.Name = "colRemainQNT";
            colRemainQNT.ReadOnly = true;
            colRemainQNT.Width = 125;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1118, 706);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "عدد العناوين";
            // 
            // txtRecordCount
            // 
            txtRecordCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtRecordCount.Location = new Point(976, 703);
            txtRecordCount.Name = "txtRecordCount";
            txtRecordCount.ReadOnly = true;
            txtRecordCount.Size = new Size(125, 27);
            txtRecordCount.TabIndex = 4;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 746);
            Controls.Add(txtRecordCount);
            Controls.Add(label1);
            Controls.Add(grdBookList);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "BookListForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قائمة الكتب";
            KeyDown += BookListForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNew;
        private DataGridView grdBookList;
        private Label label1;
        private TextBox txtRecordCount;
        private ToolStripButton tsbtnEdit;
        private TextBox txtBook_ID;
        private Label label2;
        private TextBox txtBook_Title;
        private Label label3;
        private Button btnShow_Book_Publisher_ID_LOV;
        private MaskedTextBox txtBook_Publisher_ID;
        private TextBox txtPublisher_Desc;
        private Label label4;
        private Button btnShow_Book_Author_ID_LOV;
        private MaskedTextBox txtBook_Author_ID;
        private TextBox txtBook_Author_Desc;
        private Label label5;
        private Button btnShow_Book_Subject_ID_LOV;
        private MaskedTextBox txtBook_Subject_ID;
        private TextBox txtBook_Subject_Desc;
        private Label label8;
        private MaskedTextBox txtToRemainQNT;
        private Label label7;
        private MaskedTextBox txtFromRemainQNT;
        private Label label6;
        private DataGridViewTextBoxColumn colBook_ID;
        private DataGridViewTextBoxColumn colItem_ID;
        private DataGridViewTextBoxColumn colItem_Unit_ID;
        private DataGridViewTextBoxColumn colBook_Author_ID;
        private DataGridViewTextBoxColumn colBook_Title;
        private DataGridViewTextBoxColumn colBook_Author_Desc;
        private DataGridViewTextBoxColumn colBook_Cat_ID;
        private DataGridViewTextBoxColumn colBook_Cat_Desc;
        private DataGridViewTextBoxColumn colBook_Subject_ID;
        private DataGridViewTextBoxColumn colBook_Subject_Desc;
        private DataGridViewTextBoxColumn colBook_Publisher_ID;
        private DataGridViewTextBoxColumn colPublisher_Desc;
        private DataGridViewTextBoxColumn colItem_Unit_Price;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colItem_Unit_Cost;
        private DataGridViewTextBoxColumn colRemainQNT;
        private MaskedTextBox txtToBookPrice;
        private Label label9;
        private MaskedTextBox txtFromBookPrice;
        private Label label10;
        private TextBox txtBarcode;
        private Label label11;
        private ToolStripButton tsbtnBeginingQnt;
    }
}