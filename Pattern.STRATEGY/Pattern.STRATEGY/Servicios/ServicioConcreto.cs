using Pattern.STRATEGY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.STRATEGY.Servicios
{
    public class ServicioConcreto
    {
        private IEstrategia estrategia;

        public ServicioConcreto(IEstrategia _estrategia)
        {
            this.estrategia = _estrategia;
        }

        public void generar(string _cNombre)
        {
            estrategia.GeneraDescripcion(_cNombre);
        }
    }
}
