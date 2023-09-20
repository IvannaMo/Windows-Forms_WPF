using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace CustomControls
{
    internal class CustomButton : Button
    {
        public int BorderSize { get; set; }
        public int BorderRadius { get; set; }
        public Color BorderColor { get; set; }


        public CustomButton()
        {
            BorderSize = 0;
            BorderRadius = 0;
            BorderColor = Color.Gray;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(105, 40);
            BackColor = Color.LightGray;
            ForeColor = Color.Black;
        }


        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            float curveSize = radius * 2F;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            graphicsPath.AddArc(rect.Width - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            graphicsPath.AddArc(rect.Width - curveSize, rect.Height - curveSize, curveSize, curveSize, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Height - curveSize, curveSize, curveSize, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);


            int smoothSize = 2;
            if (BorderSize > 0)
            {
                smoothSize = BorderSize;
            }


            if (BorderRadius > 2)
            {
                using (GraphicsPath surfacePath = GetFigurePath(rectSurface, BorderRadius))
                using (Pen surfacePen = new Pen(Parent.BackColor, smoothSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Region = new Region(surfacePath);


                    pevent.Graphics.DrawPath(surfacePen, surfacePath);

                    if (BorderSize >= 1)
                    {
                        using (GraphicsPath borderPath = GetFigurePath(rectBorder, BorderRadius - BorderSize))
                        using (Pen borderPen = new Pen(BorderColor, BorderSize))
                        {
                            borderPen.Alignment = PenAlignment.Inset;
                            pevent.Graphics.DrawPath(borderPen, borderPath);
                        }
                    }
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                Region = new Region(rectSurface);

                if (BorderSize >= 1)
                {
                    using (Pen borderPen = new Pen(BorderColor, BorderSize))
                    {
                        borderPen.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }
    }
}
