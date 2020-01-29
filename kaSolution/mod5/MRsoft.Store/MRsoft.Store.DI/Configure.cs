using Microsoft.Extensions.DependencyInjection;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Data.EF.Repositories;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.DI
{
    public static class Configure
    {
        public static void AddDI(this IServiceCollection services)
        {
            services.AddScoped<StoreDataContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IProdutoRepository, ProdutoRepositoryEF>();
            services.AddTransient<ICategoriaRepository, CategoriaRepositoryEF>();
            services.AddTransient<IUsuarioRepository, UsuarioRepositoryEF>();
        }
    }
}
