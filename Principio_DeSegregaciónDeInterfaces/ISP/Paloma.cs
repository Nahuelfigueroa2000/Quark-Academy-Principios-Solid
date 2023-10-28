using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_DeSegregaciónDeInterfaces.ISP
{
    internal class Paloma : IAvePonerHuevos, IAveComer, IAveVolar
    {
        public void Comer()
        {
            Console.WriteLine("La ave paloma esta comiendo");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("La ave paloma esta poniendo huevos");
        }

        public void Volar()
        {
            Console.WriteLine("La ave paloma esta volando");
        }
    }
}
