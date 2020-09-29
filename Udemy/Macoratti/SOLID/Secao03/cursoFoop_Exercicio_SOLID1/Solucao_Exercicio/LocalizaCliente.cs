using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao_Exercicio
{
    class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Pais == pais);
            return resultado;
        }
        public static Cliente ProcuraPorNome(string nome)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Nome == nome);
            return resultado;
        }
    }
}
