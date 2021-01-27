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
        static ProjectDataManager()
        {
            JsonPath = Path.Combine(Environment.CurrentDirectory, @"Data\JSONs\", "project.json");
        }

        public List<Project> GetUserProjects(int userId)
        {
            return DataSet.FindAll(p => p.ProjectManager == userId);
        }
    }
}
