using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Domain.Contracts.Data
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task RollbackAssync();
    }
}
