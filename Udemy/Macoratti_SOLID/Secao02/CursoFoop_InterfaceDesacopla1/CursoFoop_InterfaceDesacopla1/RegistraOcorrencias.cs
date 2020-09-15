using System;

namespace CursoFoop_InterfaceDesacopla1
{
    class RegistraOcorrencias
    {
        private readonly IRegistro _registro;

        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
