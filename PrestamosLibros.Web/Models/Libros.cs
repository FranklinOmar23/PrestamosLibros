using System;

namespace PrestamosLibros.Web.Models
{
    public class Libros
    {
        public int ASIN { get; set; }

        public string Titulo { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int ID_Autor { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Editorial { get; set; }
        public string Idioma  { get; set; }
        public string Descripcion { get; set; }
    }
}