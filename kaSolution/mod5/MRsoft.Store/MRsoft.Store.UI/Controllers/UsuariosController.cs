using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using MRsoft.Store.Domain.ViewModels;
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
        private IUsuarioRepository _usuarioRepo;
        private IUnitOfWork _uow;

        public UsuariosController(IUsuarioRepository usuarioRepo, IUnitOfWork uow)
        {
            _usuarioRepo = usuarioRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Gestão de Usuários";

            var data = await _usuarioRepo.GetAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {
            UsuariosAddEditVM model = null;
            var title = "Adicionar";

            if (id != null)
            {
                title = "Editar";

                var usuario = await _usuarioRepo.GetAsync(id);
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
        public async Task<IActionResult> AddEdit(int id, UsuariosAddEditVM model)
        {
            var usuario = model.ToData(id);
            if (id == 0)
            {
                _usuarioRepo.Add(usuario);
            }
            else
            {
                _usuarioRepo.Update(usuario);
            }
            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }
    }
}
