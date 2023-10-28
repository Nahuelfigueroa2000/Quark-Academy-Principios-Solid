using Principio_SustituciónDeLiskov.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_SustituciónDeLiskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura figura1 = new Cuadrado { Lado = 5 };
            Figura figura2 = new Circulo { Radio = 3 };

            Console.WriteLine($"Área del cuadrado: {figura1.CalcularArea()}");
            Console.WriteLine($"Área del círculo: {figura2.CalcularArea()}");
            Console.ReadKey();
        }
    }
}
