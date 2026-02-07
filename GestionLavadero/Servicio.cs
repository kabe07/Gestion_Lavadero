using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    [Serializable]
    internal class Servicio
    {
        private TipoServicio tipo;
        private Dictionary<TipoVehiculo, double> precios;
        public Servicio(TipoServicio tipo)
        {
            this.tipo = tipo;
            this.precios = precios = new Dictionary<TipoVehiculo, double>();

        }
        public double ObtenerPrecioBase(TipoVehiculo tipo)
        {
            return precios[tipo];
        }
        public void AgregarPrecio(TipoVehiculo tipovehiculo,double precio)
        {
            precios[tipovehiculo] = precio;
        }
        public override string ToString()
        {
            return $"{tipo.ToString()}";
        }
    
    }
}
