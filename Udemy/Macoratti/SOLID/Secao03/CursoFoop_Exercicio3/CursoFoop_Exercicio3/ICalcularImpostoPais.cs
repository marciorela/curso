using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    interface ICalcularImpostoPais
    {
        decimal TotalRenda{ get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
