using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Tests.Controllers
{
    [TestClass]
    [TestCategory("Controllers - Categoria")]
    public class CategoriaCtrlTest
    {
        
        // DADO O CONTROLLER CategoriaController
        [TestMethod]
        public async Task OMetodoIndexDeveraPossuirUmaListaDeCategorias()
        {
            var catRepo = new CategoriaRepositoryFake();
            var uow = new UnitOfWorkFake();
            var catCtrl = new CategoriasController(catRepo, uow);

            var result = await catCtrl.Index() as ViewResult;
            var model = result.Model as IEnumerable<Categoria>;

            Assert.IsNotNull(model);
            Assert.AreEqual(model.Count(), 2);
        }
    }

    public class CategoriaRepositoryFake : ICategoriaRepository
    {
        public void Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetAsync()
        {
            var categorias = new List<Categoria>
            {
                new Categoria() { Id = 1, Nome = "Alimento"},
                new Categoria() { Id = 2, Nome = "Padaria"}
            };

            return Task.FromResult(categorias.AsEnumerable());
        }

        public Task<Categoria> GetAsync(object pk)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }

    public class UnitOfWorkFake : IUnitOfWork
    {
        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task RollbackAssync()
        {
            throw new NotImplementedException();
        }
    }
}
