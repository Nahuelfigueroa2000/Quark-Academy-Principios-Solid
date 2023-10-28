using Principios_PrincipioDeAbiertoYCerrado.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_PrincipioDeAbiertoYCerrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneradorDeInformePdf generadorDeInformePdf = new GeneradorDeInformePdf();
            generadorDeInformePdf.GenerarInforme();
            
            GeneradorDeInformeWord generadorDeInformeWord = new GeneradorDeInformeWord();
            generadorDeInformeWord.GenerarInforme();

            Console.ReadKey();
        }
    }
}
