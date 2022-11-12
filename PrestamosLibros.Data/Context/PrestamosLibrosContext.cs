using System;
using Microsoft.EntityFrameworkCore;
using PrestamosLibros.Data.Entities;

namespace PrestamosLibros.Data.Context
{
    public partial class PrestamosLibrosContext : DbContext
    {
        public PrestamosLibrosContext()
        {
        }
        public PrestamosLibrosContext(DbContextOptions<PrestamosLibrosContext> options) : base(options)
        {

        }
        #region "Entities"
        public DbSet<Alquileres> Alquileres { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        #endregion
    }
}
