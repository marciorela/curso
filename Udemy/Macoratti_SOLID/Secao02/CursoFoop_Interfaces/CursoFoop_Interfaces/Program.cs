using System;

namespace CursoFoop_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GravarXml gravar = new GravarXml();
            gravar.GravarArquivo();
            gravar.Nome();

            //usar interface
            IGravar igravar = new GravarXml();
            igravar.GravarArquivo();
            //igravar.Nome();

            Console.ReadLine();
        }
    }
}
