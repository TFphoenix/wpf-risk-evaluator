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
using EvaluatorRiscuri.Models;
using MaterialDesignThemes.Wpf;

namespace EvaluatorRiscuri.Views
{
    /// <summary>
    /// Interaction logic for ProjectEvaluateFormView.xaml
    /// </summary>
    public partial class ProjectEvaluateFormView : UserControl
    {
        private readonly Shell _shell;
        private string _evaluationName;
        private Project _selectedProject;
        private Dictionary<FormItem, int> _formRanks;
        private List<FormItem> _formItems;

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
                _evaluationName = _shell.ProjectData.SelectedEvaluationName;
                _selectedProject = _shell.ProjectData.SelectedProject;
                _formRanks = new Dictionary<FormItem, int>();
                _formItems = RiskEvaluationForm.EVALUATION_NAMES[_evaluationName];

                // Set form data
                TitleTextBlock.Text = _evaluationName;
                FormList.ItemsSource = _formItems;

                // Check if already evaluated
                if (_shell.ProjectData.GetEvaluationScore(_selectedProject, _evaluationName) != 0)
                {
                    LockEvaluationUi();
                }
            }
            // On disappearing
            else
            {
                // Unset form data
                TitleTextBlock.Text = "";
                FormList.ItemsSource = null;
                _formRanks = null;

                // Reset UI
                ResetEvaluationUi();
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            _shell.GoTo(Shell.PROJECT_EVALUATE_VIEW);
        }

        private void RankBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            ErrorLabel.Visibility = Visibility.Hidden;

            var formItem = (FormItem)((RatingBar)sender).DataContext;
            _formRanks[formItem] = e.NewValue;
        }

        private void Evaluate_OnClick(object sender, RoutedEventArgs e)
        {
            // Error
            if (_formRanks.Count != _formItems.Count)
            {
                ErrorLabel.Visibility = Visibility.Visible;
                return;
            }

            // Success
            LockEvaluationUi();
            _shell.ProjectData.SetEvaluationScore(_selectedProject, _evaluationName, CalculateScore());
        }

        private void Reset_OnClick(object sender, RoutedEventArgs e)
        {
            ResetEvaluationUi();
            _shell.ProjectData.SetEvaluationScore(_selectedProject, _evaluationName, 0);
        }

        private int CalculateScore()
        {
            int score = 0;

            foreach (var formRank in _formRanks)
            {
                score += formRank.Key.Weight * formRank.Value;
            }

            return score;
        }

        private void ResetEvaluationUi()
        {
            // UI
            EvaluateButton.IsEnabled = true;
            FormList.IsEnabled = true;
            ResetButton.IsEnabled = false;
            ErrorLabel.Visibility = Visibility.Hidden;
            SuccessLabel.Visibility = Visibility.Hidden;
        }

        private void LockEvaluationUi()
        {
            // UI
            EvaluateButton.IsEnabled = false;
            FormList.IsEnabled = false;
            ResetButton.IsEnabled = true;
            ErrorLabel.Visibility = Visibility.Hidden;
            SuccessLabel.Visibility = Visibility.Visible;
        }
    }
}
