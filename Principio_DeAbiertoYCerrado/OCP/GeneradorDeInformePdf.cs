using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_PrincipioDeAbiertoYCerrado.OCP
{
    internal class GeneradorDeInformePdf : IGeneradorDeInforme
    {
        public void GenerarInforme()
        {
            Console.WriteLine("Informe en formato PDF");
        }
    }
}
