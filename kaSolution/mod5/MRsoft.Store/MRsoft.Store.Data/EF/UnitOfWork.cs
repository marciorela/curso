using MRsoft.Store.Domain.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Data.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDataContext _ctx;

        public UnitOfWork(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CommitAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public Task RollbackAssync()
        {
            return null;
        }
    }
}
