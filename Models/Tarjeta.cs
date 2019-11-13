using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class Tarjeta
    {
        public int Id { get; set; }
        [Required]
        public int NumeroTarjeta { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Año { get; set; }
        [Required]
        public string NombreEnTarjeta { get; set; }
    }
}