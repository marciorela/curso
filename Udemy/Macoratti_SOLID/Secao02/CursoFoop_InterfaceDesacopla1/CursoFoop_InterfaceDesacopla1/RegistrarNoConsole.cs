using System;

namespace CursoFoop_InterfaceDesacopla1
{
    class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info : {mensagem}");
        }
    }
}
