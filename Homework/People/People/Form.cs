using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form : System.Windows.Forms.Form, IView
    {
        public string PersonName 
        {
            get 
            { 
                return nameCstmTxtBx.Texts.Trim(); 
            }
            set
            {
                nameCstmTxtBx.Texts = value.ToString();
            } 
        }

        public int PersonAge 
        {
            get
            {
                return Convert.ToInt32(ageCstmTxtBx.Texts.Trim());
            }
            set
            {
                ageCstmTxtBx.Texts = value.ToString();
            }
        }

        public string PeopleInfo
        {
            get 
            { 
                return peopleInfoTxtBx.Text; 
            }
            set
            {
                peopleInfoTxtBx.Text = value;
            }
        }

        public string PersonSearchName
        {
            get
            {
                return searchCstmTxtBx.Texts.Trim();
            }
            set
            {
                searchCstmTxtBx.Texts = value.ToString();
            }
        }


        public event EventHandler<EventArgs> SaveEvent;
        public event EventHandler<EventArgs> ShowAllEvent;
        public event EventHandler<EventArgs> SearchEvent;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);


        public Form()
        {
            InitializeComponent();


            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));


            minimizePctrBx.Image = Bitmap.FromFile("../../Images/Minimize.bmp");
            closePctrBx.Image = Bitmap.FromFile("../../Images/Close.bmp");


            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("../../Fonts/Axiforma Semi Bold.ttf");

            nameLbl.Font = new Font(privateFontCollection.Families[0], 14);
            nameCstmTxtBx.Font = new Font(privateFontCollection.Families[0], 11);
            ageLbl.Font = new Font(privateFontCollection.Families[0], 14);
            ageCstmTxtBx.Font = new Font(privateFontCollection.Families[0], 11);

            saveCstmBttn.Font = new Font(privateFontCollection.Families[0], 11);
            showAllCstmBttn.Font = new Font(privateFontCollection.Families[0], 11);

            peopleInfoTxtBx.Font = new Font(privateFontCollection.Families[0], 11);

            searchCstmTxtBx.Font = new Font(privateFontCollection.Families[0], 11);
            searchCstmBttn.Font = new Font(privateFontCollection.Families[0], 8);
        }


        private void minimizePctrBx_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closePctrBx_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void saveCstmBttn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void showAllCstmBttn_Click(object sender, EventArgs e)
        {
            ShowAllEvent?.Invoke(this, EventArgs.Empty);
        }


        private void searchCstmBttn_Click(object sender, EventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
