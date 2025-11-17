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
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbtnBackSales = new ToolStripButton();
            tsbtnTicket = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(859, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbtnBackSales, tsbtnTicket });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(859, 55);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.icons8_basket_100;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(116, 52);
            toolStripButton1.Text = "المبيعات";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbtnBackSales
            // 
            tsbtnBackSales.Image = Properties.Resources.icons8_back_basket_100;
            tsbtnBackSales.ImageTransparentColor = Color.Magenta;
            tsbtnBackSales.Name = "tsbtnBackSales";
            tsbtnBackSales.Size = new Size(124, 52);
            tsbtnBackSales.Text = "رد مبيعات";
            tsbtnBackSales.Click += tsbtnBackSales_Click;
            // 
            // tsbtnTicket
            // 
            tsbtnTicket.Image = Properties.Resources.ticket;
            tsbtnTicket.ImageTransparentColor = Color.Magenta;
            tsbtnTicket.Name = "tsbtnTicket";
            tsbtnTicket.Size = new Size(101, 52);
            tsbtnTicket.Text = "التذاكر";
            tsbtnTicket.Click += tsbtnTicket_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 545);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
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

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton tsbtnTicket;
        private ToolStripButton tsbtnBackSales;
    }
}