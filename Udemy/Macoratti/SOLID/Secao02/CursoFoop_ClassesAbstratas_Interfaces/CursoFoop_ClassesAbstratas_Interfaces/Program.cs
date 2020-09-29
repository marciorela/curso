using System;

namespace CursoFoop_ClassesAbstratas_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado("Quadrado");
            quadrado.Desenhar();
            quadrado.Identificar();

            var triangulo = new Triangulo("Triangulo");
            triangulo.Desenhar();
            triangulo.Identificar();

            Console.ReadLine();
        }
    }
}
