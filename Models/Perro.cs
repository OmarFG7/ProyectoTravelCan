using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class Perro
    {
        public int MascotaId { get; set; }
        
        [Required]
        public string nombreMascota { get; set; }

        [Required]
        public string Raza { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public int Edad { get; set; }

        public string Foto { get; set; }

        public string Descripcion { get; set; }   

        public string CartillaSanitaria  { get; set; }     
    }

    
}