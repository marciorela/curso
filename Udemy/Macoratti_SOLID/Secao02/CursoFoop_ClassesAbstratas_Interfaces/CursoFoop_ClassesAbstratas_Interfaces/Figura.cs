using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_ClassesAbstratas_Interfaces
{
    abstract class Figura
    {
        protected string Nome { get; set; }
        public Figura(string nome)
        {
            Nome = nome;
        }

        public abstract void Desenhar();
        public abstract void Identificar();

        protected void Duplicar()
        {
            Console.WriteLine("Duplicando a figura");
        }
    }
}
