using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{

    [Route("testeapp")]
    public class TesteController : Controller
    {

        [HttpGet("xpto")]
        public string Ping() => "Pong";

        [HttpGet("xpto/{msg}")]
        public string Ping(string msg) => "Pong - " + msg;

        [HttpGet("ex")]
        public string TesteException()
        {
            var num1 = 2;
            var num2 = 0;
            var result = 0;

            try
            {
                result = num1 / num2;
            }
            catch
            {
                return "Erro ao tentar dividir";
            }

            return result.ToString();
        }

        [HttpGet("ex2")]
        public string TesteException2()
        {
            var num1 = 2;
            var num2 = 0;
            var result = 0;

            result = num1 / num2;

            return result.ToString();
        }

        [HttpGet("env")]
        public IActionResult Env()
        {
            return View();
        }
    }
}
