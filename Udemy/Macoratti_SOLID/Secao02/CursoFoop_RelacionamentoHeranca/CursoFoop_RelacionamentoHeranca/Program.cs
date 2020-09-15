using System;

namespace CursoFoop_RelacionamentoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = cp.Deposito(110);
            cp.Saldo = cp.Saque(10);
            Console.WriteLine($"Poupança : {cp.CreditoJuros(5)}");

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = cc.Deposito(110);
            cc.Saldo = cc.Saque(10);
            Console.WriteLine($"Conta Corrente : {cc.DescontoJuros(10)}");

            Console.ReadLine();
        }
    }
}
