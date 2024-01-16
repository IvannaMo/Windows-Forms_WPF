using Color_Viewer.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Color_Viewer.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha;


        public int Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                RaisePropertyChanged(nameof(Red));
                ChangeCurrentColor();
            }
        }

        public int Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                RaisePropertyChanged(nameof(Green));
                ChangeCurrentColor();
            }
        }

        public int Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                RaisePropertyChanged(nameof(Blue));
                ChangeCurrentColor();
            }
        }

        public int Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
                RaisePropertyChanged(nameof(Alpha));
                ChangeCurrentColor();
            }
        }


        private ObservableCollection<Color> _colors;

        public ObservableCollection<Color> Colors
        {
            get
            {
                return _colors;
            }
            set
            {
                _colors = value;
                RaisePropertyChanged(nameof(Colors));
            }
        }


        private SolidColorBrush _currentColor;

        public SolidColorBrush CurrentColor
        {
            get
            {
                return _currentColor;
            }
            set
            {
                _currentColor = value;
                RaisePropertyChanged(nameof(CurrentColor));
            }
        }


        private DelegateCommand _AddColorCommand;
        public ICommand AddColor
        {
            get
            {
                if (_AddColorCommand == null)
                {
                    _AddColorCommand = new DelegateCommand(Add, CanAdd);
                }
                return _AddColorCommand;
            }
        }


        public MainViewModel()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
            Alpha = 255;

            _colors = new ObservableCollection<Color>();
            ChangeCurrentColor();
        }

        
        private void Add(object parameter)
        {
            _colors.Add(Color.FromArgb((byte)Alpha, (byte)Red, (byte)Green, (byte)Blue));
            Red = 0;
            Green = 0;
            Blue = 0;
            Alpha = 255;
        }

        private bool CanAdd(object parameter)
        {
            return true;
        }


        private void ChangeCurrentColor()
        {
            CurrentColor = new SolidColorBrush(Color.FromArgb((byte)Alpha, (byte)Red, (byte)Green, (byte)Blue));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
