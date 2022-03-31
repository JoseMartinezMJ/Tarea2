using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Interfaces
{
    public class ClaseHuawei : CelularBaseAbstracta
    {
        public override string Nombre { get; set; }
        public override string Marca { get; set; }
        public override string Software { get; set; }
        public override int Almacenamiento { get; set; }
        public override float Precio { get; set; }

        //Constructores
        public ClaseHuawei()
        {
            Nombre = string.Empty;
            Marca = string.Empty;
            Software = string.Empty;
            Precio = 0;
        }
        public ClaseHuawei(string nombre, string marca, string software,int almacenamiento, float precio)
        {
            Nombre = nombre;
            Marca = marca;
            Software = software;
            Almacenamiento = almacenamiento;
            Precio = precio;
        }
    }
}
