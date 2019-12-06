using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPoo.Clases
{
    public class Dispositivos
    {
        public Dispositivos(Cliente cliente, string imei, string marca, string modelo, string sistemaoperativo, string tipo)
        {
            Cliente = cliente;
            Imei = imei;
            Marca = marca;
            Sistemaoperativo = sistemaoperativo;
            Modelo = modelo;
            Tipo = tipo;
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        private string imei;

        public string Imei
        {
            get { return imei; }
            set { imei = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string sistemaoperativo;

        public string Sistemaoperativo
        {
            get { return sistemaoperativo; }
            set { sistemaoperativo = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public override string ToString()
        {
            return this.Imei + "       |" +  this.Marca + "       |" + this.Sistemaoperativo + "       |" + this.modelo + "       |" + this.Tipo;  
        }
    }
}

