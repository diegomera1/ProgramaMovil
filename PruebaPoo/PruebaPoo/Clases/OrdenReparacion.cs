using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPoo.Clases
{
    public class OrdenReparacion
    {

        public OrdenReparacion(Cliente cliente, Dispositivos dispositivo, List<string> problemas, List<HardwareAdicional> articulos)
        {
            Cliente = cliente;
            Dispositivo = dispositivo;
            Problemas = problemas;
            Articulos = articulos;
        }

        public OrdenReparacion() { }

        public OrdenReparacion(Dispositivos dispositivo, List<string> problemas, List<HardwareAdicional> articulos)
        {
            Dispositivo = dispositivo;
            Problemas = problemas;
            Articulos = articulos;
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Dispositivos dispositivo;

        public Dispositivos Dispositivo
        {
            get { return dispositivo; }
            set { dispositivo = value; }
        }

        private List<string> problemas;

        public List<string> Problemas
        {
            get { return problemas; }
            set { problemas = value; }
        }

        private List<HardwareAdicional> articulos;  

        public List<HardwareAdicional> Articulos
        {
            get { return articulos; }
            set { articulos = value; }
        }

        public override string ToString()
        {
            return Cliente.Nombre + Dispositivo + Problemas + Articulos;
        }
    }
}
