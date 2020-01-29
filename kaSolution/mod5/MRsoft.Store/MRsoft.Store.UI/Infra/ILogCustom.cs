using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Infra
{
    public interface ILogCustom
    {
        void Error(string msg);
        void Info(string msg);
        void Warning(string msg);

    }
}
