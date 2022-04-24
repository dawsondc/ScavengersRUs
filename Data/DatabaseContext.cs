using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ScavengersRUs.Models.Users;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace ScavengersRUs.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("MyDbConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<User> Users => Set<User> ();
    }
}
