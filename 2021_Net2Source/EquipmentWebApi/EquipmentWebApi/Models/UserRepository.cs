using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipmentWebApi.Models;

namespace EquipmentWebApi.Models
{
    public class UserRepository
    {
        public List<UserModels> TestUsers;
        public UserRepository()
        {
            TestUsers = new List<UserModels>();
            TestUsers.Add(new UserModels() { Username = "Test1", Password = "Pass1" });
            TestUsers.Add(new UserModels() { Username = "Test2", Password = "Pass2" });
        }
        public UserModels GetUser(string username)
        {
            try
            {
                return TestUsers.First(user => user.Username.Equals(username));
            }
            catch
            {
                return null;
            }
        }
    }
}
