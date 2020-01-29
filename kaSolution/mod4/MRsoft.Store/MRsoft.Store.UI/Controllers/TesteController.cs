using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{

    [Route("testeapp")]
    public class TesteController
    {

        [HttpGet("xpto")]
        public string Ping() => "Pong";

        [HttpGet("xpto/{msg}")]
        public string Ping(string msg) => "Pong - " + msg;
    }
}
