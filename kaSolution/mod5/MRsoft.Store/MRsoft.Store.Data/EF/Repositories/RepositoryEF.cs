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
    public class RepositoryEF<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly StoreDataContext _ctx;
        protected readonly DbSet<TEntity> _db;

        public RepositoryEF(StoreDataContext ctx)
        {
            _ctx = ctx;
            _db = _ctx.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _db.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _db.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            //_db.Skip().take();

            return await _db.ToListAsync();
        }

        public async Task<TEntity> GetAsync(object pk)
        {
            return await _db.FindAsync(pk);
        }

        public void Update(TEntity entity)
        {
            _db.Update(entity);
            //_ctx.Entry(entity).State = EntityState.Modified;
        }
    }

}
