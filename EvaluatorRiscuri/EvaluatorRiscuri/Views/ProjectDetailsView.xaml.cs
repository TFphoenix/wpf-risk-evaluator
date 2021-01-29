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
    /// Interaction logic for ProjectDetailsView.xaml
    /// </summary>
    public partial class ProjectDetailsView : UserControl
    {
        private readonly Shell _shell;

        public ProjectDetailsView()
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
                // Get project
                var project = _shell.ProjectData.SelectedProject;

                // General info
                NameTextBox.Text = project.Name;
                CreatedDateTextBox.Text = project.CreatedDate;
                DescriptionTextBox.Text = project.Description;

                // Evaluated info
                EvaluatedDateTextBox.Text = string.IsNullOrEmpty(project.LastEvaluatedDate) ? "N/A" : project.LastEvaluatedDate;
                DataOperationsRiskScoreTextBox.Text = project.DataOperationsRiskScore == 0 ? "N/A" : project.DataOperationsRiskScore.ToString();
                ApplicationsSystemCreationRiskScoreTextBox.Text = project.ApplicationsSystemCreationRiskScore == 0 ? "N/A" : project.ApplicationsSystemCreationRiskScore.ToString();
                ApplicationsSystemDevelopmentRiskScoreTextBox.Text = project.ApplicationsSystemDevelopmentRiskScore == 0 ? "N/A" : project.ApplicationsSystemDevelopmentRiskScore.ToString();
                HumanMaterialsResourcesRiskScoreTextBox.Text = project.HumanMaterialsResourcesRiskScore == 0 ? "N/A" : project.HumanMaterialsResourcesRiskScore.ToString();
                SoftwareAcquisitionRiskScoreTextBox.Text = project.SoftwareAcquisitionRiskScore == 0 ? "N/A" : project.SoftwareAcquisitionRiskScore.ToString();
                OtherFunctionsRiskScoreTextBox.Text = project.OtherFunctionsRiskScore == 0 ? "N/A" : project.OtherFunctionsRiskScore.ToString();
            }
            // On disappearing
            else
            {
                NameTextBox.Text = "";
                CreatedDateTextBox.Text = "";
                DescriptionTextBox.Text = "";
                EvaluatedDateTextBox.Text = "";
                DataOperationsRiskScoreTextBox.Text = "";
                ApplicationsSystemCreationRiskScoreTextBox.Text = "";
                ApplicationsSystemDevelopmentRiskScoreTextBox.Text = "";
                HumanMaterialsResourcesRiskScoreTextBox.Text = "";
                SoftwareAcquisitionRiskScoreTextBox.Text = "";
                OtherFunctionsRiskScoreTextBox.Text = "";
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.MENU_VIEW);
        }
    }
}
