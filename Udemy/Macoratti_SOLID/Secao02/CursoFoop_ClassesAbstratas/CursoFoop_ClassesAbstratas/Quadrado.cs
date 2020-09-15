using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_ClassesAbstratas
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Lado;
        }
    }
}
