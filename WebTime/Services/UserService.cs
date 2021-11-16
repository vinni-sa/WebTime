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
    }
}