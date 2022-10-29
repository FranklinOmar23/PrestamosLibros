using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosLibros.Data.Core
{
    public class Libros : EntidadBase
    {
        public int ASIN { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public int ID_Autor { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Editorial { get; set; }
        public string Idioma { get; set; }
        public string Descripcion { get; set; }
    }
}
