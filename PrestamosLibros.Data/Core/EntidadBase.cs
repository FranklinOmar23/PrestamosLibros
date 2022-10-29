using System;

namespace PrestamosLibros.Data.Core
{
    public class EntidadBase
    {
        public int Creation_User { get; set; }
        public DateTime Creation_Date { get; set; }
        public int? Modify_User { get; set; }
        public DateTime Modify_Date { get; set; }
        public int? Delete_User { get; set; }
        public DateTime? Delete_Date { get; set; }
        public bool Deleted { get; set; }
        public EntidadBase()
        {
            this.Creation_Date = DateTime.Now;
            this.Deleted = false;
        }
    }
}
