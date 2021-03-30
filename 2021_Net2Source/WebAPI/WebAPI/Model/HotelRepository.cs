using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Model
{
    public class HotelRepository : IHotelRepository
    {
        private readonly BookingAppDbContext _bookingAppDbContext;

        public HotelRepository(BookingAppDbContext bookingAppDbContext)
        {

            _bookingAppDbContext = bookingAppDbContext;
        }
        public void Add(HotelModel hotel)
        {
            _bookingAppDbContext.HotelModels.Add(hotel);
            _bookingAppDbContext.SaveChanges();
        }

        public HotelModel Find(int hotelId)
        {
            var hotel = _bookingAppDbContext.HotelModels.Find(hotelId);
            return hotel;
        }

        public IEnumerable<HotelModel> GetAll()
        {
            return _bookingAppDbContext.HotelModels.ToList();
        }

        public HotelModel Remove(int hotelId)
        {
            var hotelEntity = Find(hotelId);
            _bookingAppDbContext.HotelModels.Remove(hotelEntity);
            _bookingAppDbContext.SaveChanges();
            return hotelEntity;
        }

        public void Update(HotelModel hotel)
        {
            _bookingAppDbContext.Entry(hotel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _bookingAppDbContext.SaveChanges();

        }

    }
}
