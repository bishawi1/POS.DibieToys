namespace POS.Windows.Forms
{
    partial class SupplyTransactionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyTransactionDialog));
            btnOK = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            btnGetData = new Button();
            imageList1 = new ImageList(components);
            txtBarcode = new TextBox();
            label6 = new Label();
            cmbBranch_ID = new ComboBox();
            txtQNT = new MaskedTextBox();
            label5 = new Label();
            btnShow_Item_Unit_ID_LOV = new Button();
            txtItem_Unit_ID = new MaskedTextBox();
            txtItem_Desc = new TextBox();
            label4 = new Label();
            txtTransaction_Notes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTransaction_Date = new DateTimePicker();
            btnShow_Book_Source_ID_LOV = new Button();
            txtSource_ID = new MaskedTextBox();
            txtSource_Name = new TextBox();
            label10 = new Label();
            txtSupply_Transaction_ID = new TextBox();
            label1 = new Label();
            btnShow_Item_Group_ID_LOV = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(337, 370);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(34, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow_Item_Group_ID_LOV);
            panel1.Controls.Add(btnGetData);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbBranch_ID);
            panel1.Controls.Add(txtQNT);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnShow_Item_Unit_ID_LOV);
            panel1.Controls.Add(txtItem_Unit_ID);
            panel1.Controls.Add(txtItem_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTransaction_Notes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTransaction_Date);
            panel1.Controls.Add(btnShow_Book_Source_ID_LOV);
            panel1.Controls.Add(txtSource_ID);
            panel1.Controls.Add(txtSource_Name);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtSupply_Transaction_ID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 323);
            panel1.TabIndex = 2;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetData.ImageIndex = 0;
            btnGetData.ImageList = imageList1;
            btnGetData.Location = new Point(122, 17);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(62, 48);
            btnGetData.TabIndex = 50;
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
            imageList1.Images.SetKeyName(3, "AdvancedSearch.png");
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBarcode.Font = new Font("Segoe UI", 12F);
            txtBarcode.Location = new Point(190, 21);
            txtBarcode.Margin = new Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(172, 34);
            txtBarcode.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(369, 28);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 48;
            label6.Text = "باركود";
            // 
            // cmbBranch_ID
            // 
            cmbBranch_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch_ID.FormattingEnabled = true;
            cmbBranch_ID.Location = new Point(25, 82);
            cmbBranch_ID.Name = "cmbBranch_ID";
            cmbBranch_ID.Size = new Size(179, 28);
            cmbBranch_ID.TabIndex = 42;
            // 
            // txtQNT
            // 
            txtQNT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQNT.Location = new Point(295, 193);
            txtQNT.Margin = new Padding(3, 4, 3, 4);
            txtQNT.Mask = "00000";
            txtQNT.Name = "txtQNT";
            txtQNT.Size = new Size(67, 27);
            txtQNT.TabIndex = 41;
            txtQNT.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(369, 193);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 40;
            label5.Text = "الكمية";
            // 
            // btnShow_Item_Unit_ID_LOV
            // 
            btnShow_Item_Unit_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Unit_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Unit_ID_LOV.Location = new Point(295, 155);
            btnShow_Item_Unit_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Unit_ID_LOV.Name = "btnShow_Item_Unit_ID_LOV";
            btnShow_Item_Unit_ID_LOV.Size = new Size(31, 31);
            btnShow_Item_Unit_ID_LOV.TabIndex = 38;
            btnShow_Item_Unit_ID_LOV.TabStop = false;
            btnShow_Item_Unit_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Unit_ID_LOV.Click += btnShow_Item_Unit_ID_LOV_Click;
            // 
            // txtItem_Unit_ID
            // 
            txtItem_Unit_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Unit_ID.Location = new Point(328, 155);
            txtItem_Unit_ID.Margin = new Padding(3, 4, 3, 4);
            txtItem_Unit_ID.Mask = "00000";
            txtItem_Unit_ID.Name = "txtItem_Unit_ID";
            txtItem_Unit_ID.Size = new Size(34, 27);
            txtItem_Unit_ID.TabIndex = 37;
            txtItem_Unit_ID.Text = "0";
            // 
            // txtItem_Desc
            // 
            txtItem_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtItem_Desc.BackColor = Color.White;
            txtItem_Desc.Location = new Point(25, 155);
            txtItem_Desc.Margin = new Padding(3, 4, 3, 4);
            txtItem_Desc.Name = "txtItem_Desc";
            txtItem_Desc.ReadOnly = true;
            txtItem_Desc.Size = new Size(267, 27);
            txtItem_Desc.TabIndex = 39;
            txtItem_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(369, 155);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 36;
            label4.Text = "الصنف";
            // 
            // txtTransaction_Notes
            // 
            txtTransaction_Notes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransaction_Notes.Location = new Point(25, 231);
            txtTransaction_Notes.Multiline = true;
            txtTransaction_Notes.Name = "txtTransaction_Notes";
            txtTransaction_Notes.Size = new Size(337, 60);
            txtTransaction_Notes.TabIndex = 35;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(358, 231);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 34;
            label3.Text = "ملاحظات";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(372, 79);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 33;
            label2.Text = "التاريخ";
            // 
            // txtTransaction_Date
            // 
            txtTransaction_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransaction_Date.CustomFormat = "dd/MM/yyyy";
            txtTransaction_Date.Format = DateTimePickerFormat.Custom;
            txtTransaction_Date.Location = new Point(237, 79);
            txtTransaction_Date.Name = "txtTransaction_Date";
            txtTransaction_Date.Size = new Size(125, 27);
            txtTransaction_Date.TabIndex = 32;
            // 
            // btnShow_Book_Source_ID_LOV
            // 
            btnShow_Book_Source_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Book_Source_ID_LOV.Image = Properties.Resources.List;
            btnShow_Book_Source_ID_LOV.Location = new Point(295, 117);
            btnShow_Book_Source_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Book_Source_ID_LOV.Name = "btnShow_Book_Source_ID_LOV";
            btnShow_Book_Source_ID_LOV.Size = new Size(31, 31);
            btnShow_Book_Source_ID_LOV.TabIndex = 30;
            btnShow_Book_Source_ID_LOV.TabStop = false;
            btnShow_Book_Source_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Book_Source_ID_LOV.Click += btnShow_Book_Source_ID_LOV_Click;
            // 
            // txtSource_ID
            // 
            txtSource_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_ID.Location = new Point(328, 117);
            txtSource_ID.Margin = new Padding(3, 4, 3, 4);
            txtSource_ID.Mask = "00000";
            txtSource_ID.Name = "txtSource_ID";
            txtSource_ID.Size = new Size(34, 27);
            txtSource_ID.TabIndex = 29;
            txtSource_ID.Text = "0";
            // 
            // txtSource_Name
            // 
            txtSource_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSource_Name.BackColor = Color.White;
            txtSource_Name.Location = new Point(25, 117);
            txtSource_Name.Margin = new Padding(3, 4, 3, 4);
            txtSource_Name.Name = "txtSource_Name";
            txtSource_Name.ReadOnly = true;
            txtSource_Name.Size = new Size(267, 27);
            txtSource_Name.TabIndex = 31;
            txtSource_Name.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(369, 117);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 28;
            label10.Text = "المصدر";
            // 
            // txtSupply_Transaction_ID
            // 
            txtSupply_Transaction_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupply_Transaction_ID.Location = new Point(3, 40);
            txtSupply_Transaction_ID.Name = "txtSupply_Transaction_ID";
            txtSupply_Transaction_ID.Size = new Size(50, 27);
            txtSupply_Transaction_ID.TabIndex = 1;
            txtSupply_Transaction_ID.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "الرمز";
            label1.Visible = false;
            // 
            // btnShow_Item_Group_ID_LOV
            // 
            btnShow_Item_Group_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Item_Group_ID_LOV.Image = Properties.Resources.List;
            btnShow_Item_Group_ID_LOV.Location = new Point(54, 17);
            btnShow_Item_Group_ID_LOV.Margin = new Padding(3, 4, 3, 4);
            btnShow_Item_Group_ID_LOV.Name = "btnShow_Item_Group_ID_LOV";
            btnShow_Item_Group_ID_LOV.Size = new Size(62, 48);
            btnShow_Item_Group_ID_LOV.TabIndex = 51;
            btnShow_Item_Group_ID_LOV.TabStop = false;
            btnShow_Item_Group_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Item_Group_ID_LOV.Click += btnShow_Item_Group_ID_LOV_Click;
            // 
            // SupplyTransactionDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 422);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplyTransactionDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "توريد الاصناف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Panel panel1;
        private TextBox txtSupply_Transaction_ID;
        private Label label1;
        private Button btnShow_Book_Source_ID_LOV;
        private MaskedTextBox txtSource_ID;
        private TextBox txtSource_Name;
        private Label label10;
        private TextBox txtTransaction_Notes;
        private Label label3;
        private Label label2;
        private DateTimePicker txtTransaction_Date;
        private Button btnShow_Item_Unit_ID_LOV;
        private MaskedTextBox txtItem_Unit_ID;
        private TextBox txtItem_Desc;
        private Label label4;
        private MaskedTextBox txtQNT;
        private Label label5;
        private ComboBox cmbBranch_ID;
        private Button btnGetData;
        private ImageList imageList1;
        private TextBox txtBarcode;
        private Label label6;
        private Button btnShow_Item_Group_ID_LOV;
    }
}