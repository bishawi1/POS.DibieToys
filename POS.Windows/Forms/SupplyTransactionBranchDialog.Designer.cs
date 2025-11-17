namespace POS.Windows
{
    partial class SupplyTransactionBranchDialog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyTransactionBranchDialog));
            panel1 = new Panel();
            txtTransaction_Notes = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtTransaction_Date = new DateTimePicker();
            label3 = new Label();
            cmbBranch_ID = new ComboBox();
            chkPrintLableAfterSave = new CheckBox();
            txtQNT = new MaskedTextBox();
            label1 = new Label();
            txtUnit_ID = new MaskedTextBox();
            txtUnit_Desc = new TextBox();
            label8 = new Label();
            txtItem_Group_ID = new MaskedTextBox();
            txtItem_Group_Desc = new TextBox();
            label4 = new Label();
            txtItem_Desc = new TextBox();
            label2 = new Label();
            btnGetData = new Button();
            imageList1 = new ImageList(components);
            txtBarcode = new TextBox();
            label5 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            btnShow_Item_Group_ID_LOV = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow_Item_Group_ID_LOV);
            panel1.Controls.Add(txtTransaction_Notes);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTransaction_Date);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbBranch_ID);
            panel1.Controls.Add(chkPrintLableAfterSave);
            panel1.Controls.Add(txtQNT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUnit_ID);
            panel1.Controls.Add(txtUnit_Desc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtItem_Group_ID);
            panel1.Controls.Add(txtItem_Group_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtItem_Desc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGetData);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(13, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 366);
            panel1.TabIndex = 0;
            // 
            // txtTransaction_Notes
            // 
            txtTransaction_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransaction_Notes.Location = new Point(-2, 300);
            txtTransaction_Notes.Multiline = true;
            txtTransaction_Notes.Name = "txtTransaction_Notes";
            txtTransaction_Notes.Size = new Size(337, 60);
            txtTransaction_Notes.TabIndex = 50;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(341, 300);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 49;
            label7.Text = "ملاحظات";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(341, 117);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 48;
            label6.Text = "التاريخ";
            // 
            // txtTransaction_Date
            // 
            txtTransaction_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransaction_Date.CustomFormat = "dd/MM/yyyy";
            txtTransaction_Date.Format = DateTimePickerFormat.Custom;
            txtTransaction_Date.Location = new Point(206, 117);
            txtTransaction_Date.Name = "txtTransaction_Date";
            txtTransaction_Date.Size = new Size(125, 27);
            txtTransaction_Date.TabIndex = 47;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(342, 79);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 46;
            label3.Text = "الفرع";
            // 
            // cmbBranch_ID
            // 
            cmbBranch_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch_ID.FormattingEnabled = true;
            cmbBranch_ID.Location = new Point(24, 76);
            cmbBranch_ID.Name = "cmbBranch_ID";
            cmbBranch_ID.Size = new Size(307, 28);
            cmbBranch_ID.TabIndex = 45;
            // 
            // chkPrintLableAfterSave
            // 
            chkPrintLableAfterSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkPrintLableAfterSave.AutoSize = true;
            chkPrintLableAfterSave.Checked = true;
            chkPrintLableAfterSave.CheckState = CheckState.Checked;
            chkPrintLableAfterSave.Location = new Point(24, 258);
            chkPrintLableAfterSave.Name = "chkPrintLableAfterSave";
            chkPrintLableAfterSave.Size = new Size(139, 24);
            chkPrintLableAfterSave.TabIndex = 44;
            chkPrintLableAfterSave.Text = "طباعة بعد الحفظ";
            chkPrintLableAfterSave.UseVisualStyleBackColor = true;
            chkPrintLableAfterSave.Visible = false;
            // 
            // txtQNT
            // 
            txtQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQNT.BackColor = Color.White;
            txtQNT.Font = new Font("Segoe UI", 12F);
            txtQNT.Location = new Point(281, 259);
            txtQNT.Margin = new Padding(3, 4, 3, 4);
            txtQNT.Mask = "00000";
            txtQNT.Name = "txtQNT";
            txtQNT.Size = new Size(50, 34);
            txtQNT.TabIndex = 43;
            txtQNT.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(338, 259);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 42;
            label1.Text = "الكمية";
            // 
            // txtUnit_ID
            // 
            txtUnit_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_ID.BackColor = Color.FromArgb(255, 224, 192);
            txtUnit_ID.Location = new Point(297, 224);
            txtUnit_ID.Margin = new Padding(3, 4, 3, 4);
            txtUnit_ID.Mask = "00000";
            txtUnit_ID.Name = "txtUnit_ID";
            txtUnit_ID.ReadOnly = true;
            txtUnit_ID.Size = new Size(34, 27);
            txtUnit_ID.TabIndex = 40;
            txtUnit_ID.Text = "0";
            // 
            // txtUnit_Desc
            // 
            txtUnit_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_Desc.BackColor = Color.White;
            txtUnit_Desc.Location = new Point(24, 224);
            txtUnit_Desc.Margin = new Padding(3, 4, 3, 4);
            txtUnit_Desc.Name = "txtUnit_Desc";
            txtUnit_Desc.ReadOnly = true;
            txtUnit_Desc.Size = new Size(267, 27);
            txtUnit_Desc.TabIndex = 41;
            txtUnit_Desc.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(338, 224);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 39;
            label8.Text = "الوحدة";
            // 
            // txtItem_Group_ID
            // 
            txtItem_Group_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_ID.BackColor = Color.FromArgb(255, 224, 192);
            txtItem_Group_ID.Location = new Point(297, 189);
            txtItem_Group_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_ID.Mask = "00000";
            txtItem_Group_ID.Name = "txtItem_Group_ID";
            txtItem_Group_ID.ReadOnly = true;
            txtItem_Group_ID.Size = new Size(34, 27);
            txtItem_Group_ID.TabIndex = 37;
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_Desc.BackColor = Color.White;
            txtItem_Group_Desc.Location = new Point(24, 189);
            txtItem_Group_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.ReadOnly = true;
            txtItem_Group_Desc.Size = new Size(267, 27);
            txtItem_Group_Desc.TabIndex = 38;
            txtItem_Group_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(338, 189);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 36;
            label4.Text = "فئة الصنف";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.BackColor = Color.FromArgb(255, 224, 192);
            txtItem_Desc.Location = new Point(24, 151);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.ReadOnly = true;
            txtItem_Desc.Size = new Size(307, 27);
            txtItem_Desc.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(338, 151);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 34;
            label2.Text = "اسم الصنف";
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.ImageIndex = 0;
            btnGetData.ImageList = imageList1;
            btnGetData.Location = new Point(91, 22);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(62, 48);
            btnGetData.TabIndex = 33;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SeachIcon.jpg");
            imageList1.Images.SetKeyName(1, "icons8-ok-50.png");
            imageList1.Images.SetKeyName(2, "icons8-cancel-50-red.png");
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Font = new Font("Segoe UI", 12F);
            txtBarcode.Location = new Point(159, 26);
            txtBarcode.Margin = new Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(172, 34);
            txtBarcode.TabIndex = 32;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(338, 33);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 31;
            label5.Text = "باركود";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(311, 391);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(127, 60);
            btnOK.TabIndex = 32;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "icons8-cancel-50-red.png";
            btnCancel.ImageList = imageList1;
            btnCancel.Location = new Point(26, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 60);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "الغاء امر";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnShow_Item_Group_ID_LOV
            // 
            btnShow_Item_Group_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Group_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Group_ID_LOV.Location = new Point(24, 22);
            btnShow_Item_Group_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Group_ID_LOV.Name = "btnShow_Item_Group_ID_LOV";
            btnShow_Item_Group_ID_LOV.Size = new Size(62, 48);
            btnShow_Item_Group_ID_LOV.TabIndex = 52;
            btnShow_Item_Group_ID_LOV.TabStop = false;
            btnShow_Item_Group_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Group_ID_LOV.Click += btnShow_Item_Group_ID_LOV_Click;
            // 
            // SupplyTransactionBranchDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 454);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplyTransactionBranchDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "توريد الى الفرع";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private Button btnOK;
        private Button btnGetData;
        private TextBox txtBarcode;
        private Label label5;
        private CheckBox chkPrintLableAfterSave;
        private MaskedTextBox txtQNT;
        private Label label1;
        private MaskedTextBox txtUnit_ID;
        private TextBox txtUnit_Desc;
        private Label label8;
        private MaskedTextBox txtItem_Group_ID;
        private TextBox txtItem_Group_Desc;
        private Label label4;
        private TextBox txtItem_Desc;
        private Label label2;
        private Label label3;
        private ComboBox cmbBranch_ID;
        private Label label6;
        private DateTimePicker txtTransaction_Date;
        private TextBox txtTransaction_Notes;
        private Label label7;
        private Button btnCancel;
        private Button btnShow_Item_Group_ID_LOV;
    }
}