using MRsoft.Store.Domain.Entities;
using MRsoft.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Domain.ViewModels
{
    public class UsuariosAddEditVM
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public static class UsuariosModelExtensions
    {
        public static UsuariosAddEditVM ToVM(this Usuario data)
        {
            return new UsuariosAddEditVM
            {
                Nome = data.Nome,
                Email = data.Email
            };
        }

        public static Usuario ToData(this UsuariosAddEditVM model, int id = 0)
        {
            return new Usuario
            {
                Id = id,
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha.Encrypt()
            };
        }
    }
}
