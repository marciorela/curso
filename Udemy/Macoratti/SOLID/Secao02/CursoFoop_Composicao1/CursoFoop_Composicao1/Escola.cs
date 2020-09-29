using System;
using System.Collections.Generic;

namespace CursoFoop_Composicao1
{
    class Escola : IDisposable
    {
        public string Nome { get; set; }

        private List<Departamento> departamentos =
                      new List<Departamento>();

        public void AddDepartamento(string nome)
        {
            departamentos.Add(new Departamento(this, nome));
        }

        public void Dispose()
        {
            foreach (var departamento in departamentos)
            {
                departamento.Dispose();
            }
        }

        private class Departamento : IDisposable
        {
            private Escola escola;
            private string nome;
            internal Departamento(Escola escola, string nome)
            {
                this.escola = escola;
                this.nome = nome;
            }
            public void Dispose()
            {
                // Destroi o departamento
            }
        }

    }
}
