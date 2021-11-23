using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;


namespace WebTime.Services

{
    public class UserService
    {
        private ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<User> Get()
        {
            return _dbContext.Users;
        }
        
        public User Get(int id)
        {
            return _dbContext.Users.First(x => x.Id == (id));
        }

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var userInBd = _dbContext.Users.First(x => id == x.Id);
            _dbContext.Users.Remove(userInBd);
            _dbContext.SaveChanges();
        }
    }
    
}