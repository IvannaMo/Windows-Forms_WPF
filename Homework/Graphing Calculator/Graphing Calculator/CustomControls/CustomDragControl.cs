﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing_Calculator.CustomControls
{
    internal class CustomDragControl : Component
    {
        private Control handleControl;


        public Control SelectControl
        {
            get
            {
                return handleControl;
            }
            set
            {
                handleControl = value;
                handleControl.MouseDown += new MouseEventHandler(DragForm_MouseDown);
            }
        }


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = false;
            if (e.Button == MouseButtons.Left)
            {
                flag = true;
            }

            if (flag)
            {
                ReleaseCapture();
                SendMessage(SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
