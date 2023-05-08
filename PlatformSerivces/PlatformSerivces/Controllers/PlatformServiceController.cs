using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformSerivces.Data;
using PlatformSerivces.DTOs;

namespace PlatformSerivces.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformServiceController : ControllerBase
    {
        private readonly IPlatformRepo _platformRepo;
        private readonly IMapper _mapper;

        public PlatformServiceController(IPlatformRepo platformRepo, IMapper mapper)
        {
            _platformRepo = platformRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetRepositories()
        {
            var result = _platformRepo.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformDTO>>(result));
        }

        [HttpGet("{id}")]
        public IActionResult GetActionResult(int id)
        {
            var result = _platformRepo.GetPlatformById(id);
            return Ok(_mapper.Map<PlatformDTO>(result));
        }
    }
}
