namespace POS.Windows.Forms.Books
{
    partial class BookDialog
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
            chkPrintLableAfterSave = new CheckBox();
            txtQNT = new NumericUpDown();
            txtItem_Unit_Cost = new NumericUpDown();
            txtItem_Unit_Price = new NumericUpDown();
            lblQNT = new Label();
            label6 = new Label();
            label5 = new Label();
            btnShow_Book_Publisher_ID_LOV = new Button();
            txtBook_Publisher_ID = new MaskedTextBox();
            txtPublisher_Desc = new TextBox();
            label4 = new Label();
            btnShow_Book_Author_ID_LOV = new Button();
            txtBook_Author_ID = new MaskedTextBox();
            txtBook_Author_Desc = new TextBox();
            label3 = new Label();
            btnShow_Book_Subject_ID_LOV = new Button();
            txtBook_Subject_ID = new MaskedTextBox();
            txtBook_Subject_Desc = new TextBox();
            label8 = new Label();
            txtBook_Title = new TextBox();
            label2 = new Label();
            txtBook_ID = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            btnPrintBarcode = new Button();
            toolStrip1 = new ToolStrip();
            tsbtnDelete = new ToolStripButton();
            tsbtnPrintLabel = new ToolStripButton();
            tsbtnItemStockDetails = new ToolStripButton();
            tsbtnShowOpeningQntDialog = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQNT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItem_Unit_Price).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkPrintLableAfterSave);
            panel1.Controls.Add(txtQNT);
            panel1.Controls.Add(txtItem_Unit_Cost);
            panel1.Controls.Add(txtItem_Unit_Price);
            panel1.Controls.Add(lblQNT);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnShow_Book_Publisher_ID_LOV);
            panel1.Controls.Add(txtBook_Publisher_ID);
            panel1.Controls.Add(txtPublisher_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnShow_Book_Author_ID_LOV);
            panel1.Controls.Add(txtBook_Author_ID);
            panel1.Controls.Add(txtBook_Author_Desc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnShow_Book_Subject_ID_LOV);
            panel1.Controls.Add(txtBook_Subject_ID);
            panel1.Controls.Add(txtBook_Subject_Desc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBook_Title);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBook_ID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 346);
            panel1.TabIndex = 0;
            // 
            // chkPrintLableAfterSave
            // 
            chkPrintLableAfterSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkPrintLableAfterSave.AutoSize = true;
            chkPrintLableAfterSave.Checked = true;
            chkPrintLableAfterSave.CheckState = CheckState.Checked;
            chkPrintLableAfterSave.Location = new Point(221, 292);
            chkPrintLableAfterSave.Name = "chkPrintLableAfterSave";
            chkPrintLableAfterSave.Size = new Size(139, 24);
            chkPrintLableAfterSave.TabIndex = 25;
            chkPrintLableAfterSave.Text = "طباعة بعد الحفظ";
            chkPrintLableAfterSave.UseVisualStyleBackColor = true;
            chkPrintLableAfterSave.Visible = false;
            // 
            // txtQNT
            // 
            txtQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQNT.Location = new Point(430, 267);
            txtQNT.Margin = new Padding(3, 4, 3, 4);
            txtQNT.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtQNT.Name = "txtQNT";
            txtQNT.Size = new Size(114, 27);
            txtQNT.TabIndex = 24;
            // 
            // txtItem_Unit_Cost
            // 
            txtItem_Unit_Cost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_Cost.DecimalPlaces = 1;
            txtItem_Unit_Cost.Location = new Point(431, 233);
            txtItem_Unit_Cost.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_Cost.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtItem_Unit_Cost.Name = "txtItem_Unit_Cost";
            txtItem_Unit_Cost.Size = new Size(114, 27);
            txtItem_Unit_Cost.TabIndex = 23;
            // 
            // txtItem_Unit_Price
            // 
            txtItem_Unit_Price.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_Price.DecimalPlaces = 1;
            txtItem_Unit_Price.Location = new Point(431, 197);
            txtItem_Unit_Price.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_Price.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtItem_Unit_Price.Name = "txtItem_Unit_Price";
            txtItem_Unit_Price.Size = new Size(114, 27);
            txtItem_Unit_Price.TabIndex = 22;
            // 
            // lblQNT
            // 
            lblQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQNT.AutoSize = true;
            lblQNT.Location = new Point(551, 269);
            lblQNT.Name = "lblQNT";
            lblQNT.Size = new Size(48, 20);
            lblQNT.TabIndex = 20;
            lblQNT.Text = "الكمية";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(551, 233);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 18;
            label6.Text = "سعر التكلفة";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(551, 197);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 16;
            label5.Text = "السعر";
            // 
            // btnShow_Book_Publisher_ID_LOV
            // 
            btnShow_Book_Publisher_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Publisher_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Publisher_ID_LOV.Location = new Point(459, 125);
            btnShow_Book_Publisher_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Publisher_ID_LOV.Name = "btnShow_Book_Publisher_ID_LOV";
            btnShow_Book_Publisher_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Publisher_ID_LOV.TabIndex = 10;
            btnShow_Book_Publisher_ID_LOV.TabStop = false;
            btnShow_Book_Publisher_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Publisher_ID_LOV.Click += btnShow_Book_Publisher_ID_LOV_Click;
            // 
            // txtBook_Publisher_ID
            // 
            txtBook_Publisher_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Publisher_ID.Location = new Point(496, 125);
            txtBook_Publisher_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Publisher_ID.Mask = "00000";
            txtBook_Publisher_ID.Name = "txtBook_Publisher_ID";
            txtBook_Publisher_ID.Size = new Size(48, 27);
            txtBook_Publisher_ID.TabIndex = 9;
            txtBook_Publisher_ID.Text = "0";
            txtBook_Publisher_ID.Enter += txtBook_Publisher_ID_Enter;
            // 
            // txtPublisher_Desc
            // 
            txtPublisher_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPublisher_Desc.BackColor = Color.White;
            txtPublisher_Desc.Location = new Point(189, 125);
            txtPublisher_Desc.Margin = new Padding(3, 4, 3, 4);
            txtPublisher_Desc.Name = "txtPublisher_Desc";
            txtPublisher_Desc.ReadOnly = true;
            txtPublisher_Desc.Size = new Size(267, 27);
            txtPublisher_Desc.TabIndex = 11;
            txtPublisher_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(551, 125);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "الناشر";
            // 
            // btnShow_Book_Author_ID_LOV
            // 
            btnShow_Book_Author_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Author_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Author_ID_LOV.Location = new Point(459, 89);
            btnShow_Book_Author_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Author_ID_LOV.Name = "btnShow_Book_Author_ID_LOV";
            btnShow_Book_Author_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Author_ID_LOV.TabIndex = 6;
            btnShow_Book_Author_ID_LOV.TabStop = false;
            btnShow_Book_Author_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Author_ID_LOV.Click += btnShow_Book_Author_ID_LOV_Click;
            // 
            // txtBook_Author_ID
            // 
            txtBook_Author_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Author_ID.Location = new Point(496, 89);
            txtBook_Author_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_ID.Mask = "00000";
            txtBook_Author_ID.Name = "txtBook_Author_ID";
            txtBook_Author_ID.Size = new Size(48, 27);
            txtBook_Author_ID.TabIndex = 5;
            txtBook_Author_ID.Text = "0";
            txtBook_Author_ID.MaskInputRejected += txtBook_Author_ID_MaskInputRejected;
            txtBook_Author_ID.Enter += txtBook_Author_ID_Enter;
            // 
            // txtBook_Author_Desc
            // 
            txtBook_Author_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Author_Desc.BackColor = Color.White;
            txtBook_Author_Desc.Location = new Point(189, 89);
            txtBook_Author_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Author_Desc.Name = "txtBook_Author_Desc";
            txtBook_Author_Desc.ReadOnly = true;
            txtBook_Author_Desc.Size = new Size(267, 27);
            txtBook_Author_Desc.TabIndex = 7;
            txtBook_Author_Desc.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(551, 89);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "المؤلف";
            // 
            // btnShow_Book_Subject_ID_LOV
            // 
            btnShow_Book_Subject_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Subject_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Subject_ID_LOV.Location = new Point(459, 161);
            btnShow_Book_Subject_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Subject_ID_LOV.Name = "btnShow_Book_Subject_ID_LOV";
            btnShow_Book_Subject_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Subject_ID_LOV.TabIndex = 14;
            btnShow_Book_Subject_ID_LOV.TabStop = false;
            btnShow_Book_Subject_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Subject_ID_LOV.Click += btnShow_Book_Subject_ID_LOV_Click;
            // 
            // txtBook_Subject_ID
            // 
            txtBook_Subject_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Subject_ID.Location = new Point(496, 161);
            txtBook_Subject_ID.Margin = new Padding(3, 4, 3, 4);
            txtBook_Subject_ID.Mask = "00000";
            txtBook_Subject_ID.Name = "txtBook_Subject_ID";
            txtBook_Subject_ID.Size = new Size(48, 27);
            txtBook_Subject_ID.TabIndex = 13;
            txtBook_Subject_ID.Text = "0";
            txtBook_Subject_ID.Enter += txtBook_Subject_ID_Enter;
            // 
            // txtBook_Subject_Desc
            // 
            txtBook_Subject_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Subject_Desc.BackColor = Color.White;
            txtBook_Subject_Desc.Location = new Point(189, 161);
            txtBook_Subject_Desc.Margin = new Padding(3, 4, 3, 4);
            txtBook_Subject_Desc.Name = "txtBook_Subject_Desc";
            txtBook_Subject_Desc.ReadOnly = true;
            txtBook_Subject_Desc.Size = new Size(267, 27);
            txtBook_Subject_Desc.TabIndex = 15;
            txtBook_Subject_Desc.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(551, 161);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 12;
            label8.Text = "الموضوع";
            // 
            // txtBook_Title
            // 
            txtBook_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_Title.Location = new Point(19, 53);
            txtBook_Title.Name = "txtBook_Title";
            txtBook_Title.Size = new Size(523, 27);
            txtBook_Title.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(551, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "العنوان";
            // 
            // txtBook_ID
            // 
            txtBook_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBook_ID.Location = new Point(417, 17);
            txtBook_ID.Name = "txtBook_ID";
            txtBook_ID.ReadOnly = true;
            txtBook_ID.Size = new Size(125, 27);
            txtBook_ID.TabIndex = 1;
            txtBook_ID.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(551, 17);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "الرمز";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(577, 410);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(35, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrintBarcode
            // 
            btnPrintBarcode.Location = new Point(0, 0);
            btnPrintBarcode.Name = "btnPrintBarcode";
            btnPrintBarcode.Size = new Size(75, 23);
            btnPrintBarcode.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnDelete, tsbtnPrintLabel, tsbtnItemStockDetails, tsbtnShowOpeningQntDialog });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(709, 55);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnDelete
            // 
            tsbtnDelete.Image = Properties.Resources.trash;
            tsbtnDelete.ImageTransparentColor = Color.Magenta;
            tsbtnDelete.Name = "tsbtnDelete";
            tsbtnDelete.Size = new Size(93, 52);
            tsbtnDelete.Text = "حذف";
            tsbtnDelete.Click += tsbtnDelete_ClickAsync;
            // 
            // tsbtnPrintLabel
            // 
            tsbtnPrintLabel.Image = Properties.Resources.printLabel;
            tsbtnPrintLabel.ImageTransparentColor = Color.Magenta;
            tsbtnPrintLabel.Name = "tsbtnPrintLabel";
            tsbtnPrintLabel.Size = new Size(129, 52);
            tsbtnPrintLabel.Text = "طباعة ليبل";
            tsbtnPrintLabel.Click += tsbtnPrintLabel_Click;
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
            // BookDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 451);
            Controls.Add(toolStrip1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بطاقة الكتاب";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQNT).EndInit();
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
        private TextBox txtBook_Title;
        private Label label2;
        private TextBox txtBook_ID;
        private Label label1;
        private Button btnShow_Book_Publisher_ID_LOV;
        private MaskedTextBox txtBook_Publisher_ID;
        private TextBox txtPublisher_Desc;
        private Label label4;
        private Button btnShow_Book_Author_ID_LOV;
        private MaskedTextBox txtBook_Author_ID;
        private TextBox txtBook_Author_Desc;
        private Label label3;
        private Button btnShow_Book_Subject_ID_LOV;
        private MaskedTextBox txtBook_Subject_ID;
        private TextBox txtBook_Subject_Desc;
        private Label label8;
        private Label lblQNT;
        private Label label6;
        private Label label5;
        private NumericUpDown txtItem_Unit_Cost;
        private NumericUpDown txtItem_Unit_Price;
        private NumericUpDown txtQNT;
        private CheckBox chkPrintLableAfterSave;
        private Button btnPrintBarcode;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnDelete;
        private ToolStripButton tsbtnPrintLabel;
        private ToolStripButton tsbtnItemStockDetails;
        private ToolStripButton tsbtnShowOpeningQntDialog;
    }
}