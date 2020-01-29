using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MRsoft.Store.UI.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        
        public IActionResult Index()
        {
            ViewBag.Title = "Minha página inicial";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet("error")]
        public IActionResult Error([FromServices]ILogCustom log)
        {
            var statusCode = HttpContext.Response.StatusCode;
            var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var msg = "";
            var path = "";
            if (exception != null)
            {
                path = HttpContext.Features.Get<IExceptionHandlerPathFeature>().ToString();
                msg = exception.Error.Message;
                log.Error($"StatusCode: {statusCode}\nUserAgent: {userAgent}\n");
            }

            ViewBag.Title = "Erro interno";
            return View();
        }
    }
}
