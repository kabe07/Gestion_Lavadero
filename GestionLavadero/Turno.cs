using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    internal class Turno
    {
        private DateTime fechayhora;
        private Vehiculo vehiculo;
        private Servicio servicio;
        private double extra;
        private double descuento;
        public Turno(DateTime fecha, Vehiculo vehiculo, Servicio servicio)
        {
            fechayhora = fecha;
            this.vehiculo = vehiculo;
            this.servicio = servicio;
        }
        public double CalcularPrecioFinal()
        {
            return servicio.ObtenerPrecioBase(vehiculo.Tipo);
        }
        public string ToString()
        {
            return $"Servicio fecha:{fechayhora} vehiculo:{vehiculo.ToString()} servicio:{servicio.ToString()}";
        }
    }
}
