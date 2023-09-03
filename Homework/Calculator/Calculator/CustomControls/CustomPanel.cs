using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class CustomPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(ClientRectangle, TopColor, BottomColor, Angle))
            using (Graphics graphics = e.Graphics)
            {
                graphics.FillRectangle(gradientBrush, ClientRectangle);
            }
        }
    }
}
