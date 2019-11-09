using System;

namespace ProyectoTravelCan.Models
{
    public class ReservaViaje
    {
        public int ReservaId { get; set; }

        public string nombrePartida { get; set; }

        public string nombreDestino { get; set; }

        public int CantidadBoletos { get; set; }

        public string TipoServicio { get; set; }

        public float Costo { get; set; }

        public DateTime fecha { get; set; }


    }
}