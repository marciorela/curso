using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Domain.Entities
{
    [Table("TbProduto")]
    public class Produto : Entity
    {
        [Required, StringLength(100)]
        [Column("NomeProd", TypeName = "varchar(100)")]
        public string Nome { get; set; }

        public int CategoriaId { get; set; }
        
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        
        [Column(TypeName ="money")]
        public decimal PrecoUnitario { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Descricao { get; set; }
    }
}
