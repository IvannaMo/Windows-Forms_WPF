using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int squareSize;
        private int checkerSize;
        private int checkerInsideSize;


        public Form()
        {
            InitializeComponent();


            squareSize = ClientSize.Width / 10;

            checkerSize = squareSize - 10;
            checkerInsideSize = checkerSize - 14;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics graphics = e.Graphics)
            using (SolidBrush lightSquare = new SolidBrush(Color.FromArgb(255, 255, 255)))
            using (SolidBrush darkSquare = new SolidBrush(Color.FromArgb(67, 71, 100)))
            using (SolidBrush darkChecker = new SolidBrush(Color.FromArgb(121, 132, 191)))
            using (SolidBrush darkCheckerInside = new SolidBrush(Color.FromArgb(81, 91, 145)))
            using (SolidBrush lightChecker = new SolidBrush(Color.FromArgb(191, 202, 223)))
            using (SolidBrush lightCheckerInside = new SolidBrush(Color.FromArgb(155, 170, 195)))
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (((j % 2 == 0) && (i % 2 == 0)) || ((j % 2 != 0) && (i % 2 != 0)))
                        {
                            graphics.FillRectangle(lightSquare, j * squareSize, i * squareSize, squareSize, squareSize);
                        }
                        else
                        {
                            graphics.FillRectangle(darkSquare, j * squareSize, i * squareSize, squareSize, squareSize);

                            if (i >= 0 && i < 4)
                            {
                                graphics.FillEllipse(darkChecker, j * squareSize + (squareSize - checkerSize) / 2, i * squareSize + (squareSize - checkerSize) / 2, checkerSize, checkerSize);
                                graphics.FillEllipse(darkCheckerInside, j * squareSize + (squareSize - checkerSize) / 2 + (checkerSize - checkerInsideSize) / 2, i * squareSize + (squareSize - checkerSize) / 2 + (checkerSize - checkerInsideSize) / 2, checkerInsideSize, checkerInsideSize);
                            }
                            else if (i >= 6 && i < 10)
                            {
                                graphics.FillEllipse(lightChecker, j * squareSize + (squareSize - checkerSize) / 2, i * squareSize + (squareSize - checkerSize) / 2, checkerSize, checkerSize);
                                graphics.FillEllipse(lightCheckerInside, j * squareSize + (squareSize - checkerSize) / 2 + (checkerSize - checkerInsideSize) / 2, i * squareSize + (squareSize - checkerSize) / 2 + (checkerSize - checkerInsideSize) / 2, checkerInsideSize, checkerInsideSize);
                            }
                        }
                    }
                }
            }
        }
    }
}
