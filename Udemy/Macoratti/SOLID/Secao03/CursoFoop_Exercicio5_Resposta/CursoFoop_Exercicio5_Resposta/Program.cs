using System;

namespace CursoFoop_Exercicio5_Resposta
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaria p1 = new Pizzaria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            p1.CriarPizza("calabresa");

            Console.ReadLine();
        }
    }
}
