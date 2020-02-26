using Pattern.STRATEGY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.STRATEGY.Servicios
{
    public class ConcretarJPGEServicio : IEstrategia
    {
        public void GeneraDescripcion(string _cNombre)
        {
            Console.WriteLine("Se ha guardado la imagen {0}.JPGE", _cNombre);
        }
    }
}
