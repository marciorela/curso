using System;

namespace CursoFoop_Metodos
{
    class Program
    {
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var num in numeros)
                resultado = resultado + num; // resultado += num;
            return resultado;
        }

        static void Main(string[] args)
        {
            var resultado1 = Somar(100, 200);
            var resultado2 = Program.Somar(100, 200, 300);

            var resultado3 = Somar(new int[] { 1, 2, 3, 4 });
            var resultado4 = Somar(1, 2, 3, 4);


            Console.ReadLine();
        }
    }
}

