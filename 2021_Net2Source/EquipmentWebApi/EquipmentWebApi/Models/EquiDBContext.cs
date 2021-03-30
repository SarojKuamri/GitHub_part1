using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentWebApi.Models
{
    public class EquiDBContext:DbContext
    {
        
        public EquiDBContext(DbContextOptions<EquiDBContext> options) : base(options)
        {

        }
        public DbSet<EquiModels> models{ get; set; }
        
    }
}
