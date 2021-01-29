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

namespace EvaluatorRiscuri.Views
{
    /// <summary>
    /// Interaction logic for ProjectEvaluateFormView.xaml
    /// </summary>
    public partial class ProjectEvaluateFormView : UserControl
    {
        private readonly Shell _shell;

        public ProjectEvaluateFormView()
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
                // Get parameters
                string evaluationName = _shell.ProjectData.SelectedEvaluationName;
                var project = _shell.ProjectData.SelectedProject;

                // Set form data
                TitleTextBlock.Text = evaluationName;
                FormList.ItemsSource = RiskEvaluationForm.EVALUATION_NAMES[evaluationName];
            }
            // On disappearing
            else
            {
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.PROJECT_EVALUATE_VIEW);
        }

        private void RankBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            //throw new NotImplementedException();
        }
    }
}
