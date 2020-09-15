using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_RelacionamentoHeranca
{
    class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }
        public double CreditoJuros(double valorJuros)
        {
            return Saldo + valorJuros;
        }
    }
}
