using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ResponsabilidadUnica.ResponsabilidadUnica
{
    internal class EmpleadoNombreCompleto
    {
        public void DecirNombreCompleto(Empleado empleado)
        {
            Console.WriteLine($"El nombre completo del Empleado es {empleado.NombreCompleto}");
        }
    }
}
