namespace POS.Windows.Forms
{
    partial class ItemUnitBeginQntDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUnitBeginQntDialog));
            panel1 = new Panel();
            txtQNt = new MaskedTextBox();
            label1 = new Label();
            btnGetData = new Button();
            imageList1 = new ImageList(components);
            txtUnit_ID = new MaskedTextBox();
            txtUnit_Desc = new TextBox();
            label8 = new Label();
            txtBarcode = new TextBox();
            label5 = new Label();
            txtItem_Group_ID = new MaskedTextBox();
            txtItem_Group_Desc = new TextBox();
            label4 = new Label();
            txtItem_Desc = new TextBox();
            label2 = new Label();
            btnOK = new Button();
            chkPrintLableAfterSave = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkPrintLableAfterSave);
            panel1.Controls.Add(txtQNt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGetData);
            panel1.Controls.Add(txtUnit_ID);
            panel1.Controls.Add(txtUnit_Desc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtItem_Group_ID);
            panel1.Controls.Add(txtItem_Group_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtItem_Desc);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 223);
            panel1.TabIndex = 0;
            // 
            // txtQNt
            // 
            txtQNt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQNt.BackColor = Color.White;
            txtQNt.Font = new Font("Segoe UI", 12F);
            txtQNt.Location = new Point(350, 169);
            txtQNt.Margin = new Padding(3, 4, 3, 4);
            txtQNt.Mask = "00000";
            txtQNt.Name = "txtQNt";
            txtQNt.Size = new Size(50, 34);
            txtQNt.TabIndex = 32;
            txtQNt.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(407, 169);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 31;
            label1.Text = "الكمية";
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.ImageIndex = 0;
            btnGetData.ImageList = imageList1;
            btnGetData.Location = new Point(160, 11);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(62, 48);
            btnGetData.TabIndex = 30;
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
            // 
            // txtUnit_ID
            // 
            txtUnit_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_ID.BackColor = Color.FromArgb(255, 224, 192);
            txtUnit_ID.Location = new Point(366, 134);
            txtUnit_ID.Margin = new Padding(3, 4, 3, 4);
            txtUnit_ID.Mask = "00000";
            txtUnit_ID.Name = "txtUnit_ID";
            txtUnit_ID.ReadOnly = true;
            txtUnit_ID.Size = new Size(34, 27);
            txtUnit_ID.TabIndex = 28;
            txtUnit_ID.Text = "0";
            // 
            // txtUnit_Desc
            // 
            txtUnit_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit_Desc.BackColor = Color.White;
            txtUnit_Desc.Location = new Point(93, 134);
            txtUnit_Desc.Margin = new Padding(3, 4, 3, 4);
            txtUnit_Desc.Name = "txtUnit_Desc";
            txtUnit_Desc.ReadOnly = true;
            txtUnit_Desc.Size = new Size(267, 27);
            txtUnit_Desc.TabIndex = 29;
            txtUnit_Desc.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(407, 134);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 27;
            label8.Text = "الوحدة";
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Font = new Font("Segoe UI", 12F);
            txtBarcode.Location = new Point(228, 15);
            txtBarcode.Margin = new Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(172, 34);
            txtBarcode.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(407, 22);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 20;
            label5.Text = "باركود";
            // 
            // txtItem_Group_ID
            // 
            txtItem_Group_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_ID.BackColor = Color.FromArgb(255, 224, 192);
            txtItem_Group_ID.Location = new Point(366, 99);
            txtItem_Group_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_ID.Mask = "00000";
            txtItem_Group_ID.Name = "txtItem_Group_ID";
            txtItem_Group_ID.ReadOnly = true;
            txtItem_Group_ID.Size = new Size(34, 27);
            txtItem_Group_ID.TabIndex = 25;
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Group_Desc.BackColor = Color.White;
            txtItem_Group_Desc.Location = new Point(93, 99);
            txtItem_Group_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.ReadOnly = true;
            txtItem_Group_Desc.Size = new Size(267, 27);
            txtItem_Group_Desc.TabIndex = 26;
            txtItem_Group_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(407, 99);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 24;
            label4.Text = "فئة الصنف";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.BackColor = Color.FromArgb(255, 224, 192);
            txtItem_Desc.Location = new Point(93, 61);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.ReadOnly = true;
            txtItem_Desc.Size = new Size(307, 27);
            txtItem_Desc.TabIndex = 23;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(407, 61);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 22;
            label2.Text = "اسم الصنف";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOK.ImageAlign = ContentAlignment.MiddleRight;
            btnOK.ImageKey = "icons8-ok-50.png";
            btnOK.ImageList = imageList1;
            btnOK.Location = new Point(355, 259);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(127, 60);
            btnOK.TabIndex = 31;
            btnOK.Text = "موافق";
            btnOK.TextAlign = ContentAlignment.MiddleLeft;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // chkPrintLableAfterSave
            // 
            chkPrintLableAfterSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkPrintLableAfterSave.AutoSize = true;
            chkPrintLableAfterSave.Checked = true;
            chkPrintLableAfterSave.CheckState = CheckState.Checked;
            chkPrintLableAfterSave.Location = new Point(93, 168);
            chkPrintLableAfterSave.Name = "chkPrintLableAfterSave";
            chkPrintLableAfterSave.Size = new Size(139, 24);
            chkPrintLableAfterSave.TabIndex = 33;
            chkPrintLableAfterSave.Text = "طباعة بعد الحفظ";
            chkPrintLableAfterSave.UseVisualStyleBackColor = true;
            chkPrintLableAfterSave.Visible = false;
            // 
            // ItemUnitBeginQntDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 331);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemUnitBeginQntDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الكميات الافتتاحية للاصناف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox txtUnit_ID;
        private TextBox txtUnit_Desc;
        private Label label8;
        private TextBox txtBarcode;
        private Label label5;
        private MaskedTextBox txtItem_Group_ID;
        private TextBox txtItem_Group_Desc;
        private Label label4;
        private TextBox txtItem_Desc;
        private Label label2;
        private MaskedTextBox txtQNt;
        private Label label1;
        private Button btnGetData;
        private ImageList imageList1;
        private Button btnOK;
        private CheckBox chkPrintLableAfterSave;
    }
}