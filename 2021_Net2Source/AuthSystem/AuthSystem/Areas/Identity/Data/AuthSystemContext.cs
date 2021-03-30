using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthSystem.Data
{
    public class AuthSystemContext : IdentityDbContext<IdentityUser>
    {
        public AuthSystemContext(DbContextOptions<AuthSystemContext> options)
            : base(options)
        {
        }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
        }
    }
}
