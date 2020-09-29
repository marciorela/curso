using System;

namespace CursoFoop_Exercicio10
{
    class Ave : Animal
    {
        public Ave(string tipoAnimal) : base(tipoAnimal)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Voando 100 metros");
        }
    }
}
