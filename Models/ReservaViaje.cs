using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class ReservaViaje
    {
        public Cliente Cliente { get; set; }
        public Viaje Viaje { get; set; }
        public int IdCliente { get; set; }
        public int IdViaje { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        public ReservaViaje (){
                DateTime Fecha = DateTime.Now;

        }
        public List<Cliente> Clientes {get;set;}
        public List<Viaje> Viajes {get;set;}

    }
}