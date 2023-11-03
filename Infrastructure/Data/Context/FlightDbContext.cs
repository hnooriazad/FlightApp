using FlightApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightApp.Infrastructure.Data.Context
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {
        }

        // Define DbSet properties for your entities here
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.Airline);
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.Arrival);
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.Aircraft);
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.Live);
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.Departure);
            modelBuilder.Entity<Flight>().OwnsOne(contactDetails => contactDetails.FlightDetails,
                ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.OwnsOne(contactDetails => contactDetails.Codeshared);
                });
            // Configure entity relationships and constraints here
        }
    }
}
