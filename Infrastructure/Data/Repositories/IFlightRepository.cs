using FlightApp.Domain.Entities;

namespace FlightApp.Infrastructure.Data.Repositories
{
    public interface IFlightRepository
    {
        Task<Flight> GetByIdAsync(int id);
        Task<List<Flight>> GetAllAsync();
        Task AddAsync(Flight flight);
        Task AddListAsync(List<Flight> flight);
        // Other methods...
    }
}
