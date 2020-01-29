using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{
    public class CategoriasController : Controller
    {
        private ICategoriaRepository _categRepo;
        private IUnitOfWork _uow;

        public CategoriasController(ICategoriaRepository categRepo, IUnitOfWork uow)
        {
            _categRepo = categRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categRepo.GetAsync());
        }
    }
}
