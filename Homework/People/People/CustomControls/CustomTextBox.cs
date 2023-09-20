using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CustomControls
{
    public partial class CustomTextBox : UserControl
    {
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = SystemColors.ControlDark;
        private Color borderFocusColor = SystemColors.ControlDarkDark;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private bool isFocused = false;
        private bool underlinedStyle = false;


        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                if (value >= 0)
                {
                    borderSize = value;
                    Refresh();
                }
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Refresh();
                }
            }
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Refresh();
            }
        }

        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }

        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
            }
        }

        public string Texts
        {
            get
            {
                if (isPlaceholder)
                {
                    return "";
                }
                else
                {
                    return textBox1.Text;
                }
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                if ((!isPlaceholder) && (isPasswordChar))
                {
                    textBox1.PasswordChar = '*';
                }
            }
        }

        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                Refresh();
            }
        }

        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }

        public int PaddingLeft
        {
            get
            {
                return textBox1.Left;
            }
            set
            {
                textBox1.Left = value;
                Refresh();
            }
        }

        public int PaddingTop
        {
            get
            {
                return textBox1.Top;
            }
            set
            {
                textBox1.Top = value;
                Refresh();
            }
        }

        public int SelectionStart
        {
            get
            {
                return textBox1.SelectionStart;
            }
            set
            {
                textBox1.SelectionStart = value;
            }
        }

        public int SelectionLength
        {
            get
            {
                return textBox1.SelectionLength;
            }
            set
            {
                textBox1.SelectionLength = value;
            }
        }


        public event EventHandler ChangedText;


        public CustomTextBox()
        {
            InitializeComponent();
        }


        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            float curveSize = radius * 2F;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            graphicsPath.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            graphicsPath.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Graphics graphics = e.Graphics;

            if (borderRadius > 1)
            {
                Rectangle rectBorder = Rectangle.Inflate(ClientRectangle, -borderSize, -borderSize);
                int smoothSize = 1;
                if (borderSize > 0)
                {
                    smoothSize = borderSize;
                }

                using (GraphicsPath pathBorderSmooth = GetFigurePath(ClientRectangle, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15)
                    {
                        SetTextBoxRoundedRegion();
                    }

                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;

                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;
                    }


                    if (underlinedStyle)
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);

                        if (borderSize > 0)
                        {
                            graphics.SmoothingMode = SmoothingMode.None;
                            graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                        }
                    }
                    else
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);

                        if (borderSize > 0)
                        {
                            graphics.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;
                    }

                    if (underlinedStyle)
                    {
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    }
                    else
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                    }
                }
            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            textBox1.Width = Width - borderSize * 2 - PaddingLeft * 2;
            textBox1.Height = Height - borderSize * 2;
        }


        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && (placeholderText != ""))
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }


        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath path;

            if (Multiline)
            {
                path = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(path);
            }
            else
            {
                path = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(path);
            }

            path.Dispose();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ChangedText != null) { 
                ChangedText.Invoke(sender, e);
            }
        }
    }
}
