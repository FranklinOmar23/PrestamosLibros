using System;

namespace PrestamosLibros.Web.Models
{
    public class Alquileres
    {
        public int ID_Alquileres { get; set; }
        public int ID_Lector { get; set; }
        public int ID_Libro { get; set; }
        public DateTime? Fecha_Salidad { get; set; }
        public DateTime? Fecha_Entrada { get; set; }
    }
}
