namespace POS.Windows.Forms.Lookups
{
    partial class ItemGroupDialog
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
            btnShow_Parent_Item_Group_ID_LOV = new Button();
            txtParent_Item_Group_ID = new MaskedTextBox();
            txtParent_Item_Group_Desc = new TextBox();
            label4 = new Label();
            txtItem_Group_Notes = new TextBox();
            label3 = new Label();
            txtItem_Group_Desc = new TextBox();
            label2 = new Label();
            txtItem_Group_ID = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow_Parent_Item_Group_ID_LOV);
            panel1.Controls.Add(txtParent_Item_Group_ID);
            panel1.Controls.Add(txtParent_Item_Group_Desc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtItem_Group_Notes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtItem_Group_Desc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtItem_Group_ID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 174);
            panel1.TabIndex = 0;
            // 
            // btnShow_Parent_Item_Group_ID_LOV
            // 
            btnShow_Parent_Item_Group_ID_LOV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow_Parent_Item_Group_ID_LOV.Image = Properties.Resources.List;
            btnShow_Parent_Item_Group_ID_LOV.Location = new Point(255, 86);
            btnShow_Parent_Item_Group_ID_LOV.Name = "btnShow_Parent_Item_Group_ID_LOV";
            btnShow_Parent_Item_Group_ID_LOV.Size = new Size(27, 23);
            btnShow_Parent_Item_Group_ID_LOV.TabIndex = 6;
            btnShow_Parent_Item_Group_ID_LOV.TabStop = false;
            btnShow_Parent_Item_Group_ID_LOV.UseVisualStyleBackColor = true;
            btnShow_Parent_Item_Group_ID_LOV.Click += btnShow_Parent_Item_Group_ID_LOV_Click;
            // 
            // txtParent_Item_Group_ID
            // 
            txtParent_Item_Group_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtParent_Item_Group_ID.Location = new Point(284, 86);
            txtParent_Item_Group_ID.Mask = "00000";
            txtParent_Item_Group_ID.Name = "txtParent_Item_Group_ID";
            txtParent_Item_Group_ID.Size = new Size(30, 23);
            txtParent_Item_Group_ID.TabIndex = 5;
            txtParent_Item_Group_ID.Enter += txtParent_Item_Group_ID_Enter;
            // 
            // txtParent_Item_Group_Desc
            // 
            txtParent_Item_Group_Desc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtParent_Item_Group_Desc.BackColor = Color.White;
            txtParent_Item_Group_Desc.Location = new Point(19, 86);
            txtParent_Item_Group_Desc.Name = "txtParent_Item_Group_Desc";
            txtParent_Item_Group_Desc.Size = new Size(234, 23);
            txtParent_Item_Group_Desc.TabIndex = 7;
            txtParent_Item_Group_Desc.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(320, 86);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 4;
            label4.Text = "يتبع لـ";
            // 
            // txtItem_Group_Notes
            // 
            txtItem_Group_Notes.ForeColor = Color.Black;
            txtItem_Group_Notes.Location = new Point(17, 122);
            txtItem_Group_Notes.Multiline = true;
            txtItem_Group_Notes.Name = "txtItem_Group_Notes";
            txtItem_Group_Notes.Size = new Size(297, 36);
            txtItem_Group_Notes.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(320, 122);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "ملاحظات";
            // 
            // txtItem_Group_Desc
            // 
            txtItem_Group_Desc.ForeColor = Color.Black;
            txtItem_Group_Desc.Location = new Point(17, 50);
            txtItem_Group_Desc.Name = "txtItem_Group_Desc";
            txtItem_Group_Desc.Size = new Size(297, 23);
            txtItem_Group_Desc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(320, 50);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "الاسم";
            // 
            // txtItem_Group_ID
            // 
            txtItem_Group_ID.ForeColor = Color.Black;
            txtItem_Group_ID.Location = new Point(232, 14);
            txtItem_Group_ID.Name = "txtItem_Group_ID";
            txtItem_Group_ID.ReadOnly = true;
            txtItem_Group_ID.Size = new Size(82, 23);
            txtItem_Group_ID.TabIndex = 1;
            txtItem_Group_ID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(320, 14);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "الرقم";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(29, 202);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(322, 202);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ItemGroupDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 246);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemGroupDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مجموعة الاصناف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtItem_Group_Notes;
        private Label label3;
        private TextBox txtItem_Group_Desc;
        private Label label2;
        private TextBox txtItem_Group_ID;
        private Label label1;
        private Button btnShow_Parent_Item_Group_ID_LOV;
        private MaskedTextBox txtParent_Item_Group_ID;
        private TextBox txtParent_Item_Group_Desc;
        private Label label4;
        private Button btnCancel;
        private Button btnOK;
    }
}