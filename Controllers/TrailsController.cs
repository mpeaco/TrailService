using Microsoft.AspNetCore.Mvc;
using TrailService.Data;
using AutoMapper;
using TrailService.Dtos;

namespace TrailService.Controllers
{
    [Route("api/Trails")]
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
            Console.WriteLine("Getting Trails");

            var TrailPointItem = _repository.GetAllTrails();

            return Ok(_mapper.Map<IEnumerable<TrailReadDto>>(TrailPointItem));
        }


        [HttpGet("{id}")]
        public ActionResult<TrailReadDto> GetTrailById(int id)
        {
            Console.WriteLine("Getting trail " + id);
            var TrailItem = _repository.GetTrailById(id);
            if (TrailItem != null)
            {
                return Ok(_mapper.Map<TrailReadDto>(TrailItem));
            }

            return NotFound($"Trail{id} does not exist");
        }
    }

    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITrailRepo _repository;
        private readonly IMapper _mapper;

        public UserController(ITrailRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        // Get all location points 
        public ActionResult<IEnumerable<UserReadDto>> GetUsers()
        {
            Console.WriteLine("Getting Users");

            var UserItem = _repository.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(UserItem));
        }

        [HttpGet("{username}")]
        public ActionResult<UserReadDto> GetUserByUsername(string username)
        {
            Console.WriteLine("Getting User: " + username);
            var UserItem = _repository.GetUserById(username);
            if (UserItem != null)
            {
                return Ok(_mapper.Map<UserReadDto>(UserItem));
            }

            return NotFound($"User {username} does not exist");
        }

    }

    [Route("api/Locationpoints")]
    [ApiController]
    public class PointsController : ControllerBase
    {
        private readonly ITrailRepo _repository;
        private readonly IMapper _mapper;

        public PointsController(ITrailRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        // Get all location points 
        public ActionResult<IEnumerable<LocationPointReadDto>> GetLocationPoints()
        {
            Console.WriteLine("Getting Points");

            var PointItem = _repository.GetAllLocationPoints();
            if (PointItem != null)
            {
                return Ok(_mapper.Map<IEnumerable<LocationPointReadDto>>(PointItem));
            }
            return NotFound("Points not found");


        }

        [HttpGet("{trailname}")]
        public ActionResult<IEnumerable<LocationPointReadDto>> GetPointsByTrailName(string trailname)
        {
            Console.WriteLine("Getting User: " + trailname);
            var PointItem = _repository.GetLocationPointsForTrail(trailname);
            if (PointItem != null)
            {
                return Ok(_mapper.Map<IEnumerable<LocationPointReadDto>>(PointItem));
            }

            return NotFound($"Trail {trailname} does not exist");
        }

    }

}