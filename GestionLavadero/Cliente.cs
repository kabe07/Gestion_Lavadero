using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionLavadero
{
    [Serializable]
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
        public void AgregarVehiculo(string marca,string modelo,TipoVehiculo tipo)
        {
            Vehiculo vehiculo = new Vehiculo(marca, modelo, tipo);
            vehiculos.Add(vehiculo);
        }
        public List<Vehiculo> MostrarVehiculos()
        {
            return vehiculos;
        }
        public override string ToString()
        {
            return $"{Nombre}-{Dni}";
        }

    }
}
