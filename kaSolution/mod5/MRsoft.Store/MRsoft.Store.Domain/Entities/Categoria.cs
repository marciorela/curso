using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Domain.Entities
{
    public class Categoria : Entity
    {
        [Column("varchar(100)"), Required]
        public string Nome { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
