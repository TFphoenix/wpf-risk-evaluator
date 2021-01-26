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
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        private readonly Shell _shell;

        public RegisterView()
        {
            InitializeComponent();
            _shell = (Shell)Application.Current.MainWindow;
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.LOGIN_VIEW);
        }

        private void Register_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
