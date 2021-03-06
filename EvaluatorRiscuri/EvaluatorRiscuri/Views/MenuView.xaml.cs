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
                ProjectsList.ItemsSource = _shell.ProjectData.GetUserProjects(_shell.UserData.ConnectedUser.Id);
            }
            // On disappearing
            else
            {
                UserNameLabel.Content = "";
                ProjectsList.ItemsSource = new List<Project>();
            }
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.UserData.LogoutUser();
            _shell.GoTo(Shell.LOGIN_VIEW);
        }

        private void AddProject_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.PROJECT_ADD_VIEW);
        }

        private void DetailsProject_OnClick(object sender, RoutedEventArgs e)
        {
            var project = ((FrameworkElement)sender).DataContext as Project;

            _shell.ProjectData.SelectedProject = project;
            _shell.GoTo(Shell.PROJECT_DETAILS_VIEW);
        }

        private void EvaluateProject_OnClick(object sender, RoutedEventArgs e)
        {
            var project = ((FrameworkElement)sender).DataContext as Project;

            _shell.ProjectData.SelectedProject = project;
            _shell.GoTo(Shell.PROJECT_EVALUATE_VIEW);
        }

        private void DeleteProject_OnClick(object sender, RoutedEventArgs e)
        {
            var project = ((FrameworkElement)sender).DataContext as Project;

            _shell.ProjectData.Delete(project);
            ProjectsList.ItemsSource = _shell.ProjectData.GetUserProjects(_shell.UserData.ConnectedUser.Id);
        }
    }
}
