using Notebook.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notebook
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel() { }


        public event PropertyChangedEventHandler? PropertyChanged;


        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new DelegateCommand(AddPerson, CanAlways);
                }

                return addCommand;
            }
        }

        private void AddPerson(object obj)
        {
        }
    }
}
