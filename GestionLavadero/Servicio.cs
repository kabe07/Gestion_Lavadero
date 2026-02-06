using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    internal class Servicio
    {
        private TipoServicio tipo;
        private Dictionary<TipoVehiculo, double> precios;
        public Servicio(TipoServicio tipo, Dictionary<TipoVehiculo,double> precios)
        {
            this.tipo = tipo;
            this.precios = precios;

        }
        public double ObtenerPrecioBase(TipoVehiculo tipo)
        {
            return precios[tipo];
        }
    
    }
}
