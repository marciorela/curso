using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using MRsoft.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private StoreDataContext _ctx;

        public UsuariosController(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Gestão de Usuários";

            var data = _ctx.Usuarios.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            UsuariosAddEditVM model = null;
            var title = "Adicionar";

            if (id != null)
            {
                title = "Editar";

                var usuario = _ctx.Usuarios.Find(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                model = usuario.ToVM();
            }

            ViewBag.Title = title + " Usuário";
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(int id, UsuariosAddEditVM model)
        {
            var usuario = model.ToData(id);
            if (id == 0)
            {
                _ctx.Usuarios.Add(usuario);
            }
            else
            {
                _ctx.Update(usuario);
            }
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
