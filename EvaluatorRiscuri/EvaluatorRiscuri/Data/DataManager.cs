using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatorRiscuri.Data
{
    abstract class DataManager<T>
    {
        protected static string JsonPath = "";
        protected List<T> DataSet { get; set; }

        public abstract T GetById(int id);

        protected abstract void Save();
        protected abstract void Load();
    }
}
