using Principio_DeSegregaciónDeInterfaces.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_DeSegregaciónDeInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paloma paloma = new Paloma();
            Gallina gallina = new Gallina();

            paloma.Volar();
            paloma.Comer();
            paloma.PonerHuevos();
            Console.WriteLine("------------------");
            gallina.PonerHuevos();
            gallina.Comer();
            Console.ReadKey();
        }
    }
}
