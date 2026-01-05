using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Phase1.Model;

namespace Web_Api_Phase1.Controllers
{
    [Route("api/basic")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
    [Route("api/addUserDeatils")]
    [ApiController]
    public class addUserController: ControllerBase
    {
        [HttpPost]
        public IActionResult PostDataNew([FromBody] Employee employee)
        {
            return Ok(new
            {
                responseCode = 200,
                data = employee
            });
        }
    }
}
