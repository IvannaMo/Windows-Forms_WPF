using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    internal class CustomPanel : Panel
    {
        public int BorderSize { get; set; }
        public int BorderRadius { get; set; }
        public Color BorderColor { get; set; }
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }


        public CustomPanel()
        {
            BorderSize = 0;
            BorderRadius = 0;
            BorderColor = Color.Gray;

            TopColor = Color.White;
            BottomColor = Color.White;
            Angle = 0;
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


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(ClientRectangle, TopColor, BottomColor, Angle))
            {
                e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
            }


            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);


            if (BorderRadius > 2)
            {
                using (GraphicsPath surfacePath = GetFigurePath(rectSurface, BorderRadius))
                {
                    Region = new Region(surfacePath);

                    if (BorderSize >= 1)
                    {
                        using (GraphicsPath borderPath = GetFigurePath(rectBorder, BorderRadius - BorderSize))
                        using (Pen borderPen = new Pen(BorderColor, BorderSize))
                        {
                            borderPen.Alignment = PenAlignment.Inset;
                            e.Graphics.DrawPath(borderPen, borderPath);
                        }
                    }
                }
            }
            else
            {
                Region = new Region(rectSurface);

                if (BorderSize >= 1)
                {
                    using (Pen borderPen = new Pen(BorderColor, BorderSize))
                    {
                        borderPen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }
    }
}