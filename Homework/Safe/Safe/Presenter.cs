using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Safe
{
    class Presenter
    {
        private readonly IView view;
        private readonly IModel model;


        public Presenter(IView view, IModel model)
        {
            this.view = view;
            this.model = model;

            view.CEvent += new EventHandler<EventArgs>(ClearAll);
            view.OkEvent += new EventHandler<EventArgs>(OpenSafe);


            view.FormTitle = "Пароль сейфа: " + model.Password;
        }


        private void ClearAll(object sender, EventArgs e)
        {
            view.InputPassword = "";
        }

        private void OpenSafe(object sender, EventArgs e)
        {
            if (view.InputPassword.Length < 8)
            {
                MessageBox.Show("Необходимо ввести 8 цифр для того, чтобы открыть сейф", "Message");
            }
            else
            {
                if (model.CheckPassword(view.InputPassword))
                {
                    MessageBox.Show("Сейф открыт", "Message");
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Message");
                }
            }
        }
    }
}
