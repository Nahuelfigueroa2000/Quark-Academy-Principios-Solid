using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_SustituciónDeLiskov.LSP
{
    internal class Circulo : Figura
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Radio * 2;
        }
    }
}
