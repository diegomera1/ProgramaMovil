using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPoo.Clases
{
    public class HardwareAdicional
    {
        public HardwareAdicional(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public HardwareAdicional() { }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public override string ToString()
        {
            return this.Nombre + "       |" + this.Descripcion;
        }
    }
}
