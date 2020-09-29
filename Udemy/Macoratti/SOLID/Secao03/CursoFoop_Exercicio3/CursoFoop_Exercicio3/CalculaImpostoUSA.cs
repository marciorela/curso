using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    class CalculaImpostoUSA : ICalcularImpostoPais
    {
        public decimal TotalDeducao { get; set; }
        public decimal TotalRenda { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 30 / 100;
        }
    }
}
