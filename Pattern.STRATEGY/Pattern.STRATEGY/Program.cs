using Pattern.STRATEGY.Interfaces;
using Pattern.STRATEGY.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.STRATEGY
{
    class Program
    {
        static void Main(string[] args)
        {
            string cNombre = string.Empty, cExtension = string.Empty;
            IEstrategia estrategia = null;

            Console.WriteLine("Ingrese el nombre del archivo");
            cNombre = Console.ReadLine();
            Console.WriteLine("Ingrese la extensión del archivo");
            cExtension = Console.ReadLine();

            switch (cExtension.ToUpper())
            {
                case "BMP":
                    estrategia = new ConcretarBMPServicio();
                    break;
                case "JPGE":
                    estrategia = new ConcretarJPGEServicio();
                    break;
                case "PNG":
                    estrategia = new ConcretarPNGServicio();
                    break;
            }

            ServicioConcreto srvConcreto = new ServicioConcreto(estrategia);
            srvConcreto.generar(cNombre);

            Console.ReadKey();

        }
    }
}
