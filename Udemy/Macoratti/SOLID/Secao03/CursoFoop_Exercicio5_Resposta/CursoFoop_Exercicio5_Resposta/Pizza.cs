using System;

namespace CursoFoop_Exercicio5_Resposta
{
    public abstract class Pizza
    {
        public Pizza(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public abstract int AssarPizza();
        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Nome}");
        }
    }
}
