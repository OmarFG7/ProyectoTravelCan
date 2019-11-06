using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan_1.Models
{
    public class Cliente
    {
        public int DniId { get; set; }

        [Required]
        public string nombresCliente { get; set; }

        [Required]
        public string apellidosCliente { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
            public Cliente (){
                DateTime FechaNacimiento = DateTime.Now;

            }

        public string Telefono { get; set; }

        [Required]
        public string Celular { get; set; }

        [Required]
        public string  Correo { get; set; }




    }
}