using PrestamosLibros.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosLibros.Data.Interfaces
{
     interface IAlquileresRepository
    {
        void Save(Alquileres alquileres);
        void Update(Alquileres alquileres);
        void Remove(Alquileres alquileres);
        Alquileres GetAlquileres(int ID_Alquileres);
    }
}
