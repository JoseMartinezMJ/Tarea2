using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Interfaces
{
    public abstract class CelularBaseAbstracta
    {
        //Propiedades o caracteriticas para las demas clases
        public abstract string Nombre { get; set; }
        public abstract string Marca { get; set; }
        public abstract string Software { get; set; }
        public abstract int Almacenamiento { get; set; }
        public abstract float Precio { get; set; }

    }
}
