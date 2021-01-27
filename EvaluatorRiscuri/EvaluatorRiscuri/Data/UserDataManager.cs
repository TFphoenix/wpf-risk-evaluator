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
    public sealed class UserDataManager : DataManager<User>
    {
        static UserDataManager()
        {
            JsonPath = Path.Combine(Environment.CurrentDirectory, @"Data\JSONs\", "user.json");
        }

        public User GetByEmail(string email)
        {
            return DataSet.FirstOrDefault(u => u.Email == email);
        }

        public bool LoginUser(string email, string password)
        {
            User user = GetByEmail(email);

            if (null == user || user.Password != password) return false;

            return true;
        }

        public bool RegisterUser(User user)
        {
            User sameEmailUser = GetByEmail(user.Email);

            if (null != sameEmailUser) return false;

            Add(user);
            return true;
        }
    }
}
