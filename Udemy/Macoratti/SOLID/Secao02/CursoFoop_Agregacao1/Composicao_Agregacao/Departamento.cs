using System;
using System.Collections.Generic;

namespace Agregacao
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; }

        public void Dispose()
        {
        }
    }
}
