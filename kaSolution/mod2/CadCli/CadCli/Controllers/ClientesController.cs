using CadCli.Data;
using CadCli.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Controllers
{
    public class ClientesController : Controller
    {
        CadCliDataContext _ctx;

        public ClientesController(CadCliDataContext ctx)
        {
            _ctx = ctx;
        }

        public ViewResult Index()
        {
            //var clientes = new List<Cliente>()
            //{
            //};

            var clientes = _ctx.Clientes.ToList();

            return View(clientes);
        }

        public ViewResult Adicionar() => View();

        public IActionResult Editar(int id)
        {
            var cliente = _ctx.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Salvar(Cliente model)
        {
            // VALIDAR
            if (model.Nome == null || model.Idade < 18)
            {
                return BadRequest();
            }

            // SALVAR NO BANCO
            if (model.Id == 0)
            {
                _ctx.Clientes.Add(model);
            }
            else
            {
                _ctx.Update(model);
            }
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var cliente = _ctx.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _ctx.Clientes.Remove(cliente);
            _ctx.SaveChanges();

            return Ok();
        }
    }
}
