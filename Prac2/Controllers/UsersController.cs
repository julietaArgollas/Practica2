using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prac2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostUser()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PutUser()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUser()
        {
            return Ok();
        }
    }
}
