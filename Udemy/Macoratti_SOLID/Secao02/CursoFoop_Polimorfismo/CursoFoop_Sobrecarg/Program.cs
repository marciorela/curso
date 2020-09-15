using System;

namespace CursoFoop_Sobrecarg
{

    class Calcular
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();

            Console.WriteLine(calc.Somar(34, 45));

            Console.WriteLine(calc.Somar(34, 45, 54));

            Console.ReadLine();
        }
    }
}
