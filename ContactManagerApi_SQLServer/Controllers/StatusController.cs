using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerApi_SQLServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [Route("isalive")]
        public IActionResult IsAlive()
        {
            var json = new { StatusCode = 200 , Alive = true};
            return Ok(json);
        }
    }
}