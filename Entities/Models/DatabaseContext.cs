using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=pruebaTecnica;Trusted_Connection=True;");
            }
        }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        
    }
}
