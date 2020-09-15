using System;
using CursoFoop_MethodosExtensao.Utils;

namespace CursoFoop_MethodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "madalena";

            //método de extensão
            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();
            
            Console.WriteLine(texto1);
            Console.WriteLine(texto2);

            Console.ReadLine();
        }
    }
}
