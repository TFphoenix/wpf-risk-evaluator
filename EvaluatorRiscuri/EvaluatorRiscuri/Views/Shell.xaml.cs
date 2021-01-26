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

namespace EvaluatorRiscuri
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public const string LOGIN_VIEW = "Login";
        public const string REGISTER_VIEW = "Register";

        private Dictionary<string, UserControl> views;

        public Shell()
        {
            InitializeComponent();
            InitializeViews();
        }

        public void GoTo(string viewName)
        {
            foreach (var view in views)
            {
                view.Value.Visibility = view.Key.Equals(viewName) ? Visibility.Visible : Visibility.Hidden;
            }
        }

        private void InitializeViews()
        {
            views = new Dictionary<string, UserControl>
            {
                {LOGIN_VIEW, LoginView },
                {REGISTER_VIEW, RegisterView}
            };
        }
    }
}
