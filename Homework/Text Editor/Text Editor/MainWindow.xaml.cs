using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Text_Editor
{
    public partial class MainWindow : Window
    {
        private bool _isChanged;
        private string _versionType;


        public MainWindow()
        {
            InitializeComponent();


            CommandBinding binding;
            binding = new CommandBinding(ApplicationCommands.Close);
            binding.Executed += CloseCommand;
            CommandBindings.Add(binding);


            _isChanged = false;
            _versionType = "none";
        }


        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ShowRegisterWindow();
        }


        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Clear();
            _isChanged = false;
        }

        private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;
                try
                {
                    string fileContent = File.ReadAllText(selectedFilePath);
                    textBox.Text = fileContent;
                    _isChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SaveCommand(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                string contentToSave = textBox.Text;
                try
                {
                    File.WriteAllText(filePath, contentToSave);
                    _isChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }


        private void textBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            _isChanged = true;
        }


        private void Command_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _isChanged;
        }


        private void EnableFileItems()
        {
            newMenuItem.IsEnabled = true;
            openMenuItem.IsEnabled = true;
            saveMenuItem.IsEnabled = true;

            CommandBinding binding;
            binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += NewCommand;
            binding.CanExecute += Command_CanExecute;
            CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Open);
            binding.Executed += OpenCommand;
            binding.CanExecute += Command_CanExecute;
            CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Save);
            binding.Executed += SaveCommand;
            binding.CanExecute += Command_CanExecute;
            CommandBindings.Add(binding);
        }

        private void EnableEditItems()
        {
            cutMenuItem.IsEnabled = true;
            copyMenuItem.IsEnabled = true;
            pasteMenuItem.IsEnabled = true;
        }

        private void EnableAllMenuItems()
        {
            EnableFileItems();
            EnableEditItems();
        }


        private void DisableFileItems()
        {
            newMenuItem.IsEnabled = false;
            openMenuItem.IsEnabled = false;
            saveMenuItem.IsEnabled = false;

            CommandBindings.Clear();
        }

        private void DisableEditItems()
        {
            cutMenuItem.IsEnabled = false;
            copyMenuItem.IsEnabled = false;
            pasteMenuItem.IsEnabled = false;
        }

        private void DisableAllMenuItems()
        {
            DisableFileItems();
            DisableEditItems();
        }


        private void UpdateMenu()
        {
            if ((_versionType == "none") || (_versionType == null))
            {
                DisableAllMenuItems();
            }
            else if (_versionType == "trial")
            {
                EnableFileItems();
                DisableEditItems();
            }
            else if (_versionType == "pro")
            {
                EnableAllMenuItems();
            }
        }

        private void CheckKey()
        {
            UpdateMenu();
        }


        private void ShowRegisterWindow()
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Owner = this;
            registerWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            IsEnabled = false;

            registerWindow.Closed += (s, eventArgs) => {
                IsEnabled = true;
                if (registerWindow.DialogResult == false)
                {
                    _versionType = registerWindow.KeyValue;
                    CheckKey();
                }
            };

            registerWindow.ShowDialog();
        }

        private void MenuItemClick(object sender, RoutedEventArgs e)
        {
            ShowRegisterWindow();
        }
    }
}