using FlightApp.Domain.Entities;

namespace FlightApp.Infrastructure.Data.Repositories
{
    public interface IAirportRepository
    {
        Task<Airport> GetByIdAsync(int id);
        Task<List<Airport>> GetAllAsync();
        Task AddAsync(Airport airport);
        Task AddListAsync(List<Airport> airports);
        // Other methods...
    }
}
