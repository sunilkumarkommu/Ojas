using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet(Name = "addEmployee")]
        public string add()
        {
            string s = "hello world";
            return s;

        }
    }
}
