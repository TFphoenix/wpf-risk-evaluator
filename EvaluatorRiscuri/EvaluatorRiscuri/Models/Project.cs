using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatorRiscuri.Models
{
    public class Project : Model
    {
        public string Name { get; set; }
        public int ProjectManager { get; set; }
        public string CreatedDate { get; set; }
        public string Description { get; set; }
    }
}
