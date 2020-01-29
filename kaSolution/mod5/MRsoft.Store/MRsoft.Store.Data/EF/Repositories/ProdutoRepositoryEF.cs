using Microsoft.EntityFrameworkCore;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(StoreDataContext ctx) : base(ctx)
        {
        }

        public async Task<Produto> GetByNomeAsync(string nome)
        {
            return await _db.FirstOrDefaultAsync(p => p.Nome == nome);
        }

        public async Task<IEnumerable<Produto>> GetWithCategoriaAsync()
        {
            return await _db.Include(c => c.Categoria).ToListAsync();
        }
    }
}
