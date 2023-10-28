using Principio_ResponsabilidadUnica.ResponsabilidadUnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ResponsabilidadUnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Nahuel Figueroa", 50000);
            EmpleadoNombreCompleto nombreCompleto = new EmpleadoNombreCompleto();
            Salario salario = new Salario();

            nombreCompleto.DecirNombreCompleto(empleado);
            salario.MostrarSalario(empleado);
            Console.ReadKey();

        }
    }
}
