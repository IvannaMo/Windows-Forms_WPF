using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CV.Models;
using System.IO;
using CV.Commands;
using CV.Views;
using System.Net;
using System.Windows.Controls;
using System.Windows.Shapes;


namespace CV.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AgeProperty;
        private static readonly DependencyProperty MaritalStatusProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty EmailProperty;

        private static readonly DependencyProperty EnglishProperty;
        private static readonly DependencyProperty CPlusPlusProperty;
        private static readonly DependencyProperty CSharpProperty;
        private static readonly DependencyProperty JavaScriptProperty;

        private static readonly DependencyProperty SelectedCVProperty;


        public string FullName
        {
            get
            {
                return (string)GetValue(FullNameProperty);
            }
            set
            {
                SetValue(FullNameProperty, value);
            }
        }


        public string Age
        {
            get
            {
                return (string)GetValue(AgeProperty);
            }
            set
            {
                SetValue(AgeProperty, value);
            }
        }


        public string MaritalStatus
        {
            get
            {
                return (string)GetValue(MaritalStatusProperty);
            }
            set
            {
                SetValue(MaritalStatusProperty, value);
            }
        }


        public string Address
        {
            get
            {
                return (string)GetValue(AddressProperty);
            }
            set
            {
                SetValue(AddressProperty, value);
            }
        }


        public string Email
        {
            get
            {
                return (string)GetValue(EmailProperty);
            }
            set
            {
                SetValue(EmailProperty, value);
            }
        }


        public bool Engish
        {
            get
            {
                return (bool)GetValue(EnglishProperty);
            }
            set
            {
                SetValue(EnglishProperty, value);
            }
        }


        public bool CPlusPlus
        {
            get
            {
                return (bool)GetValue(CPlusPlusProperty);
            }
            set
            {
                SetValue(CPlusPlusProperty, value);
            }
        }


        public bool CSharp
        {
            get
            {
                return (bool)GetValue(CSharpProperty);
            }
            set
            {
                SetValue(CSharpProperty, value);
            }
        }


        public bool JavaScript
        {
            get
            {
                return (bool)GetValue(JavaScriptProperty);
            }
            set
            {
                SetValue(JavaScriptProperty, value);
            }
        }


        public CVPersonInfo SelectedCV
        {
            get
            {
                return (CVPersonInfo)GetValue(SelectedCVProperty);
            }
            set
            {
                SetValue(SelectedCVProperty, value);
            }
        }

        public ObservableCollection<CVPersonInfo> CVPersonInfoCollection { get; set; }


        DelegateCommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new DelegateCommand(SaveCV, CanSaveCV);
                }

                return saveCommand;
            }
        }


        DelegateCommand cancelCommand;

        public ICommand CancelCommand
        {
            get
            {
                if (cancelCommand == null)
                {
                    cancelCommand = new DelegateCommand(ClearCV, CanClearCV);
                }

                return cancelCommand;
            }
        }


        DelegateCommand showInfoCommand;

        public ICommand ShowInfoCommand
        {
            get
            {
                if (showInfoCommand == null)
                {
                    showInfoCommand = new DelegateCommand(ShowCV, CanShowCV);
                }

                return showInfoCommand;
            }
        }


        static MainWindowViewModel()
        {
            FullNameProperty = DependencyProperty.Register("FullName", typeof(string), typeof(MainWindowViewModel));
            AgeProperty = DependencyProperty.Register("Age", typeof(string), typeof(MainWindowViewModel));
            MaritalStatusProperty = DependencyProperty.Register("MaritalStatus", typeof(string), typeof(MainWindowViewModel));
            AddressProperty = DependencyProperty.Register("Address", typeof(string), typeof(MainWindowViewModel));
            EmailProperty = DependencyProperty.Register("Email", typeof(string), typeof(MainWindowViewModel));


            EnglishProperty = DependencyProperty.Register("English", typeof(bool), typeof(MainWindowViewModel));
            CPlusPlusProperty = DependencyProperty.Register("CPlusPlus", typeof(bool), typeof(MainWindowViewModel));
            CSharpProperty = DependencyProperty.Register("CSharp", typeof(bool), typeof(MainWindowViewModel));
            JavaScriptProperty = DependencyProperty.Register("JavaScript", typeof(bool), typeof(MainWindowViewModel));

            SelectedCVProperty = DependencyProperty.Register("SelectedCV", typeof(CVPersonInfo), typeof(MainWindowViewModel));
        }

        public MainWindowViewModel()
        {
            CVPersonInfoCollection = new ObservableCollection<CVPersonInfo>();

            if (File.Exists("SavedCV.json"))
            {
                string json = File.ReadAllText("SavedCV.json");
                CVPersonInfoCollection = JsonSerializer.Deserialize<ObservableCollection<CVPersonInfo>>(json);
            }
        }


        private void SaveCV(object obj)
        {
            CVPersonInfoCollection.Add(new CVPersonInfo(FullName, Age, MaritalStatus, Address, Email, Engish, CPlusPlus, CSharp, JavaScript));

            string json = JsonSerializer.Serialize(CVPersonInfoCollection);
            File.WriteAllText("SavedCV.json", json);

            MessageBox.Show("Data was successfully saved!");
        }

        private bool CanSaveCV(object obj)
        {
            return true;
        }


        private void ClearCV(object obj)
        {
            FullName = "";
            Age = "";
            MaritalStatus = "";
            Address = "";
            Email = "";

            Engish = false;
            CPlusPlus = false;
            CSharp = false;
            JavaScript = false;
        }

        private bool CanClearCV(object obj)
        {
            return true;
        }


        private bool CanShowCV(object obj)
        {
            return SelectedCV != null;
        }

        private void ShowCV(object obj)
        {
            DisplayCVWindow displayCVWindow = new DisplayCVWindow();
            DisplayCVViewModel displayCVViewModel = new DisplayCVViewModel(SelectedCV);
            displayCVWindow.DataContext = displayCVViewModel;
            displayCVWindow.Show();
        }
    }
}
