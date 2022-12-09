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
            Console.WriteLine("Getting Trail Location Points");

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
        public ActionResult<TrailReadDto> GetUserByUsername(string username)
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

}