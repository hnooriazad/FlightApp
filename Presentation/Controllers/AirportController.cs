using AutoMapper;
using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Services;
using FlightApp.Application.Commands.Airports;
using FlightApp.Application.Commands.Flights;
using FlightApp.Application.DTOs;
using FlightApp.Application.Queries.Airports;
using FlightApp.Application.Queries.Flights;
using FlightApp.Domain.Entities;
using FlightApp.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlightApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AirportController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllAirports")]
        public async Task<ActionResult<AirportDto>> GetAllAirports()
        {
            var query = new GetAllAirportQuery();
            List<Airport> airport = await _mediator.Send(query);

            if (airport == null)
            {
                return NotFound();
            }

            var airportDto = _mapper.Map<List<AirportDto>>(airport);
            return Ok(airportDto);
        }


        [HttpPost]
        [Route("GetAirports")]
        public async Task<ActionResult<List<AirportDto>>> GetAirPorts([FromBody] AirportSearchInputModel? airportSearchInputModel)
        {

            try
            {
                var res = await AirportApiService.GetAirportsByFilterAsync(_mapper.Map<GetAllAirportsRequestModel>(airportSearchInputModel));
                var createAirportListCommand = new CreateAirportListCommand()
                {
                    Airports = _mapper.Map<List<CreateAirportCommand>>(res.Data)
                };
                var a = await _mediator.Send(createAirportListCommand);

                var query = new GetAllAirportQuery();
                List<Airport> Airport = await _mediator.Send(query);

                if (Airport == null)
                {
                    return NotFound();
                }

                var AirportDto = _mapper.Map<List<AirportDto>>(Airport);
                return Ok(AirportDto);
            }
            catch
            {
                return UnprocessableEntity();
            }
        }

    }
}
