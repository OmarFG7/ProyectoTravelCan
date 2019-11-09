using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class Viaje
    {
        public int Id { get; set; }
        [Required]
        public string Foto  { get; set; }
        [Required]
        public string Descripcion  { get; set; }
        [Required]
        public string nombrePartida { get; set; }
        [Required]
        public string nombreDestino { get; set; }
        [Required]
        public float Costo { get; set; }
    }
}