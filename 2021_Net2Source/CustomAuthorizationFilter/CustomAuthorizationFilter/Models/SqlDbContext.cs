using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace CustomAuthorizationFilter.Models
{
    //public class SqlDbContext
    //{
    //}
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}