using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase  // contrelerde basde retrun view elemek olmur
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            string[] names = { "Eli", "Aqsin", "Elcan" };

            return Ok(names);
        }


        [HttpGet]
        public IActionResult GetById( int? id)
        {
            if (id == null) return BadRequest();
            return Ok("Eli -" + " " + id);

        }
        

    }
}
