using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaPoo.Clases;

namespace PruebaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente y tres celulares del cliente
            Cliente cliente = new Cliente("Diego", "1315729770");
            //lista de Celulares del cliente
            Tablet dispo1 = new Tablet(cliente, "5621456", "Samsung", "S5", "Android", "Tablet", "Tiene Chip", "China"  );
            Dispositivos dispo2 = new Dispositivos(cliente, "598874", "iPhone", "X", "iOS", "Telefono" );
            Dispositivos dispo3 = new Dispositivos(cliente, "559844", "Huawei", "Mat20", "Android", "Telefono" );
            List<Dispositivos> Dispositivos = new List<Dispositivos>();
            Dispositivos.Add(dispo1);
            Dispositivos.Add(dispo2);
            Dispositivos.Add(dispo3);
            
            //Instancia de la orden 1
            List<String> problemas1 = new List<string>();
            problemas1.Add("Problema con la pantalla");
            problemas1.Add("Bateria dañada");
            problemas1.Add("Sensor de luz dañado");

            List<HardwareAdicional> articulos = new List<HardwareAdicional>();
            HardwareAdicional articulo1 = new HardwareAdicional("Cargador", "Es el cargador del telefono");
            articulos.Add(articulo1);
            OrdenReparacion orden1 = new OrdenReparacion(dispo1, problemas1, articulos);

            //Instancia de la orden de reparación 2
            List<String> problemas2 = new List<string>();
            problemas2.Add("No enciende y ya se le cambio la patalla");
            problemas2.Add("La bateria Se descarga rápido");
            problemas2.Add("Vidrio trizado, cambiar vidrio");

            List<HardwareAdicional> articulos2 = new List<HardwareAdicional>();
            HardwareAdicional articulo2 = new HardwareAdicional("Auriculares", "Son los auriculares del celular");
            articulos2.Add(articulo1);
            articulos2.Add(articulo2);
           
            OrdenReparacion orden2 = new OrdenReparacion(dispo2, problemas2, articulos);

            //lista de ordenes del cliente
            List<OrdenReparacion> ordenes = new List<OrdenReparacion>();
            ordenes.Add(orden1);
            ordenes.Add(orden2);

            int i= 0;
            
            foreach (OrdenReparacion item in ordenes)
            {
                Console.WriteLine("Datos del cliente: " + cliente.Nombre + "          Cedula: " + cliente.Identificacion + "\n");
                if (i == 0)
                {
                    if (item.Dispositivo.Tipo == "Tablet") { Console.WriteLine("La tablet a reparar es :" + dispo1.ToString() + "\n"); }
                    else { 
                    Console.WriteLine("El Celular a reparar es :" + dispo1.ToString() + "\n");}
                    foreach (var daños in problemas1)
                    {
                        Console.WriteLine("Daño del celular :" + daños + "\n");
                    }
                    foreach (HardwareAdicional art in articulos)
                    {
                        Console.WriteLine("hardware adicional :" + art + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("El Celular a reparar es :" + dispo2 + "\n");
                    foreach (var daños in problemas2)
                    {
                        Console.WriteLine("Daño del celular :" + daños + "\n");
                    }
                    foreach (HardwareAdicional art in articulos)
                    {
                        Console.WriteLine("hardware adicional :" + art + "\n");
                    }
                }
                i = 1;
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
            }
            Console.ReadKey();
        }
    }
}
