using System;

namespace Aula_Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Paulo";
            pessoa1.idade = 45;
            pessoa1.genero = "Masculino";
            pessoa1.Identificar();

            Pessoa pessoa2 = new Pessoa("Amanda",44,"feminino");
            pessoa2.Identificar();

            Pessoa pessoa3 = new Pessoa("Bianca");
            pessoa3.idade = 11;
            pessoa3.genero = "feminino";
            pessoa3.Identificar();
        }
    }
}
