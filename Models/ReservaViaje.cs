using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoTravelCan.Models
{
    public class ReservaViaje
    {
       
        
        [Key,Column(Order =0)]
        public int IdCliente { get; set; }
        [Key,Column(Order =1)]
        public int IdViaje { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        public ReservaViaje (){
                DateTime Fecha = DateTime.Now;

        }
        

    }
    
   
}