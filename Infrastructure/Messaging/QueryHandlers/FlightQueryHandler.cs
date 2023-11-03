using FlightApp.Application.Queries.Flights;
using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using FlightApp.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightApp.Infrastructure.Messaging.QueryHandlers
{
    public class FlightQueryHandler : IRequestHandler<GetFlightQuery, Flight>, IRequestHandler<GetAllFlightQuery, List<Flight>>
    {
        private readonly FlightDbContext _dbContext;
        private readonly IFlightRepository _flightRepository;
        public FlightQueryHandler(FlightDbContext dbContext, IFlightRepository flightRepository)
        {
            _dbContext = dbContext;
            _flightRepository = flightRepository;
        }

        public async Task<Flight> Handle(GetFlightQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Flights.FindAsync(request.FlightId);
        }
        public async Task<List<Flight>> Handle(GetAllFlightQuery request, CancellationToken cancellationToken)
        {
            return await _flightRepository.GetAllAsync();
        }
    }
}
