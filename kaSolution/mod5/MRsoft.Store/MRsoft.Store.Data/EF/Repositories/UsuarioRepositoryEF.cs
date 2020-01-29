using Microsoft.EntityFrameworkCore;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(StoreDataContext ctx) : base(ctx)
        {
        }

        public async Task<Usuario> AuthenticateAsync(string userName, string password)
        {
            return await _db.FirstOrDefaultAsync(u => u.Email == userName && u.Senha == password.Encrypt());
        }
    }
}
