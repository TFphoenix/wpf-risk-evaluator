using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatorRiscuri.Models
{
    public class Project : Model
    {
        // General properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectManager { get; set; }
        public string CreatedDate { get; set; }

        // Evaluation properties
        public string LastEvaluatedDate { get; set; }
        public int DataOperationsRiskScore { get; set; }
        public int ApplicationsSystemCreationRiskScore { get; set; }
        public int ApplicationsSystemDevelopmentRiskScore { get; set; }
        public int HumanMaterialsResourcesRiskScore { get; set; }
        public int SoftwareAcquisitionRiskScore { get; set; }
        public int OtherFunctionsRiskScore { get; set; }
    }
}
