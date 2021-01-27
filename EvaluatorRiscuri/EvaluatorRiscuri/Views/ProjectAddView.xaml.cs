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
using EvaluatorRiscuri.Models;

namespace EvaluatorRiscuri.Views
{
    /// <summary>
    /// Interaction logic for ProjectAddView.xaml
    /// </summary>
    public partial class ProjectAddView : UserControl
    {
        private readonly Shell _shell;

        public ProjectAddView()
        {
            InitializeComponent();
            _shell = (Shell)Application.Current.MainWindow;
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                ErrorLabel.Visibility = Visibility.Visible;
                return;
            }

            // Add project
            _shell.ProjectData.Add(new Project
            {
                CreatedDate = DateTime.Now.ToString("dd/MM/yyyy"),
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                ProjectManager = _shell.UserData.ConnectedUser.Id
            });

            // Clear values
            ErrorLabel.Visibility = Visibility.Hidden;
            NameTextBox.Clear();
            DescriptionTextBox.Clear();

            // Go to menu
            _shell.GoTo(Shell.MENU_VIEW);
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.MENU_VIEW);
        }
    }
}
