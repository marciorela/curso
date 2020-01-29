using Microsoft.EntityFrameworkCore;
using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Data.EF
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Id = 1, Nome = "Usuario1", Email = "11@11.com", Senha = "11".Encrypt() },
                new Usuario() { Id = 2, Nome = "Usuario2", Email = "22@22.com", Senha = "22".Encrypt() }
            );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria() { Id = 1, Nome = "Categoria1"},
                new Categoria() { Id = 2, Nome = "Categoria2"}
            );

            modelBuilder.Entity<Produto>().HasData(
                new Produto() { Id = 1, Nome = "Produto1", Descricao = "Desc Produto1", CategoriaId = 1, PrecoUnitario = 100.2M },
                new Produto() { Id = 2, Nome = "Produto2", Descricao = "Desc Produto2", CategoriaId = 1, PrecoUnitario = 50.0M },
                new Produto() { Id = 3, Nome = "Produto3", Descricao = "Desc Produto3", CategoriaId = 2, PrecoUnitario = 60.0M }
            );

        }

    }
}
