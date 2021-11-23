using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;

namespace WebTime.Services
{
    public class TrainerService
    {
        private ApplicationDbContext _dbContext;

        public TrainerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Trainer> Get()
        {
            return _dbContext.Trainers;
        }
        
        public Trainer Get(int id)
        {
            return _dbContext.Trainers.First(x => x.Id == (id));
        }

        public void Add(Trainer Trainer)
        {
            _dbContext.Trainers.Add(Trainer);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var TrainerInBd = _dbContext.Trainers.First(x => id == x.Id);
            _dbContext.Trainers.Remove(TrainerInBd);
            _dbContext.SaveChanges();
        }
    }
}