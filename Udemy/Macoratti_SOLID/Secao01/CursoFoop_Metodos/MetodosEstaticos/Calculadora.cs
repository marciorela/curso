using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosEstaticos
{
    class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
