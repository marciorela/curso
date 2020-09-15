using System;

namespace CursoFoop_Interfaces
{
    class GravarXml : ArquivoBase, IGravar
    {
        public void GravarArquivo()
        {
            Console.WriteLine("Gravar arquivo em GravarXml");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome em GravarXml");
        }

    }
}
