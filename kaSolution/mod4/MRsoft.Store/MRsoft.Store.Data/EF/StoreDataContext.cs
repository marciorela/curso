using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Data.EF
{
    public class StoreDataContext : DbContext
    {
        private IConfiguration _config;

        public StoreDataContext(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;

            if (env.IsDevelopment())
            {
                Database.EnsureCreated();
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("StoreConn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Id = 1, Nome = "Usuario1", Email = "11@11.com", Senha = "11".Encrypt() },
                new Usuario() { Id = 2, Nome = "Usuario2", Email = "22@22.com", Senha = "22".Encrypt() }
            );
        }
    }
}
