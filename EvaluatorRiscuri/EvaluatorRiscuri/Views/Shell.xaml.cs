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
using EvaluatorRiscuri.Data;

namespace EvaluatorRiscuri
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        // View names
        public const string LOGIN_VIEW = "Login";
        public const string REGISTER_VIEW = "Register";
        public const string MENU_VIEW = "Menu";

        // Views
        private Dictionary<string, UserControl> views;

        // Data
        public UserDataManager UserData { get; set; } = new UserDataManager();

        // Ctor
        public Shell()
        {
            InitializeComponent();
            ResizeWindow(LOGIN_VIEW);
            InitializeViews();
        }


        // Go to specified view
        public void GoTo(string viewName)
        {
            foreach (var view in views)
            {
                if (view.Key.Equals(viewName))
                {
                    view.Value.Visibility = Visibility.Visible;
                    view.Value.IsEnabled = true;
                }
                else
                {
                    view.Value.Visibility = Visibility.Hidden;
                    view.Value.IsEnabled = false;
                }
            }

            ResizeWindow(viewName);
        }

        // Syncronize window size
        private void ResizeWindow(string viewName)
        {
            if (viewName.Equals(MENU_VIEW))
            {
                ResizeMode = ResizeMode.CanResize;

                MinWidth = 800;
                MinHeight = 450;

                MaxWidth = double.PositiveInfinity;
                MaxHeight = double.PositiveInfinity;
            }
            else
            {
                ResizeMode = ResizeMode.NoResize;

                MinWidth = 350;
                MinHeight = 500;

                MaxWidth = 350;
                MaxHeight = 500;
            }
        }

        // populate view routings
        private void InitializeViews()
        {
            views = new Dictionary<string, UserControl>
            {
                {LOGIN_VIEW, LoginView },
                {REGISTER_VIEW, RegisterView},
                {MENU_VIEW, MenuView}
            };
        }
    }
}
