using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Phase1.Model;
using Web_Api_Phase1.Services;

namespace Web_Api_Phase1.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeService employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        [HttpGet("getAll")]
        public IActionResult Get()
        {
            var userData = employeeService.GetUserData();
            return Ok(new ApiResponseCode
            {
                responseCode = 200,
                data = userData
            });
        }

        [HttpGet("getAllUserData")]
        public IActionResult getUserData()
        {
            var userData = employeeService.getUserDataJson();
            return Ok(new 
            {
                responseCode = 200,
                data = userData
            });
        }

    }


}
