using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Models
{
    public class SignInVM
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Lembrar { get; set; }
    }
}
