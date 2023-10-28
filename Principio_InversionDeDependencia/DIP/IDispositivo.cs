using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_InversionDeDependencia.DIP
{
    internal interface IDispositivo
    {
        void Encender();
        void Apagar();
    }
}
