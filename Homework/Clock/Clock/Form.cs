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

namespace Clock
{
    public partial class Form : System.Windows.Forms.Form
    {
        private SolidBrush deepBlueBrush;
        private SolidBrush redBrush;
        private SolidBrush darkGreyBrush;
        private Pen deepBluePen;
        private Pen deepBlueThinPen;
        private Pen deepBlueThickPen;
        private Pen redPen;

        private int secondHand;
        private int minuteHand;
        private int hourHand;
        private int cX;
        private int cY;


        public Form()
        {
            InitializeComponent();


            secondHand = minuteHand = 120;
            hourHand = 80;
            cX = cY = 222;
            

            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(@"../../Fonts/DS-Digital Normal.ttf");
            timeLbl.Font = new Font(fontCollection.Families[0], 40);


            clockPctrBx.Left = (ClientRectangle.Width - clockPctrBx.ClientRectangle.Width) / 2;
            digitalClockPctrBx.Left = (ClientRectangle.Width - digitalClockPctrBx.ClientRectangle.Width) / 2;


            deepBlueBrush = new SolidBrush(Color.FromArgb(0, 69, 103));
            redBrush = new SolidBrush(Color.FromArgb(247, 83, 83));
            darkGreyBrush = new SolidBrush(Color.FromArgb(39, 39, 39));

            deepBluePen = new Pen(Color.FromArgb(0, 69, 103), 14);
            deepBluePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            deepBluePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            deepBlueThinPen = new Pen(Color.FromArgb(0, 69, 103), 6);
            deepBlueThinPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            deepBlueThinPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            deepBlueThickPen = new Pen(Color.FromArgb(0, 69, 103), 18);
            deepBlueThickPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            deepBlueThickPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            redPen = new Pen(Color.FromArgb(247, 83, 83), 6);
            redPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            redPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }


        private GraphicsPath RoundedRectangle(Rectangle rect, int radius)
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


        private Point secondMinuteHandPoint(int value, int length)
        {
            Point point = new Point();
            value *= 6;

            if (value >= 0 && value <= 180)
            {
                point.X = cX + (int)(length * Math.Sin(Math.PI * value / 180));
                point.Y = cY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                point.X = cX - (int)(length * -Math.Sin(Math.PI * value / 180));
                point.Y = cY - (int)(length * Math.Cos(Math.PI * value / 180));
            }

            return point;
        }

        private Point hoursHandPoint(int hourValue, int minuteValue, int length)
        {
            Point point = new Point();
            int value = (int)((hourValue * 30) + (minuteValue * 0.5));

            if (value >= 0 && value <= 180)
            {
                point.X = cX + (int)(length * Math.Sin(Math.PI * value / 180));
                point.Y = cY - (int)(length * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                point.X = cX - (int)(length * -Math.Sin(Math.PI * value / 180));
                point.Y = cY - (int)(length * Math.Cos(Math.PI * value / 180));
            }

            return point;
        }


        private void clockPctrBx_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(deepBlueBrush, clockPctrBx.ClientRectangle);
            e.Graphics.FillEllipse(Brushes.White, (clockPctrBx.ClientRectangle.Width - 384) / 2, (clockPctrBx.ClientRectangle.Height - 384) / 2, 384, 384);


            e.Graphics.DrawLine(deepBluePen, 46, 222, 78, 222);
            e.Graphics.DrawLine(deepBluePen, 366, 222, 398, 222);
            e.Graphics.DrawLine(deepBluePen, 222, 46, 222, 78);
            e.Graphics.DrawLine(deepBluePen, 222, 366, 222, 398);


            e.Graphics.DrawLine(deepBlueThinPen, 133, 76, 144, 92);
            e.Graphics.DrawLine(deepBlueThinPen, 71, 134, 88, 144);

            e.Graphics.DrawLine(deepBlueThinPen, 300, 92, 311, 76);
            e.Graphics.DrawLine(deepBlueThinPen, 356, 144, 373, 134);


            e.Graphics.DrawLine(deepBlueThinPen, 356, 294, 373, 304);
            e.Graphics.DrawLine(deepBlueThinPen, 300, 352, 311, 368);

            e.Graphics.DrawLine(deepBlueThinPen, 133, 368, 144, 352);
            e.Graphics.DrawLine(deepBlueThinPen, 71, 304, 88, 294);


            Point hourHandPoint = hoursHandPoint(DateTime.Now.Hour % 12, DateTime.Now.Minute, hourHand);
            e.Graphics.DrawLine(deepBlueThickPen, new Point(cX, cY), new Point(hourHandPoint.X, hourHandPoint.Y));

            Point minuteHandPoint = secondMinuteHandPoint(DateTime.Now.Minute, minuteHand);
            e.Graphics.DrawLine(deepBlueThickPen, new Point(cX, cY), new Point(minuteHandPoint.X, minuteHandPoint.Y));

            Point secondHandPoint = secondMinuteHandPoint(DateTime.Now.Second, secondHand);
            e.Graphics.DrawLine(redPen, new Point(cX, cY), new Point(secondHandPoint.X, secondHandPoint.Y));


            e.Graphics.FillEllipse(deepBlueBrush, (clockPctrBx.ClientRectangle.Width - 44) / 2, (clockPctrBx.ClientRectangle.Height - 44) / 2, 44, 44);
            e.Graphics.FillEllipse(redBrush, (clockPctrBx.ClientRectangle.Width - 26) / 2, (clockPctrBx.ClientRectangle.Height - 26) / 2, 26, 26);
        }


        private void digitalClockPctrBx_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(Brushes.White, RoundedRectangle(new Rectangle(0, 0, digitalClockPctrBx.Width, digitalClockPctrBx.Height - 8), 10));
            e.Graphics.FillPath(darkGreyBrush, RoundedRectangle(new Rectangle(11, 11, digitalClockPctrBx.Width - 11, digitalClockPctrBx.Height - 19), 4));

            e.Graphics.FillRectangle(darkGreyBrush, 27, 112, 19, 8);
            e.Graphics.FillRectangle(darkGreyBrush, 188, 112, 19, 8);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("HH:mm");
            Refresh();
        }
    }
}
