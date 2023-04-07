using AM.Core.Domain;
using AM.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{
    public class AMContext: DbContext
    {
        public DbSet<Plane> Planes { get; set; }<
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=(localdb)\mssqllocaldb;
                    Initial Catalog = Airport;
                    Integrated Security = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<new PlaneConf()
        }
        //tp4 q8
        protected override void ConfigureConvention (Mod)


    }




}