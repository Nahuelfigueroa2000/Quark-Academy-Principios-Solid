using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ResponsabilidadUnica.ResponsabilidadUnica
{
    internal class Salario
    {
        public void MostrarSalario(Empleado empleado)
        {
            Console.WriteLine($"El salario del Empleado es {empleado.Salario}$");
        }
    }
}
