using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using EvaluatorRiscuri.Models;

namespace EvaluatorRiscuri.Data
{
    public abstract class DataManager<T> where T : Model
    {
        protected static string JsonPath = "";

        protected List<T> DataSet { get; set; }
        protected int NextId { get; set; }

        protected DataManager()
        {
            Load();
        }

        public virtual T GetById(int id)
        {
            return DataSet.FirstOrDefault(u => u.Id == id);
        }

        public virtual void Add(T entity)
        {
            entity.Id = NextId++;
            DataSet.Add(entity);
            Save();
        }

        public virtual void Delete(T entity)
        {
            DataSet.Remove(entity);
            Save();
        }

        private void Save()
        {
            var jsonString = JsonSerializer.Serialize(DataSet);
            File.WriteAllText(JsonPath, jsonString);
        }

        private void Load()
        {
            var jsonString = File.ReadAllText(JsonPath);
            DataSet = JsonSerializer.Deserialize<List<T>>(jsonString);
            NextId = DataSet.Count == 0 ? 0 : DataSet[DataSet.Count - 1].Id + 1;
        }
    }
}
