using System;

namespace CursoFoop_Exercicio5_Resposta
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        { }
        public override int AssarPizza()
        {
            var tempo = 20;
            Console.WriteLine($"Assando pizza de {Nome} " +
                $"por {tempo} minutos");
            return tempo;
        }
    }
}
