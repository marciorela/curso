using System;
namespace Aula_Heranca
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Console.WriteLine("Construtor da classe Conta");
        }

        protected void GetSaldo()
        {
            Console.WriteLine("Saldo 99,99");
        }
    }
    class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }

        protected new void GetSaldo()
        {
            Console.WriteLine("Saldo 77,77");
        }

        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Numero = 100;
            cp.Saldo = 99.99;
            cp.GetSaldo();
        }
    }
}
