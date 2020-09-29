using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Context
{
    class AppDbContext : DbContext
    {
        private IConfiguration _config;

        public DbSet<Estudante> Estudantes { get; set; }

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(_config.GetConnectionString("mysql"));
        }

    }

}
