namespace CursoFoop_Nomenclatura1
{
    class Program
    {
        static void Main(string[] args)
        {
            //válidos
            string nomeAluno = "joao";
            int idadeMinima = 10;
            int IdadeMinima = 20;
            double _taxa = 1.25;
            int numero_aluno1 = 10;
            double y2x5_w7 = 3.4;
            var \u0043sharp = "Csharp";

            //Inválidos
            bool verifica#conta = true;
                int decimal = 34.00;
            string 1sexo = "masculino";
            string #cliente ="teste";
            int idade@Maxima = 99;

            var nome = "Maria";
            var valor = 10;
            
        }
    }

    class CalculaDesconto
    {
        double taxaEncargos = 1.99;
        public int ValorImpostoTotal { get; set; }
        public double CalculoEncargos(double valorTotal)
        {
            return valorTotal * taxaEncargos;
        }
    }
}
