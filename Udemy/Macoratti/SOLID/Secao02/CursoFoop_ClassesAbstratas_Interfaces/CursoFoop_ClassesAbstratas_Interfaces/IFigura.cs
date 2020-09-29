using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_ClassesAbstratas_Interfaces
{
    interface IFigura
    {
        string Nome { get; set; }
        void Desenhar();
        void Identificar();
        void Duplicar();
    }
}
