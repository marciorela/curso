using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio10
{
    class Reptil : Animal
    {
        public Reptil(string tipoAnimal): base(tipoAnimal)
        {
        }
        public override void Mover()
        {
            Console.WriteLine("Rastejando 100 metros");
        }
    }
}
