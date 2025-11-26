namespace POS.Teller.Forms
{
    partial class ReserveToysRoomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveToysRoomDialog));
            panel1 = new Panel();
            btnCancelReserve = new Button();
            imageList1 = new ImageList(components);
            btnDoReserve = new Button();
            txtReserve_Toy_Room_ID = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            dtDueTime = new DateTimePicker();
            label5 = new Label();
            dtDue_Date = new DateTimePicker();
            txtAmount = new NumericUpDown();
            label4 = new Label();
            txtKids_No = new NumericUpDown();
            label3 = new Label();
            txtNotes = new TextBox();
            label2 = new Label();
            chkCanceled = new CheckBox();
            chkDone = new CheckBox();
            txtReserver_Name = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtReserve_Toy_Room_ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKids_No).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelReserve);
            panel1.Controls.Add(btnDoReserve);
            panel1.Controls.Add(txtReserve_Toy_Room_ID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtDueTime);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtDue_Date);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtKids_No);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chkCanceled);
            panel1.Controls.Add(chkDone);
            panel1.Controls.Add(txtReserver_Name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 17);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 234);
            panel1.TabIndex = 0;
            // 
            // btnCancelReserve
            // 
            btnCancelReserve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelReserve.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelReserve.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelReserve.ImageKey = "icons8-cancel-50-red.png";
            btnCancelReserve.ImageList = imageList1;
            btnCancelReserve.Location = new Point(16, 58);
            btnCancelReserve.Margin = new Padding(3, 2, 3, 2);
            btnCancelReserve.Name = "btnCancelReserve";
            btnCancelReserve.Size = new Size(39, 45);
            btnCancelReserve.TabIndex = 34;
            btnCancelReserve.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelReserve.UseVisualStyleBackColor = true;
            btnCancelReserve.Click += btnCancelReserve_Click;
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
            // btnDoReserve
            // 
            btnDoReserve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoReserve.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDoReserve.ImageAlign = ContentAlignment.MiddleRight;
            btnDoReserve.ImageKey = "icons8-ok-50.png";
            btnDoReserve.ImageList = imageList1;
            btnDoReserve.Location = new Point(15, 2);
            btnDoReserve.Margin = new Padding(3, 2, 3, 2);
            btnDoReserve.Name = "btnDoReserve";
            btnDoReserve.Size = new Size(40, 45);
            btnDoReserve.TabIndex = 33;
            btnDoReserve.TextAlign = ContentAlignment.MiddleLeft;
            btnDoReserve.UseVisualStyleBackColor = true;
            btnDoReserve.Click += btnDoReserve_Click;
            // 
            // txtReserve_Toy_Room_ID
            // 
            txtReserve_Toy_Room_ID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtReserve_Toy_Room_ID.Location = new Point(321, 16);
            txtReserve_Toy_Room_ID.Margin = new Padding(3, 2, 3, 2);
            txtReserve_Toy_Room_ID.Name = "txtReserve_Toy_Room_ID";
            txtReserve_Toy_Room_ID.ReadOnly = true;
            txtReserve_Toy_Room_ID.Size = new Size(83, 23);
            txtReserve_Toy_Room_ID.TabIndex = 1;
            txtReserve_Toy_Room_ID.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(410, 16);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 0;
            label7.Text = "رقم الحجز";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(192, 76);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "الساعة";
            // 
            // dtDueTime
            // 
            dtDueTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtDueTime.CustomFormat = "hh:mm:ss";
            dtDueTime.Format = DateTimePickerFormat.Custom;
            dtDueTime.Location = new Point(91, 76);
            dtDueTime.Margin = new Padding(3, 2, 3, 2);
            dtDueTime.Name = "dtDueTime";
            dtDueTime.Size = new Size(96, 23);
            dtDueTime.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(410, 76);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "التاريخ";
            // 
            // dtDue_Date
            // 
            dtDue_Date.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtDue_Date.CustomFormat = "dd/MM/yyyy";
            dtDue_Date.Format = DateTimePickerFormat.Custom;
            dtDue_Date.Location = new Point(285, 76);
            dtDue_Date.Margin = new Padding(3, 2, 3, 2);
            dtDue_Date.Name = "dtDue_Date";
            dtDue_Date.Size = new Size(120, 23);
            dtDue_Date.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.Location = new Point(91, 106);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(95, 23);
            txtAmount.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(192, 106);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "المبلغ";
            // 
            // txtKids_No
            // 
            txtKids_No.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtKids_No.Location = new Point(321, 106);
            txtKids_No.Margin = new Padding(3, 2, 3, 2);
            txtKids_No.Name = "txtKids_No";
            txtKids_No.Size = new Size(83, 23);
            txtKids_No.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(410, 106);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "عدد الاطفال";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNotes.Location = new Point(91, 140);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(314, 83);
            txtNotes.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(410, 140);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 12;
            label2.Text = "ملاحظات";
            // 
            // chkCanceled
            // 
            chkCanceled.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkCanceled.AutoSize = true;
            chkCanceled.Enabled = false;
            chkCanceled.Location = new Point(95, 18);
            chkCanceled.Margin = new Padding(3, 2, 3, 2);
            chkCanceled.Name = "chkCanceled";
            chkCanceled.Size = new Size(54, 19);
            chkCanceled.TabIndex = 15;
            chkCanceled.Text = "ملغي";
            chkCanceled.UseVisualStyleBackColor = true;
            // 
            // chkDone
            // 
            chkDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkDone.AutoSize = true;
            chkDone.Enabled = false;
            chkDone.Location = new Point(228, 18);
            chkDone.Margin = new Padding(3, 2, 3, 2);
            chkDone.Name = "chkDone";
            chkDone.Size = new Size(49, 19);
            chkDone.TabIndex = 14;
            chkDone.Text = "منفذ";
            chkDone.UseVisualStyleBackColor = true;
            // 
            // txtReserver_Name
            // 
            txtReserver_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtReserver_Name.Location = new Point(91, 46);
            txtReserver_Name.Margin = new Padding(3, 2, 3, 2);
            txtReserver_Name.Name = "txtReserver_Name";
            txtReserver_Name.Size = new Size(314, 23);
            txtReserver_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(410, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "طالب الحجز";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(75, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(374, 270);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "موافق";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ReserveToysRoomDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 303);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReserveToysRoomDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حجز قاعة الالعاب";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtReserve_Toy_Room_ID).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKids_No).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkCanceled;
        private CheckBox chkDone;
        private TextBox txtReserver_Name;
        private Label label1;
        private NumericUpDown txtAmount;
        private Label label4;
        private NumericUpDown txtKids_No;
        private Label label3;
        private TextBox txtNotes;
        private Label label2;
        private NumericUpDown txtReserve_Toy_Room_ID;
        private Label label7;
        private Label label6;
        private DateTimePicker dtDueTime;
        private Label label5;
        private DateTimePicker dtDue_Date;
        private Button btnCancel;
        private Button btnOK;
        private ImageList imageList1;
        private Button btnDoReserve;
        private Button btnCancelReserve;
    }
}