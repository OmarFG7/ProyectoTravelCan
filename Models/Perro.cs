using System.ComponentModel.DataAnnotations;

namespace ProyectoTravelCan.Models
{
    public class Perro
    {
        public int Id { get; set; }
        
        [Required]
        public string NombreMascota { get; set; }

        [Required]
        public string Raza { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public int Edad { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public string Descripcion { get; set; }   
        [Required]
        public string CartillaSanitaria { get; set; }
   
    }

    
}