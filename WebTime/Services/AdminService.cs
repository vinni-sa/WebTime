using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;


namespace WebTime.Services
{
    public class AdminService
    {
        private ApplicationDbContext _dbContext;

        public AdminService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Admin> Get()
        {
            return _dbContext.Admins;
        }
        
        public Admin Get(int id)
        {
            return _dbContext.Admins.First(x => x.Id == (id));
        }

        public void Add(Admin admin)
        {
            _dbContext.Admins.Add(admin);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var adminInBd = _dbContext.Admins.First(x => id == x.Id);
            _dbContext.Admins.Remove(adminInBd);
            _dbContext.SaveChanges();
        }
    }
}