using PrestamosLibros.Data.Context;
using PrestamosLibros.Data.Core;
using PrestamosLibros.Data.Entities;
using PrestamosLibros.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrestamosLibros.Data.Repository
{
    public class CategoriasRepository : RepositoryBase<Categorias>, ICaegoriasRepository
    {
        private readonly PrestamosLibrosContext context;
        public CategoriasRepository(PrestamosLibrosContext context) : base(context) => this.context = context;


        public Categorias GetAlquileres(int ID_Categorias)
        {
            throw new NotImplementedException();
        }
        public override IEnumerable<Categorias> GetEntities() => context.Categorias.Where(dep => !dep.Deleted);

        public void Remove(Categorias categorias)
        {
            throw new NotImplementedException();
        }

        public void Save(Categorias categorias)
        {
            throw new NotImplementedException();
        }

        public void Update(Categorias categorias)
        {
            throw new NotImplementedException();
        }
    }
}
