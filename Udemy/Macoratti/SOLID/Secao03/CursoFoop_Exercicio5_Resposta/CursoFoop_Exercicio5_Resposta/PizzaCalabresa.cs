using System;

namespace CursoFoop_Exercicio5_Resposta
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome): base(nome)
        {
        }
        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Nome}" +
                $" por {tempo} minutos");
            return tempo;
        }
    }
}
