namespace CursoFoop_Exercicio3
{
    class CalculaImpostoBrazil : ICalcularImpostoPais
    {
        public decimal TotalDeducao { get; set; }
        public decimal TotalRenda { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 20 / 100;
        }
    }
}
