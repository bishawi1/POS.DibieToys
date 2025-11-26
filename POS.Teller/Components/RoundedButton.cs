using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace POS.Teller.Components
{
    public class RoundedButton:Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        
        [Category("Radius Button Advanced")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        { 
            get 
            {
                return borderSize;
            }
            set 
            {
                borderSize = value;
                this.Invalidate();
            } 
        }
        [Category("Radius Button Advanced")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius 
        { 
            get
            {
                return borderRadius;
            }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;
                else
                    borderRadius = this.Height;
                this.Invalidate();
            }  
        }
        [Category("Radius Button Advanced")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor 
        {
            get 
            {
                return borderColor;
            } 
            set 
            {
                borderColor = value;
                this.Invalidate();
            } 
        }
        [Category("Radius Button Advanced")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BackgroundColor 
        {
            get 
            {
                return this.BackColor;
            } 
            set
            {
                this.BackColor = value; 
            }
        }
        [Category("Radius Button Advanced")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TextColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }
        public RoundedButton()
        {
            this.FlatStyle=FlatStyle.Flat;
            this.FlatAppearance.BorderSize= borderSize;
            this.Size = new(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(rect.X,rect.Y,radius,radius,180,90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(1,1,this.Width-.8F,this.Height-1);
            if (BorderRadius > 2)// Roundec Button
            {
                using(GraphicsPath pathSurface=GetFigurePath(rectSurface,BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius-1))
                using(Pen penSurface=new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button Surface
                    this.Region = new Region(pathSurface);
                    // Button Border
                    pevent.Graphics.DrawPath(penSurface,pathSurface);
                    // draw control border
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder,pathBorder);
                }
            }
            else//Normal Button
            {
                this.Region=new Region(rectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.Parent!= null)
            this.Parent.BackColorChanged += new EventHandler(container_BackgroundChanged);
        }

        private void container_BackgroundChanged(object? sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
