namespace CursoFoop_Exercicio3
{
    class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais icalc)
        {
            return icalc.CalcularValorImposto();
        }
    }
}
