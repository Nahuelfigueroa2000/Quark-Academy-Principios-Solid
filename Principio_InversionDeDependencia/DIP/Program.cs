using Principio_InversionDeDependencia.DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_InversionDeDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Luz bombilla = new Luz();
            Interruptor interruptor = new Interruptor(bombilla);

            interruptor.EncenderDispositivo();
            interruptor.ApagarDispositivo();
            Console.ReadKey();
        }
    }
}
