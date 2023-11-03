using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FlightApp.Infrastructure.Data.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly FlightDbContext _context;

        public AirportRepository(FlightDbContext context)
        {
            _context = context;
        }

        public async Task<Airport> GetByIdAsync(int id)
        {
            return await _context.Airports.FindAsync(id);
        }

        public async Task<List<Airport>> GetAllAsync()
        {
            return await _context.Airports.ToListAsync();
        }

        public async Task AddAsync(Airport airport)
        {
            _context.Airports.Add(airport);
            await _context.SaveChangesAsync();
        }

        public async Task AddListAsync(List<Airport> airports)
        {
            _context.Airports.AddRange(airports);
            await _context.SaveChangesAsync();
        }
        // Implement other methods...
    }
}
