using CadCli.Models;
using CadCli.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Data
{
    public class CadCliDataContext : DbContext
    {
        //private IConfiguration _config;

        //public CadCliDataContext(IConfiguration config)
        //{
        //    _config = config;
        //    Database.EnsureCreated();
        //}

        private IConfigSistemaService _config;
        public CadCliDataContext(IConfigSistemaService config)
        {
            _config = config;
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_config.GetConnectionString("CadCli"));
            optionsBuilder.UseSqlServer(_config.Dados.ConnString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente() { Id = 1, Nome = "Joaquim1", Idade = 31, DataCadastro = DateTime.Now },
                new Cliente() { Id = 2, Nome = "Joaquim2", Idade = 32, DataCadastro = DateTime.Now },
                new Cliente() { Id = 3, Nome = "Joaquim3", Idade = 33, DataCadastro = DateTime.Now },
                new Cliente() { Id = 4, Nome = "Joaquim4", Idade = 34, DataCadastro = DateTime.Now },
                new Cliente() { Id = 5, Nome = "Joaquim5", Idade = 35, DataCadastro = DateTime.Now },
                new Cliente() { Id = 6, Nome = "Joaquim6", Idade = 36, DataCadastro = DateTime.Now },
                new Cliente() { Id = 7, Nome = "Joaquim7", Idade = 37, DataCadastro = DateTime.Now },
                new Cliente() { Id = 8, Nome = "Joaquim8", Idade = 38, DataCadastro = DateTime.Now }
            );
        }
    }
}
