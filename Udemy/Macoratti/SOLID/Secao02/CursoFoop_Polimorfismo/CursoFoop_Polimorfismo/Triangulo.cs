using System;

namespace CursoFoop_Polimorfismo
{
    class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triangulo..");
            base.Desenhar();
        }
    }
}
