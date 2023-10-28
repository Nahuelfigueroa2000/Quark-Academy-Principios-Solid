using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_InversionDeDependencia.DIP
{
    internal class Luz : IDispositivo
    {
        public void Encender()
        {
            Console.WriteLine("Encender la luz");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagar la luz");
        }
    }
}
