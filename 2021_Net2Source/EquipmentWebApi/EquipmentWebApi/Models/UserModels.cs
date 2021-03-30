using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentWebApi.Models
{
    public class UserModels
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public enum UserRole
    {
        NORMAL,
        ADMIN
    }
}
