using System;

namespace CursoFoop_Interfaces
{
    class GravarJson : ArquivoBase, IGravar
    {
        public void GravarArquivo()
        {
            Console.WriteLine("Gravar arquivo em GravarJson");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome em GravarJson");
        }
    }
}
