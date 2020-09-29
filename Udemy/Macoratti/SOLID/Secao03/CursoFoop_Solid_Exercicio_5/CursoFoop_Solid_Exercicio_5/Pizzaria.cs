namespace CursoFoop_Solid_Exercicio_5
{
    class Pizzaria
    {
        private Pizza pizza;
        public void CriarPizza(string tipo)
        {
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela();
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa();
            }
        }
    }
}
