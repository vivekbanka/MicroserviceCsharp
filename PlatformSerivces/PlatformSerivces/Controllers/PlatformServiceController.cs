using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformSerivces.Data;
using PlatformSerivces.DTOs;
using PlatformSerivces.Models;

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

        [HttpGet("{id}",Name = "GetPlatformByID")]
        public IActionResult GetPlatformByID(int id)
        {
            var result = _platformRepo.GetPlatformById(id);
            return Ok(_mapper.Map<PlatformDTO>(result));
        }

        [HttpPost]
        public ActionResult<PlatformDTO> CreatePlatForm(PlatformCreateDTO platformCreateDTO)
        {
            var platformModel = _mapper.Map<Platform>(platformCreateDTO);
            _platformRepo.CreatePlatform(platformModel);
            _platformRepo.savechanges();

            var platformreadDTO = _mapper.Map<PlatformDTO>(platformModel);

            return CreatedAtRoute(nameof(GetPlatformByID), new { Id = platformreadDTO.Id }, platformreadDTO);
        }
    }
}
