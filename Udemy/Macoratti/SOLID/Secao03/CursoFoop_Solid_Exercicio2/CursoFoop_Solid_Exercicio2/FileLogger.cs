using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\LogOcorrencias.txt", mensagem);
        }
    }
}
