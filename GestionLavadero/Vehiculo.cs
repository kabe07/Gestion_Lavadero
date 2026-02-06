using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    internal class Vehiculo
    {
        private string marca;
        private string modelo;
        public TipoVehiculo Tipo;
        public Vehiculo(string marca, string modelo, TipoVehiculo tipo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.Tipo = tipo;
        }
        public string ToString()
        {
            return $"Vehiculo marca:{marca}-modelo:{modelo}-tipo:{Tipo}";
        }
    }
}
