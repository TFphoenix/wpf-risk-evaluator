using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EvaluatorRiscuri.Data
{
    public abstract class DataManager<T>
    {
        protected static string JsonPath = "";
        protected List<T> DataSet { get; set; }

        protected DataManager()
        {
            Load();
        }

        public abstract T GetById(int id);

        private void Save()
        {
            var jsonString = JsonSerializer.Serialize(DataSet);
            File.WriteAllText(JsonPath, jsonString);
        }

        private void Load()
        {
            var jsonString = File.ReadAllText(JsonPath);
            DataSet = JsonSerializer.Deserialize<List<T>>(jsonString);
        }
    }
}
