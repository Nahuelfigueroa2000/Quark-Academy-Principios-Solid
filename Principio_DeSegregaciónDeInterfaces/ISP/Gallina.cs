using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_DeSegregaciónDeInterfaces.ISP
{
    internal class Gallina : IAvePonerHuevos, IAveComer
    {
        public void Comer()
        {
            Console.WriteLine("Gallina esta comiendo");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("Gallina esta poniendo huevos");
        }
    }
}
