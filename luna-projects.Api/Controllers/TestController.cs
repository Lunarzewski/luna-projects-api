using luna_projects_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace luna_projects_api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTest()
        {
            var person = new Person
            {
                FirstName = "Johnny",
                LastName = "BeGoode",
                Age = 32
            };
            return Ok(person);
        }
    }
}