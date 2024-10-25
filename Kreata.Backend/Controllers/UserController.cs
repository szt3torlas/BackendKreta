using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<User>? users = new();

            if (_userRepo != null)
            {
                users = await _userRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok el�rhetetlenek!");
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            User? entity = new();
            if (_userRepo is not null)
            {
                entity = await _userRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok el�rhetetlenek!");
        }
        ///[HttpPut]
        /*
        public async Task<ActionResult> UpdateStudentAsync(User entity)
        {
            ControllerResponse response = new();
            if (_userRepo is not null)
            {
                response = await _userRepo.UpdateStudentAsync(entity);
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok friss�t�s nem lehets�ges!");
            return BadRequest(response);
        }
        */
    }
}
