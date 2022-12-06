using Microsoft.AspNetCore.Mvc;
using TrailService.Data;
using AutoMapper;
using TrailService.Dtos;
using System;

namespace TrailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailsController : ControllerBase
    {
        private readonly ITrailRepo _repository;
        private readonly IMapper _mapper;

        public TrailsController(ITrailRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Get action at route return enum
        [HttpGet]
        // Get all location points 
        public ActionResult<IEnumerable<TrailReadDto>> GetTrails()
        {
            Console.WriteLine("Getting Trail Location Points");

            var TrailPointItem = _repository.GetAllTrails();

            return Ok(_mapper.Map<IEnumerable<TrailReadDto>>(TrailPointItem));
        }
    }
}