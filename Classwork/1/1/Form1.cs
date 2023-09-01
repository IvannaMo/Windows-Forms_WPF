using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace _1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();


            genderComboBox.Items.Add("Мужской");
            genderComboBox.Items.Add("Женский");
            genderComboBox.Items.Add("Не указан");


            for(int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i.ToString());
            }

            for (int i = 2023; i >= 1900; i--)
            {
                yearComboBox.Items.Add(i.ToString());
            }


            civilStatusComboBox.Items.Add("Не женат/Не замужем");
            civilStatusComboBox.Items.Add("Женат/Замужем");
            civilStatusComboBox.Items.Add("Разведён/Разведена");
            civilStatusComboBox.Items.Add("Вдовец/Вдова");
        }


        private void ClearForm()
        {
            surnameTextBox.Clear();
            nameTextBox.Clear();
            patronymicTextBox.Clear();
            adInfoTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            dayComboBox.SelectedIndex = -1;
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
            civilStatusComboBox.SelectedIndex = -1;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(surnameTextBox.Text) ||
                string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(patronymicTextBox.Text) ||
                string.IsNullOrEmpty(adInfoTextBox.Text) ||
                (genderComboBox.SelectedIndex == -1) ||
                (dayComboBox.SelectedIndex == -1) ||
                (monthComboBox.SelectedIndex == -1) ||
                (yearComboBox.SelectedIndex == -1) ||
                (civilStatusComboBox.SelectedIndex == -1)
               )
            {
                return;
            }


            Person person = new Person(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, genderComboBox.Text, new DateTime(Convert.ToInt32(yearComboBox.Text), Convert.ToInt32(monthComboBox.Text), Convert.ToInt32(dayComboBox.Text)), civilStatusComboBox.Text, adInfoTextBox.Text);


            FileStream fileStream = new FileStream("../../Data.xml", FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            xmlSerializer.Serialize(fileStream, person);

            fileStream.Close();


            MessageBox.Show("Данные были успешно сохранены!", "Сообщение", MessageBoxButtons.OK);


            ClearForm();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ClearForm();


            FileStream fileStream = new FileStream("../../Data.xml", FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            Person person = (Person)xmlSerializer.Deserialize(fileStream);

            fileStream.Close();


            surnameTextBox.Text = person.Surname;
            nameTextBox.Text = person.Name;
            patronymicTextBox.Text = person.Patronymic;
            adInfoTextBox.Text = person.AdInfo;

            genderComboBox.SelectedIndex = genderComboBox.Items.IndexOf(person.Gender);
            dayComboBox.SelectedIndex = dayComboBox.Items.IndexOf(person.BirthDate.Day.ToString());
            monthComboBox.SelectedIndex = monthComboBox.Items.IndexOf(person.BirthDate.Month.ToString());
            yearComboBox.SelectedIndex = yearComboBox.Items.IndexOf(person.BirthDate.Year.ToString());
            civilStatusComboBox.SelectedIndex = civilStatusComboBox.Items.IndexOf(person.CivilStatus);


            MessageBox.Show("Данные были успешно загружены!", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
