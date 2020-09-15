using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio10
{
    abstract class Animal
    {
        public string Tipo { get; set; }
        public Animal(string tipoAnimal)
        {
            Tipo = tipoAnimal;
        }
        public abstract void Mover();
    }
}
