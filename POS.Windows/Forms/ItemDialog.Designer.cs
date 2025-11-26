namespace POS.Windows.Forms
{
    partial class ItemDialog
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
            panel1 = new Panel();
            btnUploadFile = new Button();
            picItemImage = new PictureBox();
            chkQuickAccess = new CheckBox();
            btnShow_Book_Source_ID_LOV = new Button();
            txtSource_ID = new MaskedTextBox();
            txtSource_Name = new TextBox();
            label10 = new Label();
            btnGenerateBarcode = new Button();
            btnShow_Item_Brand_ID_LOV = new Button();
            txtItem_Brand_ID = new MaskedTextBox();
            txtItem_Brand_Name = new TextBox();
            label9 = new Label();
            btnShow_Unit_ID_LOV = new Button();
            txtUnit_ID = new MaskedTextBox();
            txtUnit_Desc = new TextBox();
            label8 = new Label();
            txtItem_Unit_Cost = new NumericUpDown();
            label7 = new Label();
            txtItem_Unit_Price = new NumericUpDown();
            label6 = new Label();
            txtBarcode = new TextBox();
            label5 = new Label();
            btnShow_Item_Group_ID_LOV = new Button();
            txtItem_Group_ID = new MaskedTextBox();
            txtItem_Group_Desc = new TextBox();
            label4 = new Label();
            txtNotes = new TextBox();
            label3 = new Label();
            txtItem_Desc = new TextBox();
            label2 = new Label();
            txtItem_No = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            toolStrip1 = new ToolStrip();
            tsbtnDelete = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tsbtnItemStockDetails = new ToolStripButton();
            tsbtnShowOpeningQntDialog = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Price).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnUploadFile);
            panel1.Controls.Add(picItemImage);
            panel1.Controls.Add(chkQuickAccess);
            panel1.Controls.Add(btnShow_Book_Source_ID_LOV);
            panel1.Controls.Add(txtSource_ID);
            panel1.Controls.Add(txtSource_Name);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnGenerateBarcode);
            panel1.Controls.Add(btnShow_Item_Brand_ID_LOV);
            panel1.Controls.Add(txtItem_Brand_ID);
            panel1.Controls.Add(txtItem_Brand_Name);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnShow_Unit_ID_LOV);
            panel1.Controls.Add(txtUnit_ID);
            panel1.Controls.Add(txtUnit_Desc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtItem_Unit_Cost);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtItem_Unit_Price);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnShow_Item_Group_ID_LOV);
            panel1.Controls.Add(txtItem_Group_ID);
            panel1.Controls.Add(txtItem_Group_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtItem_Desc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtItem_No);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 62);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 251);
            panel1.TabIndex = 0;
            // 
            // btnUploadFile
            // 
            btnUploadFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUploadFile.Location = new Point(4, 117);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(124, 29);
            btnUploadFile.TabIndex = 12;
            btnUploadFile.TabStop = false;
            btnUploadFile.Text = "ارفاق";
            btnUploadFile.UseVisualStyleBackColor = true;
            btnUploadFile.Click += btnUploadFile_Click;
            // 
            // picItemImage
            // 
            picItemImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picItemImage.BorderStyle = BorderStyle.FixedSingle;
            picItemImage.Location = new Point(3, 3);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(125, 104);
            picItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picItemImage.TabIndex = 31;
            picItemImage.TabStop = false;
            // 
            // chkQuickAccess
            // 
            chkQuickAccess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkQuickAccess.AutoSize = true;
            chkQuickAccess.Location = new Point(229, 15);
            chkQuickAccess.Name = "chkQuickAccess";
            chkQuickAccess.Size = new Size(119, 24);
            chkQuickAccess.TabIndex = 2;
            chkQuickAccess.Text = "قائمة مختصرة";
            chkQuickAccess.UseVisualStyleBackColor = true;
            // 
            // btnShow_Book_Source_ID_LOV
            // 
            btnShow_Book_Source_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Source_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Source_ID_LOV.Location = new Point(410, 330);
            btnShow_Book_Source_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Source_ID_LOV.Name = "btnShow_Book_Source_ID_LOV";
            btnShow_Book_Source_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Source_ID_LOV.TabIndex = 30;
            btnShow_Book_Source_ID_LOV.TabStop = false;
            btnShow_Book_Source_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Source_ID_LOV.Visible = false;
            btnShow_Book_Source_ID_LOV.Click += btnShow_Book_Source_ID_LOV_Click;
            // 
            // txtSource_ID
            // 
            txtSource_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_ID.Location = new Point(443, 330);
            txtSource_ID.Margin = new Padding(3, 4, 3, 4);
            txtSource_ID.Mask = "00000";
            txtSource_ID.Name = "txtSource_ID";
            txtSource_ID.Size = new Size(34, 27);
            txtSource_ID.TabIndex = 29;
            txtSource_ID.TabStop = false;
            txtSource_ID.Text = "0";
            txtSource_ID.Visible = false;
            txtSource_ID.Enter += txtSource_ID_Enter;
            txtSource_ID.Validating += txtSource_ID_Validating;
            // 
            // txtSource_Name
            // 
            txtSource_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_Name.BackColor = Color.White;
            txtSource_Name.Location = new Point(140, 330);
            txtSource_Name.Margin = new Padding(3, 4, 3, 4);
            txtSource_Name.Name = "txtSource_Name";
            txtSource_Name.ReadOnly = true;
            txtSource_Name.Size = new Size(267, 27);
            txtSource_Name.TabIndex = 0;
            txtSource_Name.TabStop = false;
            txtSource_Name.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(484, 330);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 27;
            label10.Text = "المصدر";
            label10.Visible = false;
            // 
            // btnGenerateBarcode
            // 
            btnGenerateBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateBarcode.Location = new Point(213, 45);
            btnGenerateBarcode.Margin = new Padding(3, 4, 3, 4);
            btnGenerateBarcode.Name = "btnGenerateBarcode";
            btnGenerateBarcode.Size = new Size(86, 31);
            btnGenerateBarcode.TabIndex = 5;
            btnGenerateBarcode.TabStop = false;
            btnGenerateBarcode.Text = "توليد";
            btnGenerateBarcode.UseVisualStyleBackColor = true;
            btnGenerateBarcode.Click += btnGenerateBarcode_Click;
            // 
            // btnShow_Item_Brand_ID_LOV
            // 
            btnShow_Item_Brand_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Brand_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Brand_ID_LOV.Location = new Point(410, 291);
            btnShow_Item_Brand_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Brand_ID_LOV.Name = "btnShow_Item_Brand_ID_LOV";
            btnShow_Item_Brand_ID_LOV.Size = new Size(31, 31);
            btnShow_Item_Brand_ID_LOV.TabIndex = 25;
            btnShow_Item_Brand_ID_LOV.TabStop = false;
            btnShow_Item_Brand_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Brand_ID_LOV.Visible = false;
            btnShow_Item_Brand_ID_LOV.Click += btnShow_Item_Brand_ID_LOV_Click;
            // 
            // txtItem_Brand_ID
            // 
            txtItem_Brand_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Brand_ID.Location = new Point(443, 291);
            txtItem_Brand_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Brand_ID.Mask = "00000";
            txtItem_Brand_ID.Name = "txtItem_Brand_ID";
            txtItem_Brand_ID.Size = new Size(34, 27);
            txtItem_Brand_ID.TabIndex = 24;
            txtItem_Brand_ID.TabStop = false;
            txtItem_Brand_ID.Text = "0";
            txtItem_Brand_ID.Visible = false;
            txtItem_Brand_ID.MaskInputRejected += txtItem_Brand_ID_MaskInputRejected;
            txtItem_Brand_ID.Enter += txtItem_Brand_ID_Enter;
            txtItem_Brand_ID.Validating += txtItem_Brand_ID_Validating;
            // 
            // txtItem_Brand_Name
            // 
            txtItem_Brand_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Brand_Name.BackColor = Color.White;
            txtItem_Brand_Name.Location = new Point(140, 291);
            txtItem_Brand_Name.Margin = new Padding(3, 4, 3, 4);
            txtItem_Brand_Name.Name = "txtItem_Brand_Name";
            txtItem_Brand_Name.ReadOnly = true;
            txtItem_Brand_Name.Size = new Size(267, 27);
            txtItem_Brand_Name.TabIndex = 26;
            txtItem_Brand_Name.TabStop = false;
            txtItem_Brand_Name.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(484, 291);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 23;
            label9.Text = "المصنع";
            label9.Visible = false;
            // 
            // btnShow_Unit_ID_LOV
            // 
            btnShow_Unit_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Unit_ID_LOV.Image = Properties.Resources.List;
            btnShow_Unit_ID_LOV.Location = new Point(410, 153);
            btnShow_Unit_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Unit_ID_LOV.Name = "btnShow_Unit_ID_LOV";
            btnShow_Unit_ID_LOV.Size = new Size(31, 31);
            btnShow_Unit_ID_LOV.TabIndex = 19;
            btnShow_Unit_ID_LOV.TabStop = false;
            btnShow_Unit_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Unit_ID_LOV.Click += btnShow_Unit_ID_LOV_Click;
            // 
            // txtUnit_ID
            // 
            txtUnit_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_ID.Location = new Point(443, 153);
            txtUnit_ID.Margin = new Padding(3, 4, 3, 4);
            txtUnit_ID.Mask = "00000";
            txtUnit_ID.Name = "txtUnit_ID";
            txtUnit_ID.Size = new Size(34, 27);
            txtUnit_ID.TabIndex = 18;
            txtUnit_ID.Text = "0";
            txtUnit_ID.Enter += txtUnit_ID_Enter;
            txtUnit_ID.Validating += txtUnit_ID_Validating;
            // 
            // txtUnit_Desc
            // 
            txtUnit_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_Desc.BackColor = Color.White;
            txtUnit_Desc.Location = new Point(140, 153);
            txtUnit_Desc.Margin = new Padding(3, 4, 3, 4);
            txtUnit_Desc.Name = "txtUnit_Desc";
            txtUnit_Desc.ReadOnly = true;
            txtUnit_Desc.Size = new Size(267, 27);
            txtUnit_Desc.TabIndex = 20;
            txtUnit_Desc.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(484, 153);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 17;
            label8.Text = "الوحدة";
            // 
            // txtItem_Unit_Cost
            // 
            txtItem_Unit_Cost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_Cost.DecimalPlaces = 2;
            txtItem_Unit_Cost.Location = new Point(140, 117);
            txtItem_Unit_Cost.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_Cost.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtItem_Unit_Cost.Name = "txtItem_Unit_Cost";
            txtItem_Unit_Cost.Size = new Size(114, 27);
            txtItem_Unit_Cost.TabIndex = 16;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(261, 117);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 15;
            label7.Text = "سعر التكلفة";
            // 
            // txtItem_Unit_Price
            // 
            txtItem_Unit_Price.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_Price.DecimalPlaces = 1;
            txtItem_Unit_Price.Location = new Point(363, 117);
            txtItem_Unit_Price.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_Price.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtItem_Unit_Price.Name = "txtItem_Unit_Price";
            txtItem_Unit_Price.Size = new Size(114, 27);
            txtItem_Unit_Price.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(484, 117);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "السعر";
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Location = new Point(305, 45);
            txtBarcode.Margin = new Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(172, 27);
            txtBarcode.TabIndex = 4;
            txtBarcode.Validating += txtBarcode_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(484, 45);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 3;
            label5.Text = "باركود";
            // 
            // btnShow_Item_Group_ID_LOV
            // 
            btnShow_Item_Group_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Group_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Group_ID_LOV.Location = new Point(410, 256);
            btnShow_Item_Group_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Group_ID_LOV.Name = "btnShow_Item_Group_ID_LOV";
            btnShow_Item_Group_ID_LOV.Size = new Size(31, 31);
            btnShow_Item_Group_ID_LOV.TabIndex = 10;
            btnShow_Item_Group_ID_LOV.TabStop = false;
            btnShow_Item_Group_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Group_ID_LOV.Visible = false;
            btnShow_Item_Group_ID_LOV.Click += btnShow_Season_ID_LOV_Click;
            // 
            // txtItem_Group_ID
            // 
            txtItem_Group_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_ID.Location = new Point(443, 256);
            txtItem_Group_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_ID.Mask = "00000";
            txtItem_Group_ID.Name = "txtItem_Group_ID";
            txtItem_Group_ID.Size = new Size(34, 27);
            txtItem_Group_ID.TabIndex = 9;
            txtItem_Group_ID.TabStop = false;
            txtItem_Group_ID.Text = "6";
            txtItem_Group_ID.Visible = false;
            txtItem_Group_ID.MaskInputRejected += txtItem_Group_ID_MaskInputRejected;
            txtItem_Group_ID.Enter += txtItem_Group_ID_Enter;
            txtItem_Group_ID.Validating += txtItem_Group_ID_Validating;
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_Desc.BackColor = Color.White;
            txtItem_Group_Desc.Location = new Point(140, 256);
            txtItem_Group_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.ReadOnly = true;
            txtItem_Group_Desc.Size = new Size(267, 27);
            txtItem_Group_Desc.TabIndex = 11;
            txtItem_Group_Desc.TabStop = false;
            txtItem_Group_Desc.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(484, 256);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "فئة الصنف";
            label4.Visible = false;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNotes.Location = new Point(140, 189);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(337, 41);
            txtNotes.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(484, 189);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 21;
            label3.Text = "ملاحظات";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.Location = new Point(140, 81);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.Size = new Size(337, 27);
            txtItem_Desc.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(484, 81);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "اسم الصنف";
            // 
            // txtItem_No
            // 
            txtItem_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_No.Location = new Point(363, 9);
            txtItem_No.Margin = new Padding(3, 4, 3, 4);
            txtItem_No.Name = "txtItem_No";
            txtItem_No.ReadOnly = true;
            txtItem_No.Size = new Size(114, 27);
            txtItem_No.TabIndex = 1;
            txtItem_No.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(484, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "رقم الصنف";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(516, 322);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 31);
            btnOK.TabIndex = 2;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(174, 322);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnDelete, toolStripButton1, tsbtnItemStockDetails, tsbtnShowOpeningQntDialog });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(631, 55);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnDelete
            // 
            tsbtnDelete.Image = Properties.Resources.trash;
            tsbtnDelete.ImageTransparentColor = Color.Magenta;
            tsbtnDelete.Name = "tsbtnDelete";
            tsbtnDelete.Size = new Size(93, 52);
            tsbtnDelete.Text = "حذف";
            tsbtnDelete.Click += tsbtnDelete_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.printLabel;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(129, 52);
            toolStripButton1.Text = "طباعة ليبل";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbtnItemStockDetails
            // 
            tsbtnItemStockDetails.Image = Properties.Resources.view_details;
            tsbtnItemStockDetails.ImageTransparentColor = Color.Magenta;
            tsbtnItemStockDetails.Name = "tsbtnItemStockDetails";
            tsbtnItemStockDetails.Size = new Size(153, 52);
            tsbtnItemStockDetails.Text = "بطاقة المخزون";
            tsbtnItemStockDetails.Click += tsbtnItemStockDetails_Click;
            // 
            // tsbtnShowOpeningQntDialog
            // 
            tsbtnShowOpeningQntDialog.Image = Properties.Resources.icons8_quantity_50;
            tsbtnShowOpeningQntDialog.ImageTransparentColor = Color.Magenta;
            tsbtnShowOpeningQntDialog.Name = "tsbtnShowOpeningQntDialog";
            tsbtnShowOpeningQntDialog.Size = new Size(161, 52);
            tsbtnShowOpeningQntDialog.Text = "الكمية الافتتاحية";
            tsbtnShowOpeningQntDialog.Click += tsbtnShowOpeningQntDialog_Click;
            // 
            // ItemDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 369);
            Controls.Add(toolStrip1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بطاقة الصنف";
            Activated += ItemDialog_Activated;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Price).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnOK;
        private Button btnCancel;
        private Label label4;
        private TextBox txtNotes;
        private Label label3;
        private TextBox txtItem_Desc;
        private Label label2;
        private TextBox txtItem_No;
        private Label label1;
        private Button btnShow_Item_Group_ID_LOV;
        private MaskedTextBox txtItem_Group_ID;
        private TextBox txtItem_Group_Desc;
        private TextBox txtBarcode;
        private Label label5;
        private Label label6;
        private NumericUpDown txtItem_Unit_Cost;
        private Label label7;
        private NumericUpDown txtItem_Unit_Price;
        private Button btnShow_Unit_ID_LOV;
        private MaskedTextBox txtUnit_ID;
        private TextBox txtUnit_Desc;
        private Label label8;
        private Button btnShow_Item_Brand_ID_LOV;
        private MaskedTextBox txtItem_Brand_ID;
        private TextBox txtItem_Brand_Name;
        private Label label9;
        private Button btnGenerateBarcode;
        private Button btnShow_Book_Source_ID_LOV;
        private MaskedTextBox txtSource_ID;
        private TextBox txtSource_Name;
        private Label label10;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnDelete;
        private CheckBox chkQuickAccess;
        private ToolStripButton toolStripButton1;
        private PictureBox picItemImage;
        private Button btnUploadFile;
        private ToolStripButton tsbtnItemStockDetails;
        private ToolStripButton tsbtnShowOpeningQntDialog;
    }
}