using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Services
{
    public class ConfigSistemaServiceWeb : IConfigSistemaService
    {
        private ConfigSistemaModel _dados;

        public ConfigSistemaServiceWeb()
        {
            _dados = new ConfigSistemaModel()
            {
                ConnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=cadclidb_11;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
                VersaoSistema = "1.1",
                Descricao = "Dados obtidos a partir de outra classe"
            };
        }

        public ConfigSistemaModel Dados => _dados;
    }
}
