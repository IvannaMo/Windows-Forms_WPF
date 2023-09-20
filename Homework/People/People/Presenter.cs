using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    internal class Presenter
    {
        private readonly IView view;
        private readonly IModel model;


        public Presenter(IView view, IModel model)
        {
            this.view = view;
            this.model = model;

            view.SaveEvent += new EventHandler<EventArgs>(OnSave);
            view.ShowAllEvent += new EventHandler<EventArgs>(OnShowAll);
            view.SearchEvent += new EventHandler<EventArgs>(OnSearch);
        }


        private void OnSave(object sender, EventArgs e)
        {
            try
            {
                model.PersonObj = new Person(view.PersonName, Convert.ToInt32(view.PersonAge));
                model.Save();

                MessageBox.Show("Your data was successfully saved!", "Message");
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void OnShowAll(object sender, EventArgs e)
        {
            model.ShowAll();


            view.PeopleInfo = "";
            view.PeopleInfo += "                                  People Info\r\n";

            int i = 1;
            foreach (Person person in model.PeopleList)
            {
                view.PeopleInfo += "• Person " + i + "\r\n";
                view.PeopleInfo += person.ToString();
                i++;
            }
        }


        private void OnSearch(object sender, EventArgs e)
        {
            if (view.PersonSearchName != "")
            {
                try
                {
                    model.PersonObj = new Person(view.PersonSearchName);
                    model.Search();

                    view.PeopleInfo = "";
                    view.PeopleInfo += "                                  Person Info\r\n";

                    if (model.PeopleList.Count() == 0)
                    {
                        view.PeopleInfo += "The person was not found!";
                    }
                    else
                    {
                        int i = 1;
                        foreach (Person person in model.PeopleList)
                        {
                            view.PeopleInfo += "• Person " + i + "\r\n";
                            view.PeopleInfo += person.ToString();
                            i++;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
