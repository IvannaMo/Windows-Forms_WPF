using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Magic_8_ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> answers;


        public MainWindow()
        {
            InitializeComponent();


            MouseDown += MainWindow_MouseDown;


            answers = new List<string>() { 
                "Бесспорно", "Предрешено", "Никаких сомнений", "Определённо да", "Можешь быть уверен в этом", 
                "Мне кажется — «да»", "Вероятнее всего", "Хорошие перспективы", "Знаки говорят — «да»",
                "Пока не ясно, попробуй снова", "Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять",
                "Даже не думай", "Мой ответ — «нет»", "По моим данным — «нет»", "Перспективы не очень хорошие", "Весьма сомнительно"
            };
        }


        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }


        private void minimizeBttn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void closeBttn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void askQuestionBttn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTxtBx.Text))
            {
                magicBall8.Visibility = Visibility.Hidden;


                answer.Height = 270;
                answer.Width = 270;

                int i = new Random().Next(0, answers.Count());
                answerTxtBlck.Text = answers.ElementAt(i).ToString();
            }
            else
            {
                magicBall8.Visibility = Visibility.Visible;


                answer.Height = 186;
                answer.Width = 186;

                answerTxtBlck.Text = "";
            }
        }
    }
}
