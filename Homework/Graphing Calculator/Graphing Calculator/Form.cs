using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Graphing_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private double zoom;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public Form()
        {
            InitializeComponent();


            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));


            minimizePctrBx.Image = Image.FromFile("../../Images/Minimize.bmp");
            closePctrBx.Image = Image.FromFile("../../Images/Close.bmp");


            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("../../Fonts/Golca Bold.otf");
            fontCollection.AddFontFile("../../Fonts/Golca Medium.otf");
            fontCollection.AddFontFile("../../Fonts/Inter Bold.ttf");

            enterFunctionLbl.Font = new Font(fontCollection.Families[0], 15.5F);
            functionCstmTxtBx.Font = new Font(fontCollection.Families[1], 14.5F);
            drawCstmBttn.Font = new Font(fontCollection.Families[0], 11F);
            zoomInCstmBttn.Font = new Font(fontCollection.Families[1], 21F);
            resetCstmBttn.Font = new Font(fontCollection.Families[2], 12F);
            zoomOutCstmBttn.Font = new Font(fontCollection.Families[1], 19F);
            yLbl.Font = new Font(fontCollection.Families[0], 12.5F);
            xLbl.Font = new Font(fontCollection.Families[0], 12.5F);


            functionCstmTxtBx.ChangedText += functionCstmTxtBx_ChangedText;


            Bitmap bitmap = new Bitmap(graphPctrBx.Width, graphPctrBx.Height);


            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Pen gridPen = new Pen(Color.FromArgb(247, 248, 248), 3))
            using (Pen axisPen = new Pen(Color.FromArgb(232, 240, 236), 5))
            using (SolidBrush axisCenter = new SolidBrush(Color.FromArgb(204, 224, 213)))
            {
                for (int i = 1; i <= 15; i++)
                {
                    graphics.DrawLine(gridPen, 40.3F * i, 0, 40.3F * i, graphPctrBx.Height);
                    graphics.DrawLine(gridPen, 0, 40.3F * i, graphPctrBx.Width, 40.3F * i);
                }

                graphics.DrawLine(axisPen, 322, 0, 322, graphPctrBx.Height);
                graphics.DrawLine(axisPen, 0, 322, graphPctrBx.Width, 322);
                graphics.FillEllipse(axisCenter, 316, 316, 12, 12);
            }

            graphPctrBx.Image = bitmap;


            zoom = 0;
        }


        private void minimizePctrBx_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void functionCstmTxtBx_ChangedText(object sender, EventArgs e)
        {
            if (!functionCstmTxtBx.Texts.StartsWith("y = "))
            {
                functionCstmTxtBx.Texts = "y = ";
                functionCstmTxtBx.Focus();
                functionCstmTxtBx.SelectionStart = 4;
                functionCstmTxtBx.SelectionLength = 0;
            }
        }


        private void drawCstmBttn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(graphPctrBx.Width, graphPctrBx.Height);


            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Pen gridPen = new Pen(Color.FromArgb(247, 248, 248), 3))
            using (Pen axisPen = new Pen(Color.FromArgb(232, 240, 236), 5))
            using (SolidBrush axisCenter = new SolidBrush(Color.FromArgb(204, 224, 213)))
            using (GraphicsPath graphicsPath = new GraphicsPath())
            using (Pen graphPen = new Pen(Color.FromArgb(165, 229, 197), 5))
            using (SolidBrush graphBrush = new SolidBrush(Color.FromArgb(165, 229, 197)))
            {
                for (int i = 1; i <= 15; i++)
                {
                    graphics.DrawLine(gridPen, 40.3F * i, 0, 40.3F * i, graphPctrBx.Height);
                    graphics.DrawLine(gridPen, 0, 40.3F * i, graphPctrBx.Width, 40.3F * i);
                }

                graphics.DrawLine(axisPen, 322, 0, 322, graphPctrBx.Height);
                graphics.DrawLine(axisPen, 0, 322, graphPctrBx.Width, 322);
                graphics.FillEllipse(axisCenter, 316, 316, 12, 12);



                graphics.ScaleTransform(1, -1);
                graphics.TranslateTransform(322, 322, MatrixOrder.Append);


                string function = functionCstmTxtBx.Texts;

                Regex constantFunction = new Regex(@"^y = (\d+)$");
                Regex identityFunction = new Regex(@"^y = x$");
                Regex negIdentityFunction = new Regex(@"^y = -x$");
                Regex absoluteValueFunction = new Regex(@"^y = \|x\|$");
                Regex quadraticFunction = new Regex(@"^y = x\^2$");
                Regex cubicFunction = new Regex(@"^y = x\^3$");
                Regex squareRootFunction = new Regex(@"^y = sqrt\(x\)$");
                Regex cubeRootFunction = new Regex(@"^y = cbrt\(x\)$");
                if (constantFunction.Match(function).Success)
                {
                    for (int i = 0; i <= 324; i++)
                    {
                        graphics.FillEllipse(graphBrush, i - graphPen.Width / 2, Convert.ToInt32(constantFunction.Match(function).Groups[1].Value) - graphPen.Width / 2, 5, 5);
                        graphics.FillEllipse(graphBrush, -(i - graphPen.Width / 2), Convert.ToInt32(constantFunction.Match(function).Groups[1].Value) - graphPen.Width / 2, 5, 5);
                    }
                }
                else if (identityFunction.Match(function).Success)
                {
                    for (int i = 0; i <= 324; i++)
                    {
                        graphics.FillEllipse(graphBrush, i - graphPen.Width / 2, i - graphPen.Width / 2, 5, 5);
                        graphics.FillEllipse(graphBrush, -(i - graphPen.Width / 2), -(i - graphPen.Width / 2), 5, 5);
                    }
                }
                else if (negIdentityFunction.Match(function).Success)
                {
                    for (int i = 0; i <= 324; i++)
                    {
                        graphics.FillEllipse(graphBrush, -i - graphPen.Width / 2, i - graphPen.Width / 2, 5, 5);
                        graphics.FillEllipse(graphBrush, i - graphPen.Width / 2, -i - graphPen.Width / 2, 5, 5);
                    }
                }
                else if (absoluteValueFunction.Match(function).Success)
                {
                    for (int i = 0; i <= 324; i++)
                    {
                        graphics.FillEllipse(graphBrush, -i - graphPen.Width / 2, i - graphPen.Width / 2, 5, 5);
                        graphics.FillEllipse(graphBrush, i - graphPen.Width / 2, i - graphPen.Width / 2, 5, 5);
                    }
                }
                else if (quadraticFunction.Match(function).Success)
                {
                    List<Point> points = new List<Point>();
                    for (int i = 0; i <= 324; i++)
                    {
                        points.Add(new Point(i, Convert.ToInt32(Math.Pow(i, 2))));
                    }

                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);


                    points.Clear();
                    for (int i = 0; i <= 324; i++)
                    {
                        points.Add(new Point(-i, Convert.ToInt32(Math.Pow(-i, 2))));
                    }

                    graphicsPath.Reset();
                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);
                }
                else if (cubicFunction.Match(function).Success)
                {
                    List<Point> points = new List<Point>();
                    for (int i = 0; Math.Pow(i, 3) <= 343; i++)
                    {
                        points.Add(new Point(i, Convert.ToInt32(Math.Pow(i, 3))));
                    }

                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);


                    points.Clear();
                    for (int i = 0; Math.Pow(i, 3) >= -343; i--)
                    {
                        points.Add(new Point(i, Convert.ToInt32(Math.Pow(i, 3))));
                    }

                    graphicsPath.Reset();
                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);
                }
                else if (squareRootFunction.Match(function).Success)
                {
                    List<Point> points = new List<Point>();
                    for (int i = 0; Math.Sqrt(i) <= 324; i++)
                    {
                        points.Add(new Point(i, Convert.ToInt32(Math.Sqrt(i))));
                    }

                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);
                }
                else if (cubeRootFunction.Match(function).Success)
                {
                    List<Point> points = new List<Point>();
                    for (int i = 0; Math.Pow(i, 0.3) <= 6; i++)
                    {
                        points.Add(new Point(i, Convert.ToInt32(Math.Pow(i, 0.3))));
                    }

                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);


                    points.Clear();
                    for (int i = 0; Math.Pow(i, 0.3) <= 6; i++)
                    {
                        points.Add(new Point(-i, -Convert.ToInt32(Math.Pow(i, 0.3))));
                    }

                    graphicsPath.Reset();
                    graphicsPath.StartFigure();
                    graphicsPath.AddLines(points.ToArray());
                    graphics.DrawPath(graphPen, graphicsPath);
                }
            }

            graphPctrBx.Image = bitmap;
        }


        private void zoomInCstmBttn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(graphPctrBx.Image, Convert.ToInt32(graphPctrBx.Image.Width * 1.2), Convert.ToInt32(graphPctrBx.Image.Height * 1.2));
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            zoom++;

            graphPctrBx.Image = bitmap;
        }

        private void resetCstmBttn_Click(object sender, EventArgs e)
        {
            while (zoom != 0) {
                Bitmap bitmap = new Bitmap(graphPctrBx.Image, Convert.ToInt32(graphPctrBx.Image.Width / 1.2), Convert.ToInt32(graphPctrBx.Image.Height / 1.2));
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                zoom--;

                graphPctrBx.Image = bitmap;
            }
        }

        private void zoomOutCstmBttn_Click(object sender, EventArgs e)
        {
            if (zoom > 0)
            {
                Bitmap bitmap = new Bitmap(graphPctrBx.Image, Convert.ToInt32(graphPctrBx.Image.Width / 1.2), Convert.ToInt32(graphPctrBx.Image.Height / 1.2));
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                zoom--;

                graphPctrBx.Image = bitmap;
            }
        }
    }
}
