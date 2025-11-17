namespace POS.Windows.Forms
{
    partial class POSBookshopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSBookshopForm));
            MaincategoryList = new POSApp.Components.CategoryComponent();
            SubCategoryList = new POSApp.Components.CategoryComponent();
            categoryProductListComponent = new POS.Windows.Components.CategoryProductComponent();
            soldItemListComponent1 = new POS.Windows.Components.SoldItemListComponent();
            imageList1 = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MaincategoryList
            // 
            MaincategoryList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MaincategoryList.BackColor = Color.White;
            MaincategoryList.Location = new Point(3, 20);
            MaincategoryList.Margin = new Padding(3, 5, 3, 5);
            MaincategoryList.Name = "MaincategoryList";
            MaincategoryList.Size = new Size(558, 76);
            MaincategoryList.TabIndex = 0;
            MaincategoryList.OnCategoryClick += MaincategoryList_OnCategoryClick;
            MaincategoryList.Load += MaincategoryList_Load;
            // 
            // SubCategoryList
            // 
            SubCategoryList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubCategoryList.BackColor = Color.White;
            SubCategoryList.Location = new Point(3, 120);
            SubCategoryList.Margin = new Padding(3, 5, 3, 5);
            SubCategoryList.Name = "SubCategoryList";
            SubCategoryList.Size = new Size(641, 96);
            SubCategoryList.TabIndex = 1;
            SubCategoryList.OnCategoryClick += SubCategoryList_OnCategoryClick;
            SubCategoryList.Load += SubCategoryList_Load;
            // 
            // categoryProductListComponent
            // 
            categoryProductListComponent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryProductListComponent.BackColor = Color.White;
            categoryProductListComponent.Location = new Point(7, 224);
            categoryProductListComponent.Margin = new Padding(3, 5, 3, 5);
            categoryProductListComponent.Name = "categoryProductListComponent";
            categoryProductListComponent.Size = new Size(641, 368);
            categoryProductListComponent.TabIndex = 2;
            categoryProductListComponent.OnProductClick += categoryProductComponent1_OnProductClick;
            // 
            // soldItemListComponent1
            // 
            soldItemListComponent1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            soldItemListComponent1.BackColor = Color.White;
            soldItemListComponent1.Location = new Point(5, 67);
            soldItemListComponent1.Margin = new Padding(3, 5, 3, 5);
            soldItemListComponent1.Name = "soldItemListComponent1";
            soldItemListComponent1.RightToLeft = RightToLeft.Yes;
            soldItemListComponent1.Size = new Size(622, 401);
            soldItemListComponent1.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Stationery.jpg");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(5, 476);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(629, 183);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(MaincategoryList);
            panel1.Controls.Add(categoryProductListComponent);
            panel1.Controls.Add(SubCategoryList);
            panel1.Location = new Point(633, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 603);
            panel1.TabIndex = 6;
            // 
            // POSBookshopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1222, 692);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(soldItemListComponent1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "POSBookshopForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POSBookshopForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private POSApp.Components.CategoryComponent MaincategoryList;
        private POSApp.Components.CategoryComponent SubCategoryList;
        private Components.CategoryProductComponent categoryProductListComponent;
        private Components.SoldItemListComponent soldItemListComponent1;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}