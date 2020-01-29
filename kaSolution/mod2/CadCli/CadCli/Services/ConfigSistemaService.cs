using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCli.Services
{
    public class ConfigSistemaService : IConfigSistemaService
    {
        private IConfiguration _config;
        private ConfigSistemaModel _dados;

        public ConfigSistemaService(IConfiguration config)
        {
            _config = config;
            _dados = new ConfigSistemaModel()
            {
                ConnString = _config.GetConnectionString("CadCli"),
                VersaoSistema = _config["DadosSistema:Versao"],
                Descricao = _config["DadosSistema:Descricao"]
            };
        }

        public ConfigSistemaModel Dados => _dados;
    }
}
