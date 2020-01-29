using MRsoft.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Models
{
    public class ProdutosAddEditVM
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Informe a categoria.")]
        public int CategoriaId { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe o preço correto.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Valor inválido - Mín {1} Máx: {2}")]
        public decimal? Preco { get; set; }

        [StringLength(300, ErrorMessage = "limite de {1} excedido.")]
        public string Descricao { get; set; }

    }

    public static class ProdutosModelExtensions
    {
        public static ProdutosAddEditVM ToVM(this Produto data)
        {
            return new ProdutosAddEditVM()
            {
                Nome = data.Nome,
                CategoriaId = data.CategoriaId,
                Preco = data.PrecoUnitario,
                Descricao = data.Descricao
            };
        }

        public static Produto ToData(this ProdutosAddEditVM model, int id = 0)
        {
            return new Produto()
            {
                Id = id,
                Nome = model.Nome,
                CategoriaId = (int)model.CategoriaId,
                PrecoUnitario = (decimal)model.Preco,
                Descricao = model.Descricao
            };
        }
    }
}
