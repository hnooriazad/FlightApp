using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FlightApp.Infrastructure.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly FlightDbContext _context;

        public FlightRepository(FlightDbContext context)
        {
            _context = context;
        }

        public async Task<Flight> GetByIdAsync(int id)
        {
            return await _context.Flights.FindAsync(id);
        }

        public async Task<List<Flight>> GetAllAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public async Task AddAsync(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
        }

        public async Task AddListAsync(List<Flight> flights)
        {
            _context.Flights.AddRange(flights);
            await _context.SaveChangesAsync();
        }
        // Implement other methods...
    }
}
