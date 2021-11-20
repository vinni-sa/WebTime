using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;

namespace WebTime.Services
{
    public class TimeTableService
    {
        private ApplicationDbContext _dbContext;

        public TimeTableService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<TimeTable> Get()
        {
            return _dbContext.TimeTables;
        }
        
        public TimeTable Get(int id)
        {
            return _dbContext.TimeTables.First(x => x.Id == (id));
        }

        public void Add(TimeTable TimeTable)
        {
            _dbContext.TimeTables.Add(TimeTable);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var TimeTableInBd = _dbContext.TimeTables.First(x => id == x.Id);
            _dbContext.TimeTables.Remove(TimeTableInBd);
            _dbContext.SaveChanges();
        }
    }
}