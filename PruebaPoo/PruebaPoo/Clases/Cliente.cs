using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPoo.Clases
{
    public class Cliente 
    {

        public Cliente(string nombre, string identificacion, List<Dispositivos> vehiculos, List<OrdenReparacion> ordenReparacions)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Vehiculos = vehiculos;
            OrdenReparacions = ordenReparacions;
        }
        public Cliente() { }

        public Cliente(string nombre, string identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private List<Dispositivos> vehiculos;

        public List<Dispositivos> Vehiculos
        {
            get { return vehiculos; }
            set { vehiculos = value; }
        }

        private List<OrdenReparacion> ordenReparacions;

        

        public List<OrdenReparacion> OrdenReparacions
        {
            get { return ordenReparacions; }
            set { ordenReparacions = value; }
        }
    }
}
