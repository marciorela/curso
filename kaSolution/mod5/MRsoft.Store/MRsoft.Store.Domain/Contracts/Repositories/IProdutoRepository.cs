using MRsoft.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> GetByNomeAsync(string nome);
        Task<IEnumerable<Produto>> GetWithCategoriaAsync();
    }
}
