using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;

namespace WebTime.Services
{
    public class BookingService
    {
        private ApplicationDbContext _dbContext;

        public BookingService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Booking> Get()
        {
            return _dbContext.Bookings;
        }
        
        public Booking Get(int id)
        {
            return _dbContext.Bookings.First(x => x.Id == (id));
        }

        public void Add(Booking booking)
        {
            _dbContext.Bookings.Add(booking);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var BookingInBd = _dbContext.Bookings.First(x => id == x.Id);
            _dbContext.Bookings.Remove(BookingInBd);
            _dbContext.SaveChanges();
        }
    }
}