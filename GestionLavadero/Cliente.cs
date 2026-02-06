using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    internal class Cliente
    {
        private string nombre;
        private int dni;
        public string Nombre { get; set; }
        public int Dni { get; set; }
        private List<Vehiculo> vehiculos;
        public Cliente(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
            vehiculos = new List<Vehiculo>();

        }
        public string ToString()
        {
            return $"Cliente nombre:{Nombre}-Dni:{Dni}";
        }

    }
}
