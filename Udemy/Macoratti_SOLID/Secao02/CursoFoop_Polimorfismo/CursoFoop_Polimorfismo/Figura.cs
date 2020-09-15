using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Polimorfismo
{
    class Figura
    {
        public int Lado { get; set; }
        public virtual void Desenhar()
        {
            Console.WriteLine("Executando Desenhar na classe base");
        }
    }
}
