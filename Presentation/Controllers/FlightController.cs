using AutoMapper;
using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Services;
using FlightApp.Application.Commands.Flights;
using FlightApp.Application.DTOs;
using FlightApp.Application.Queries.Flights;
using FlightApp.Domain.Entities;
using FlightApp.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlightApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public FlightController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllFlights")]
        public async Task<ActionResult<List<FlightDto>>> GetAllFlights()
        {
            try
            {

                var res = await FlightApiService.GetAllFlightsAsync();
                var createFlightListCommand = new CreateFlightListCommand()
                {
                    Flights = _mapper.Map<List<CreateFlightCommand>>(res.Data)
                };
                var a = await _mediator.Send(createFlightListCommand);
                var query = new GetAllFlightQuery();
                List<Flight> Flight = await _mediator.Send(query);

                if (Flight == null)
                {
                    return NotFound();
                }

                var FlightDto = _mapper.Map<List<FlightDto>>(Flight);
                return Ok(FlightDto);
            }
            catch (Exception ex)
            {
                return UnprocessableEntity();
            }
        }
        /// <summary>
        /// this API use to search by filter
        /// if you want to find flight of airport, fill dep_iata or arr_iata in Inuput model
        /// </summary>
        /// <param name="flightSearchInputModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetFlights")]
        public async Task<ActionResult<List<FlightDto>>> GetFlights([FromBody] FlightSearchInputModel? flightSearchInputModel)
        {
            try
            {
                var res = await FlightApiService.GetFlightsByFilterAsync(_mapper.Map<GetAllFlightsRequestModel>(flightSearchInputModel));
                var createFlightListCommand = new CreateFlightListCommand()
                {
                    Flights = _mapper.Map<List<CreateFlightCommand>>(res.Data)
                };
                var a = await _mediator.Send(createFlightListCommand);

                var query = new GetAllFlightQuery();
                List<Flight> Flight = await _mediator.Send(query);

                if (Flight == null)
                {
                    return NotFound();
                }

                var FlightDto = _mapper.Map<List<FlightDto>>(Flight);
                return Ok(FlightDto);
            }
            catch
            {
                return UnprocessableEntity();
            }
        }
    }
}
