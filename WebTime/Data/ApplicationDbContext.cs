using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebTime.Data.Models;

namespace WebTime.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}