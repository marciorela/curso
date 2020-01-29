using EntityFramework.Context;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<AppDbContext>();
    }
}
