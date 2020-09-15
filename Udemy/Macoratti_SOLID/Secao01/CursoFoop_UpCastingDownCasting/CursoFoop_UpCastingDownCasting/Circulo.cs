using System;

namespace CursoFoop_UpCastingDownCasting
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Circulo");
        }
        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o círculo");
        }
    }
}
