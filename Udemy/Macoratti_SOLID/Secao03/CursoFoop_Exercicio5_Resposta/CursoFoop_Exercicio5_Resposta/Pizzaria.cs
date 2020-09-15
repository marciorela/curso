namespace CursoFoop_Exercicio5_Resposta
{
    class Pizzaria
    {
        private Pizza pizza;
        PizzaFactory factory;
        public Pizzaria(PizzaFactory factory)
        {
            this.factory = factory;
        }
        public void CriarPizza(string tipo)
        {
            pizza = factory.CriarPizza(tipo);
            pizza.AssarPizza();
            pizza.DeliveryPizza();
        }
    }
}
