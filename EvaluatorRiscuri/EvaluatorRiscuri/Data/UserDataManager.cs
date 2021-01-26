using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluatorRiscuri.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EvaluatorRiscuri.Data
{
    class UserDataManager : DataManager<User>
    {
        static UserDataManager()
        {
            JsonPath = Path.Combine(Environment.CurrentDirectory, @"Data\JSONs\", "user.json");
        }

        public override User GetById(int id)
        {
            return DataSet.First(u => u.Id == id);
        }

        public User GetByEmail(string email)
        {
            return DataSet.First(u => u.Email == email);
        }

        public bool LoginUser(string email, string password)
        {
            User user = GetByEmail(email);

            if (null == user || user.Password != password) return false;

            return true;
        }

        protected override void Save()
        {
            var jsonString = JsonSerializer.Serialize(DataSet);
            File.WriteAllText(JsonPath, jsonString);
        }

        protected override void Load()
        {
            var jsonString = File.ReadAllText(JsonPath);
            DataSet = JsonSerializer.Deserialize<List<User>>(jsonString);
        }
    }
}
