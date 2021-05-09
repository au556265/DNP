using Assignment2WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2WebAPI.Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Adult> Adultss { get; set; }
        public DbSet<User> Userss { get; set; }
        
        public DbSet<Job>Jobss { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\fatem\RiderProjects\BlazorIntroduction\DNP_WebAPI\Assignment2WebAPI\InitialCreate.db");
        }
    }
}