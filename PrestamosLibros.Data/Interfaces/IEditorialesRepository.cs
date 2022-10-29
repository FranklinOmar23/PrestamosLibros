using PrestamosLibros.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosLibros.Data.Interfaces
{
      interface IEditorialesRepository
    {
        void Save(Editoriales editoriales);
        void Update(Editoriales editoriales);
        void Remove(Editoriales editoriales);
        Editoriales GetAlquileres(int ID_Editoriales);
    }
}
