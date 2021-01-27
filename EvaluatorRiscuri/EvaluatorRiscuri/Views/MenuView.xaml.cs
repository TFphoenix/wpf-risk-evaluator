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
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        private readonly Shell _shell;

        public MenuView()
        {
            InitializeComponent();
            _shell = (Shell)Application.Current.MainWindow;
            IsVisibleChanged += MenuView_IsVisibleChanged;
        }

        private void MenuView_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // On appearing
            if (true == (bool)e.NewValue)
            {
                UserNameLabel.Content = _shell.UserData.ConnectedUser.Name;
            }
            // On disappearing
            else
            {

            }
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.LOGIN_VIEW);
        }
    }
}
