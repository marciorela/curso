using System.Collections.Generic;

namespace Solucao_Exercicio
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public static List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente
                {
                    Nome="Pedro", Pais="Brasil", Email="pedro@email.com"
                },
                new Cliente
                {
                    Nome="Maria", Pais="Chile", Email="maria@email.com"
                }
            };
            return listaClientes;
        }
    }
}
