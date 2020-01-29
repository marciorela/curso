using CadCli.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Controllers
{
    public class DadosSistemaController : Controller
    {
        private IConfigSistemaService _sisService;

        public DadosSistemaController(IConfigSistemaService sisService)
        {
            _sisService = sisService;
        }

        public IActionResult Index()
        {
            var dados = _sisService.Dados;
            return View(dados);
        }
    }
}
