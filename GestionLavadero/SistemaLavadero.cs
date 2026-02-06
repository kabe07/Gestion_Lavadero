using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavadero
{
    internal class SistemaLavadero
    {
        private List<Servicio> servicios;
        private List<Turno> turnos;
        private List<Cliente> clientes;
        public SistemaLavadero()
        {
            servicios = new List<Servicio>();
            turnos = new List<Turno>();
            clientes = new List<Cliente>();
            InicializarServicios();
        }
        public void InicializarServicios()
        {
            Servicio lavado = new Servicio(TipoServicio.Lavado_comun);
            lavado.AgregarPrecio(TipoVehiculo.Auto, 20000);
            lavado.AgregarPrecio(TipoVehiculo.Moto, 10000);
            lavado.AgregarPrecio(TipoVehiculo.Suv, 22000);
            lavado.AgregarPrecio(TipoVehiculo.Pickup, 25000);
            servicios.Add(lavado);

            Servicio encerado = new Servicio(TipoServicio.Encerado);
            encerado.AgregarPrecio(TipoVehiculo.Moto, 3000);
            encerado.AgregarPrecio(TipoVehiculo.Auto, 5000);
            encerado.AgregarPrecio(TipoVehiculo.Suv, 5000);
            encerado.AgregarPrecio(TipoVehiculo.Pickup, 5000);
            servicios.Add(encerado);

            Servicio lavadomotor = new Servicio(TipoServicio.Lavado_motor);
            lavadomotor.AgregarPrecio(TipoVehiculo.Moto, 00000);
            lavadomotor.AgregarPrecio(TipoVehiculo.Auto, 15000);
            lavadomotor.AgregarPrecio(TipoVehiculo.Suv, 15000);
            lavadomotor.AgregarPrecio(TipoVehiculo.Pickup, 15000);
            servicios.Add(lavadomotor);

            Servicio limpiezatapizados = new Servicio(TipoServicio.Limpieza_tapizados);
            limpiezatapizados.AgregarPrecio(TipoVehiculo.Moto, 0);
            limpiezatapizados.AgregarPrecio(TipoVehiculo.Auto, 100000);
            limpiezatapizados.AgregarPrecio(TipoVehiculo.Suv, 120000);
            limpiezatapizados.AgregarPrecio(TipoVehiculo.Pickup, 140000);
            servicios.Add(limpiezatapizados);
        }
        public void CrearTurno(DateTime fecha, Vehiculo vehiculo, Servicio servicio)
        {
            Turno turno = new Turno(fecha, vehiculo, servicio);
            turnos.Add(turno);

        }
        public void AgregarV(string marca,string modelo, TipoVehiculo tipo, Cliente cliente)
        {
            cliente.AgregarVehiculo(marca, modelo, tipo);
            
        }
        public List<Vehiculo> MostrarListaVehiculos(Cliente cliente)
        {
            return cliente.MostrarVehiculos();
        }
        public List<Servicio> ObtenerServicios()
        {
            return servicios;
        }
        public List<Turno> ObtenerTurnos()
        {
            return turnos;
        }
        public void CrearClientes(string nombre,int dni)
        {
            Cliente cliente = new Cliente(nombre, dni);
            clientes.Add(cliente);
        }
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

    }
}
