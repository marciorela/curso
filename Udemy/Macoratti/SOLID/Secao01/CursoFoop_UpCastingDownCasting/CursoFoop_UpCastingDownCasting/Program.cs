using System;
namespace CursoFoop_UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //DownCasting();
            //DownCasting_AS();
            Circulo circulo = new Circulo();
            Forma f = circulo;      //upcasting -> implicita

            if(f is Circulo) //verifico se a conversão é possível
            {
                ((Circulo)f).PintarCirculo();
            }
            else
            {
                Console.WriteLine("A conversão não é possível");
            }

            Console.ReadLine();
        }

        private static void DownCasting_AS()
        {
            Forma f = new Forma();
            Circulo c = f as Circulo;
            if (c != null)
            {
                c.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
        }

        private static void DownCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;  //upcasting -> implicita

            Circulo c = (Circulo)f;  //downcasting

            Console.WriteLine(c == f);
            Console.WriteLine(c == circulo);

            c.Desenhar();
            c.PintarCirculo();
        }

        private static void UpCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            Console.WriteLine(f == circulo);

            f.Desenhar();
        }
    }
}
