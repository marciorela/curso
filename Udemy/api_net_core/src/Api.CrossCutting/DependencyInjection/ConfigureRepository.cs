using System;
using Api.Data.Constant;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            if (Environment.GetEnvironmentVariable("DATABASE").ToLower() == "mysql")
            {
                serviceCollection.AddDbContext<MyContext>(
                    // options => options.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION"))
                    options => options.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"))
                );
            }


        }
    }
}
