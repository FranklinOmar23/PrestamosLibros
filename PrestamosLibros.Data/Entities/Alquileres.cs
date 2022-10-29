using System;

namespace PrestamosLibros.Data.Entities
{
    internal class Alquileres : Core.EntidadBase
    {
        public int ID_Alquileres { get; set; }
        public int ID_Lector { get; set; } 
        public string ID_Libro { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Entrada { get; set; }
    }
}
