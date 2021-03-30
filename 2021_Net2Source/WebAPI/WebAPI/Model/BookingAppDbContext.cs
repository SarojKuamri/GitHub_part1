using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Model
{
    public class BookingAppDbContext:DbContext
    {
        public BookingAppDbContext(DbContextOptions<BookingAppDbContext> options) : base(options)
        {
        
        }
        public DbSet<HotelModel> HotelModels { get; set; }
       
    }
}
