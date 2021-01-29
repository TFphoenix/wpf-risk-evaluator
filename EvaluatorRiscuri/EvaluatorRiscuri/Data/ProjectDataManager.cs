using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluatorRiscuri.Models;

namespace EvaluatorRiscuri.Data
{
    public sealed class ProjectDataManager : DataManager<Project>
    {
        public Project SelectedProject { get; set; }
        public string SelectedEvaluationName { get; set; }

        static ProjectDataManager()
        {
            JsonPath = Path.Combine(Environment.CurrentDirectory, @"Data\JSONs\", "project.json");
        }

        public List<Project> GetUserProjects(int userId)
        {
            return DataSet.FindAll(p => p.ProjectManager == userId);
        }

        public void SetEvaluationScore(Project project, string evaluationName, int score)
        {
            switch (evaluationName)
            {
                case RiskEvaluationForm.DATA_OPERATIONS_NAME:
                    project.DataOperationsRiskScore = score;
                    break;
                case RiskEvaluationForm.APPLICATIONS_SYSTEM_CREATION_NAME:
                    project.ApplicationsSystemCreationRiskScore = score;
                    break;
                case RiskEvaluationForm.APPLICATIONS_SYSTEM_DEVELOPMENT_NAME:
                    project.ApplicationsSystemDevelopmentRiskScore = score;
                    break;
                case RiskEvaluationForm.HUMAN_MATERIALS_RESOURCES_NAME:
                    project.HumanMaterialsResourcesRiskScore = score;
                    break;
                case RiskEvaluationForm.SOFTWARE_ACQUISITION_NAME:
                    project.SoftwareAcquisitionRiskScore = score;
                    break;
                case RiskEvaluationForm.OTHER_FUNCTIONS_NAME:
                    project.OtherFunctionsRiskScore = score;
                    break;
                default:
                    throw new ArgumentException("Wrong evaluationName given");
            }

            project.LastEvaluatedDate = DateTime.Now.ToString("dd/MM/yyyy");

            Save();
        }

        public int GetEvaluationScore(Project project, string evaluationName)
        {
            switch (evaluationName)
            {
                case RiskEvaluationForm.DATA_OPERATIONS_NAME:
                    return project.DataOperationsRiskScore;
                case RiskEvaluationForm.APPLICATIONS_SYSTEM_CREATION_NAME:
                    return project.ApplicationsSystemCreationRiskScore;
                case RiskEvaluationForm.APPLICATIONS_SYSTEM_DEVELOPMENT_NAME:
                    return project.ApplicationsSystemDevelopmentRiskScore;
                case RiskEvaluationForm.HUMAN_MATERIALS_RESOURCES_NAME:
                    return project.HumanMaterialsResourcesRiskScore;
                case RiskEvaluationForm.SOFTWARE_ACQUISITION_NAME:
                    return project.SoftwareAcquisitionRiskScore;
                case RiskEvaluationForm.OTHER_FUNCTIONS_NAME:
                    return project.OtherFunctionsRiskScore;
                default:
                    throw new ArgumentException("Wrong evaluationName given");
            }
        }
    }
}
