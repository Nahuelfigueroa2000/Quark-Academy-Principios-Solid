using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_InversionDeDependencia.DIP
{
    internal class Interruptor
    {
        private readonly IDispositivo dispositivo;

        public Interruptor(IDispositivo dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        public void EncenderDispositivo()
        {
            dispositivo.Encender();
        }

        public void ApagarDispositivo()
        {
            dispositivo.Apagar();
        }
    }
}
