using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Api.Controllers
{
    public class TesteController : ControllerBase
    {
        
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok(new { msg = "pong" });
        }

    }
}
