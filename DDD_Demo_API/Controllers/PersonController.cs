using DDD_Demo_API.ApplicationServices;
using DDD_Demo_API.Comands;
using Microsoft.AspNetCore.Mvc;

namespace DDD_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly APIServices _services;
        public PersonController(APIServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(CreatePersonCommand createPersonCommand)
        {
            await _services.HandleCommand(createPersonCommand);
            return Ok(createPersonCommand);
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var response = await _services.GetPerson(id);
            return Ok(response);
        }
    }
}
