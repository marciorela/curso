using System;

namespace CursoFoop_Exercicio10
{
    class Peixe : Animal
    {
        public Peixe(string tipoAnimal) : base(tipoAnimal)
        {
        }
        public override void Mover()
        {
            Console.WriteLine("Nadando 100 metros");
        }
    }
}
