using Notebook.Commands;
using Notebook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Notebook
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private string? _fullName;
        private string? _address;
        private string? _phoneNumber;


        public string? FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
                RaisePropertyChanged(nameof(FullName));
            }
        }

        public string? Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                RaisePropertyChanged(nameof(Address));
            }
        }

        public string? PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged(nameof(PhoneNumber));
            }
        }


        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                RaisePropertyChanged(nameof(Contacts));
            }
        }


        private string? _selectedContact;
        public string? SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                RaisePropertyChanged(nameof(SelectedContact));
            }
        }


        private DelegateCommand? _AddPersonCommand;
        private DelegateCommand? _RemovePersonCommand;
        private DelegateCommand? _SaveCommand;
        private DelegateCommand? _LoadCommand;


        public MainWindowViewModel()
        {
            FullName = "";
            Address = "";
            PhoneNumber = "";
            SelectedContact = "";
        }


        private void Add(object? parameter)
        {
            Contacts.Add(new Contact(FullName, Address, PhoneNumber));
            FullName = "";
            Address = "";
            PhoneNumber = "";
        }

        private bool CanAdd(object? parameter)
        {
            if ((FullName == "") ||(PhoneNumber == "") || (Address == ""))
            { 
                return false; 
            }

            return true;
        }

        public ICommand AddPerson
        {
            get
            {
                if (_AddPersonCommand == null)
                {
                    _AddPersonCommand = new DelegateCommand(Add, CanAdd);
                }

                return _AddPersonCommand;
            }
        }


        private void Delete(object? parameter)
        {
            if ((SelectedContact != "") && (SelectedContact != null))
            {
                string[] separator = { "ФИО: ", "  Адрес: ", "  Телефон: " };
                string[] info = SelectedContact.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                Contact target = new Contact(info[0], info[1], info[2]);

                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (Contacts[i].FullName == target.FullName)
                    {
                        target = Contacts[i];
                        break;
                    }
                }
                if (target != null)
                {
                    Contacts.Remove(target);
                }
            }
        }

        private bool CanDelete(object? paramater)
        {
            if (SelectedContact == "") 
            { 
                return false; 
            }

            return true;
        }

        public ICommand DeletePerson
        {
            get
            {
                if (_RemovePersonCommand == null)
                {
                    _RemovePersonCommand = new DelegateCommand(Delete, CanDelete);
                }
                return _RemovePersonCommand;
            }
        }


        private void Save(object? parameter)
        {
            string json = JsonSerializer.Serialize(Contacts);
            File.WriteAllText("./Contact.json", json);

            MessageBox.Show("Контакты были успешно сохранены!");
        }

        private bool CanSave(object? parameter)
        {
            if (Contacts.Count > 0)
            {
                return true;
            }
            return false;
        }

        public ICommand SaveContacts
        {
            get
            {
                if (_SaveCommand == null)
                {
                    _SaveCommand = new DelegateCommand(Save, CanSave);
                }
                return _SaveCommand;
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
