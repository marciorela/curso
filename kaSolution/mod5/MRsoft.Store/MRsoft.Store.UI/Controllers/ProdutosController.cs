using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private IProdutoRepository _produtoRepo;
        private ICategoriaRepository _categoriaRepo;
        private IUnitOfWork _unitOfWork;

        public ProdutosController(IProdutoRepository produtoRepo, ICategoriaRepository categoriaRepo, IUnitOfWork unitOfWork)
        {
            _produtoRepo = produtoRepo;
            _categoriaRepo = categoriaRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _produtoRepo.GetWithCategoriaAsync();

            ViewBag.Title = "Produtos";

            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {

            var title = "Adicionar ";
            ProdutosAddEditVM model = null;

            if (id != null)
            {
                var data = await _produtoRepo.GetAsync(id);
                model = data.ToVM();
                title = "Editar";
            }

            ViewBag.Title = title + " Produto";
            await getCategoriasSelect();

            return View(model);
        }

        private async Task getCategoriasSelect()
        {
            var categorias = await _categoriaRepo.GetAsync();
            ViewBag.Categorias = categorias.Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Nome });
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(int id, ProdutosAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                await getCategoriasSelect();
                return View(model);
            }

            var data = model.ToData(id);
            if (id == 0)
            {
                _produtoRepo.Add(data);
            }
            else
            {
                _produtoRepo.Update(data);
            }

            await _unitOfWork.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _produtoRepo.GetAsync(id);

            if (data == null)
            {
                return BadRequest();
            }

            _produtoRepo.Delete(data);
            await _unitOfWork.CommitAsync();

            return Ok();
        }
    }
}
