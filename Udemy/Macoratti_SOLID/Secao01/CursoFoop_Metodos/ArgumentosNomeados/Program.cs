using System;

namespace ArgumentosNomeados
{
    class Program
    {
        static void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }
        static void Main(string[] args)
        {
            Enviar(destino: "macoratti@yahoo.com", assunto: "Teste",
                titulo: "Urgente");

            Enviar(assunto: "Enviar o rascunho do projeto", titulo: "Enviar rascunho", 
                destino: "macoratti@ig.com.br");

            Enviar(titulo: "Ligar urgente", destino: "macoratti@yahoo.com", 
                assunto: "Ligar para o diretor");


            Console.ReadLine();
        }
    }
}
