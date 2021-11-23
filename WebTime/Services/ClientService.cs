using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;
using WebTime.Data.Models;


namespace WebTime.Services
{
    public class ClientService
    {
        private ApplicationDbContext _dbContext;

        public ClientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public DbSet<Client> Get()
        {
            return _dbContext.Clients;
        }
        
        public Client Get(int id)
        {
            return _dbContext.Clients.First(x => x.Id == (id));
        }

        public void Add(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var clientInBd = _dbContext.Clients.First(x => id == x.Id);
            _dbContext.Clients.Remove(clientInBd);
            _dbContext.SaveChanges();
        }
    }
}