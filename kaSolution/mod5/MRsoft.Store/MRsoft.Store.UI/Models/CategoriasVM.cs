using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Models
{
    public class CategoriasAddEditVM
    {
        public string Nome { get; set; }
    }

    public static class CategoriasVMExtensions
    {
        public static CategoriasAddEditVM ToVM(this Categoria data)
        {
            return new CategoriasAddEditVM
            {
                Nome = data.Nome
            };
        }

        public static Categoria ToData(this CategoriasAddEditVM model, int id = 0)
        {
            return new Categoria
            {
                Id = id,
                Nome = model.Nome
            };
        }
    }
}
