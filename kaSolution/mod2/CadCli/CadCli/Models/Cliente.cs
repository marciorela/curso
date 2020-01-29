using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Models
{
    [Table("tbCli")]
    public class Cliente
    {
        [Column("CodCliente")]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
