using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ray.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged, ICloseable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        private WindowState _currentWindowState;
        public WindowState CurrentWindowState
        {
            get
            {
                return _currentWindowState;
            }
            set
            {
                _currentWindowState = value;
                OnPropertyChanged("CurrentWindowState");
            }
        }


        public Action Close { get; set; }
    }


    public interface ICloseable
    {
        Action Close { get; set; }
    }
}
