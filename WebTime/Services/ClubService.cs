using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;

namespace WebTime.Services
{
    public class ClubService
    {
        private ApplicationDbContext _dbContext;

        public ClubService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Club> Get()
        {
            return _dbContext.Clubs;
        }
        
        public Club Get(int id)
        {
            return _dbContext.Clubs.First(x => x.Id == (id));
        }

        public void Add(Club сlub)
        {
            _dbContext.Clubs.Add(сlub);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var clubInBd = _dbContext.Clubs.First(x => id == x.Id);
            _dbContext.Clubs.Remove(clubInBd);
            _dbContext.SaveChanges();
        }
    }
}