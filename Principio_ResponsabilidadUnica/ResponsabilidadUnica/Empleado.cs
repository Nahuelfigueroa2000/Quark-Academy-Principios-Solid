using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ResponsabilidadUnica.ResponsabilidadUnica
{
    internal class Empleado
    {
        public string NombreCompleto { get; }
        public int Salario { get; }

        public Empleado(string nombreCompleto, int salario)
        {
            this.NombreCompleto = nombreCompleto;
            this.Salario = salario;
        }
    }
}
