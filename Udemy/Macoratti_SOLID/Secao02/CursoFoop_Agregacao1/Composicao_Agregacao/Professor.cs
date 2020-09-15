using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacao
{
    class Professor : IDisposable
    {
        public string Nome { get; set; }
        public void Dispose() { }
    }
}
