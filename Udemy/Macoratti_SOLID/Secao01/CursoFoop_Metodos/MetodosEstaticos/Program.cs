using System;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Soma = " + calc.Somar(8,2));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(8, 2));

            Console.ReadLine();
        }
    }
}
