using System;

namespace CursoFoop_Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();
            Animal animal1 = new Ave("Pato");
            animal1.Mover();

            Animal animal2 = new Peixe("Sardinha");
            animal2.Mover();

            Animal animal3 = new Reptil("Largato");
            animal3.Mover();

            Console.ReadLine();
        }
    }
}
