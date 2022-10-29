using PrestamosLibros.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosLibros.Data.Interfaces
{
    interface ICaegoriasRepository
    {
        void Save(Categorias categorias);
        void Update(Categorias categorias);
        void Remove(Categorias categorias);
        Categorias GetAlquileres(int ID_Categorias);
    }
}
