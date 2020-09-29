using System;

namespace Aula_Classes1
{
    public class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome} tenho {idade} anos, sou do sexo {genero}");
        }
    }
}
