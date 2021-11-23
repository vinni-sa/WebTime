using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;

namespace WebTime.Services
{
    public class HallService
    {
        private ApplicationDbContext _dbContext;

        public HallService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Hall> Get()
        {
            return _dbContext.Halls;
        }
        
        public Hall Get(int id)
        {
            return _dbContext.Halls.First(x => x.Id == (id));
        }

        public void Add(Hall hall)
        {
            _dbContext.Halls.Add(hall);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var hallInBd = _dbContext.Halls.First(x => id == x.Id);
            _dbContext.Halls.Remove(hallInBd);
            _dbContext.SaveChanges();
        }
    }
}