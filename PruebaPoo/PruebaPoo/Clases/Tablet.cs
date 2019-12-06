using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPoo.Clases
{
    public class Tablet : Dispositivos
    {
        public Tablet(Cliente cliente, string imei, string marca, string modelo, string sistemaoperativo, string tipo, string chip, string pais)
            :base(cliente,imei,marca,modelo,sistemaoperativo,tipo)
        {
            Chip = chip;
            Pais = pais;
        }
        
        private string chip;

        public string Chip
        {
            get { return chip; }
            set { chip = value; }
        }


        private string pais;

        public  string Pais   
        {
            get { return pais; }
            set { pais = value; }
        }

        public override string ToString()
        {
            return this.Imei + "       |" + this.Marca + "       |" + this.Sistemaoperativo + "       |" + this.Modelo + "       |" + this.Tipo + "       |" + this.Chip + "       |" + this.Pais;
        }
    }
}
