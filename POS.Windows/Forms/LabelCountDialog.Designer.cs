namespace POS.Windows
{
    partial class LabelCountDialog
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
            txtLabelCount = new NumericUpDown();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtLabelCount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtLabelCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 96);
            panel1.TabIndex = 0;
            // 
            // txtLabelCount
            // 
            txtLabelCount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabelCount.Location = new Point(68, 30);
            txtLabelCount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txtLabelCount.Name = "txtLabelCount";
            txtLabelCount.Size = new Size(120, 32);
            txtLabelCount.TabIndex = 1;
            txtLabelCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "العدد";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(214, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 25);
            btnOk.TabIndex = 1;
            btnOk.Text = "موافق";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 25);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "الغاء امر";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LabelCountDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 165);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LabelCountDialog";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عدد الليبل";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtLabelCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown txtLabelCount;
        private Label label1;
        private Button btnOk;
        private Button btnCancel;
    }
}