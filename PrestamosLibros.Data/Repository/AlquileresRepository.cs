using PrestamosLibros.Data.Entities;
using PrestamosLibros.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using PrestamosLibros.Data.Context;
using PrestamosLibros.Data.Core;

namespace PrestamosLibros.Data.Repository
{

    public class AlquileresRepository : IAlquileresRepository
    {
        private readonly PrestamosLibrosContext context;

        private readonly ILogger<LibrosRepository> logger;
        public AlquileresRepository(PrestamosLibrosContext context, ILogger<LibrosRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(int ID_Alquileres)
        {
            return context.Alquileres.Any(cd => cd.ID_Alquileres == ID_Alquileres);
        }
        public bool Exists(Expression<Func<Alquileres, bool>> filter)
        {
            return this.context.Alquileres.Any(filter);
        }

        public Alquileres GetAlquileres(int ID_Alquileres)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alquileres> GetEntities()
        {
            return context.Alquileres.OrderByDescending(st => st.Creation_Date);
        }
        public Alquileres GetEntity(int courseId)
        {
            return context.Alquileres.Find(courseId);
        }
        public void Remove(Alquileres course)
        {
            try
            {
                context.Alquileres.Remove(course);

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el curso {ex.Message}", ex.ToString());
            }
        }
        public void Save(Alquileres course)
        {
            context.Alquileres.Add(course);
            context.SaveChanges();
        }
        public void Update(Alquileres course)
        {
            throw new System.NotImplementedException();
        }
    }
    }
