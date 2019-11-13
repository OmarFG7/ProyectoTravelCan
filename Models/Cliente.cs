using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
            public Cliente (){
                DateTime FechaNacimiento = DateTime.Now;

            }

        [Required]
        public string Celular { get; set; }

        [Required]
        public string  Correo { get; set; }
        public Perro perro{get;set;}

        public int? PerroId {get;set;}


    }
}