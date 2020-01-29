using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly ICategoriaRepository _categRepo;

        public CategoriasController(ICategoriaRepository categRepo, IUnitOfWork uow)
        {
            _uow = uow;
            _categRepo = categRepo;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var data = await _categRepo.GetAsync();
            return Ok(data);
        }

        [HttpGet("{id}", Name = "GetCategoriaById")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _categRepo.GetAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CategoriasAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var data = model.ToData();
            _categRepo.Add(data);
            await _uow.CommitAsync();

            return CreatedAtRoute("GetCategoriaById", new { id = data.Id }, data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]CategoriasAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var data = model.ToData(id);
            _categRepo.Update(data);
            await _uow.CommitAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _categRepo.GetAsync(id);
            if (data == null)
            {
                return BadRequest(new { error = "Categoria não localizada" });
            }

            _categRepo.Delete(data);
            await _uow.CommitAsync();

            return NoContent();
        }
    }
}
