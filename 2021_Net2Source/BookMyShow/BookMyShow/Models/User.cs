using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

    }
}
//Sql("Insert into Roles(Name) Values ('SuperAdmin')");
//Sql("Insert into Roles(Name) Values ('Admin')");
//Sql("Insert into Roles(Name) Values ('Normal')");
//Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('sarathlal','Sarathlal Saseendran','pwd',1)");
//Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('sarath','Sarath Lal','pwd',2)");
//Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('lal','Sarath Lal','pwd',3)");  
