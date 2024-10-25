using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        private IServerRepo _serverRepo;

        public ServerController(IServerRepo serverRepo)
        {
            _serverRepo = serverRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Server>? users = new();

            if (_serverRepo != null)
            {
                users = await _serverRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Server? entity = new();
            if (_serverRepo is not null)
            {
                entity = await _serverRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}