using System.Collections.Generic;

namespace ProyectoTravelCan.Models
{
    public class RegistroVistaModelo
    {
        public List<Cliente> Clientes {get;set;}
        public List<Viaje> Viajes {get;set;}
        public List<ReservaViaje> Reservas {get;set;}
    }
}