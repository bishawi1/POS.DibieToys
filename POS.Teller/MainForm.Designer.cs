namespace POS.Windows
{
    partial class MainForm
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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbtnBackSales = new ToolStripButton();
            tsbtnTicket = new ToolStripButton();
            tsbtnReserveToysRoom = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbtnBackSales, tsbtnTicket, tsbtnReserveToysRoom });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(752, 55);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Teller.Properties.Resources.icons8_basket_100;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(102, 52);
            toolStripButton1.Text = "المبيعات";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbtnBackSales
            // 
            tsbtnBackSales.Image = Teller.Properties.Resources.icons8_back_basket_100;
            tsbtnBackSales.ImageTransparentColor = Color.Magenta;
            tsbtnBackSales.Name = "tsbtnBackSales";
            tsbtnBackSales.Size = new Size(108, 52);
            tsbtnBackSales.Text = "رد مبيعات";
            tsbtnBackSales.Click += tsbtnBackSales_Click;
            // 
            // tsbtnTicket
            // 
            tsbtnTicket.Image = Teller.Properties.Resources.ticket;
            tsbtnTicket.ImageTransparentColor = Color.Magenta;
            tsbtnTicket.Name = "tsbtnTicket";
            tsbtnTicket.Size = new Size(90, 52);
            tsbtnTicket.Text = "التذاكر";
            tsbtnTicket.Click += tsbtnTicket_Click;
            // 
            // tsbtnReserveToysRoom
            // 
            tsbtnReserveToysRoom.Image = Teller.Properties.Resources.icons8_reservation_50;
            tsbtnReserveToysRoom.ImageTransparentColor = Color.Magenta;
            tsbtnReserveToysRoom.Name = "tsbtnReserveToysRoom";
            tsbtnReserveToysRoom.Size = new Size(141, 52);
            tsbtnReserveToysRoom.Text = "حجز قاعة الالعاب";
            tsbtnReserveToysRoom.Click += tsbtnReserveToysRoom_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 409);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton tsbtnTicket;
        private ToolStripButton tsbtnBackSales;
        private ToolStripButton tsbtnReserveToysRoom;
    }
}