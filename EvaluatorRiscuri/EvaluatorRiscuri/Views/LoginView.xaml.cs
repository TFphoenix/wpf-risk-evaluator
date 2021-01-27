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

namespace EvaluatorRiscuri.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private readonly Shell _shell;

        public LoginView()
        {
            InitializeComponent();
            _shell = (Shell)Application.Current.MainWindow;
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            bool loginResult = _shell.UserData.LoginUser(EmailTextBox.Text, PasswordBox.Password);

            if (loginResult)
            {
                ErrorLabel.Visibility = Visibility.Hidden;

                EmailTextBox.Clear();
                PasswordBox.Clear();

                _shell.GoTo(Shell.MENU_VIEW);
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
            }
        }

        private void Register_OnClick(object sender, RoutedEventArgs e)
        {
            SuccessLabel.Visibility = Visibility.Hidden;
            ErrorLabel.Visibility = Visibility.Hidden;
            _shell.RegisterView.ErrorLabel.Visibility = Visibility.Hidden;

            _shell.GoTo(Shell.REGISTER_VIEW);
        }
    }
}
