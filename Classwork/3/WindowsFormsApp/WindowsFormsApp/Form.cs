using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool click;
        private int buttonRadius;
        private LinearGradientBrush baseBrush;
        private LinearGradientBrush shadowBrush;


        public Form()
        {
            InitializeComponent();


            click = false;


            buttonRadius = 7;


            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("../../Fonts/Golca SemiBold.otf");

            button.Font = new Font(privateFontCollection.Families[0], 12);


            baseBrush = new LinearGradientBrush(button.ClientRectangle, Color.FromArgb(119, 238, 216), Color.FromArgb(158, 171, 228), -315F);
            shadowBrush = new LinearGradientBrush(button.ClientRectangle, Color.FromArgb(73, 201, 191), Color.FromArgb(107, 123, 208), -315F);
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


        private void button_Paint(object sender, PaintEventArgs e)
        {
            if (!click)
            {
                Rectangle baseRectangle = new Rectangle(0, 0, button.Width, button.Height - 10);
                Rectangle shadowRectangle = new Rectangle(0, button.Height - 10, button.Width, 10);

                e.Graphics.FillRectangle(baseBrush, baseRectangle);
                e.Graphics.FillRectangle(shadowBrush, shadowRectangle);


                Size stringSize = TextRenderer.MeasureText(button.Text, button.Font);
                e.Graphics.DrawString(button.Text, button.Font, Brushes.White, (button.Width - stringSize.Width) / 2, ((button.Height - 10) - stringSize.Height) / 2);


                button.Region = new Region(GetFigurePath(button.ClientRectangle, buttonRadius));
            }
            else
            {
                e.Graphics.FillRectangle(baseBrush, button.ClientRectangle);


                Size stringSize = TextRenderer.MeasureText(button.Text, button.Font);
                e.Graphics.DrawString(button.Text, button.Font, Brushes.White, (button.Width - stringSize.Width) / 2, ((button.Height) - stringSize.Height) / 2);


                button.Region = new Region(GetFigurePath(button.ClientRectangle, buttonRadius));
            }
        }


        private async void button_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                click = true;


                button.Height -= 10;
                button.Top += 10;

                button.Refresh();
                await Task.Delay(100);
            }


            click = false;


            button.Height += 10;
            button.Top -= 10;

            button.Refresh();
        }
    }
}
