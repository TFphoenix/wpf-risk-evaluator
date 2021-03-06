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
    /// Interaction logic for ProjectEvaluateView.xaml
    /// </summary>
    public partial class ProjectEvaluateView : UserControl
    {
        private readonly Shell _shell;

        public ProjectEvaluateView()
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
            }
            // On disappearing
            else
            {
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.MENU_VIEW);
        }

        private void Evaluate_OnClick(object sender, RoutedEventArgs e)
        {
            var buttonLabel = ((sender as Button)?.Content as WrapPanel)?.Children[1] as Label;
            if (null == buttonLabel) throw new NullReferenceException("Wrong evaluate button format");

            string evaluationName = buttonLabel.Content as string;
            if (string.IsNullOrEmpty(evaluationName) || !RiskEvaluationForm.EVALUATION_NAMES.ContainsKey(evaluationName)) throw new ArgumentException("Invalid evaluation name");

            _shell.ProjectData.SelectedEvaluationName = evaluationName;
            _shell.GoTo(Shell.PROJECT_EVALUATE_FORM_VIEW);
        }
    }
}
