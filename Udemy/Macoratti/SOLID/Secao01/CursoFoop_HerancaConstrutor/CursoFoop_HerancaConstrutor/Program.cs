using System;

namespace CursoFoop_HerancaConstrutor
{
    public class Veiculo
    {
        private string numeroChasis;
        public Veiculo(string _numeroChasis)
        {
            numeroChasis = _numeroChasis;
            Console.WriteLine($"Inicializando Veiculo: {_numeroChasis}");
        }
        public Veiculo()
        {
            Console.WriteLine("Inicializando veiculo");
        }

        public virtual void Teste()
        {
            Console.WriteLine("acessei teste");
        }
    }

    public class Carro : Veiculo
    {
        public Carro(string numeroChasis): base(numeroChasis)
        {
            //inicializar outros campos da classe Carro
            Console.WriteLine($"Inicializando Carro: {numeroChasis}");
        }
        public Carro()
        {
            Console.WriteLine("Inicializando Carro");
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("sobrescrevi teste");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro("DJDDJ88888888");
            carro.Teste();
            Console.ReadLine();
        }
    }
}
