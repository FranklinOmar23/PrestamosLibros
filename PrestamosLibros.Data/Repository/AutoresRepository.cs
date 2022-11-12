using PrestamosLibros.Data.Entities;
using PrestamosLibros.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using PrestamosLibros.Data.Context;
using PrestamosLibros.Data.Core;
using Microsoft.EntityFrameworkCore.Internal;
using Autores = PrestamosLibros.Data.Entities.Autores;

namespace PrestamosLibros.Data.Repository
{
    public class AutoresRepository : IAutoresRepository
    {
        private readonly PrestamosLibrosContext context;
        private readonly ILogger <AutoresRepository> logger;
        public AutoresRepository(PrestamosLibrosContext context,
                                 ILogger<AutoresRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(Expression<Func<Autores, bool>> filter)
        {
            return context.Autores.Any(filter);
        }

        public IEnumerable<Autores> GetEntities()
        {
            return (IEnumerable<Autores>)(IEnumerable<Core.Autores>)context.Autores.OrderByDescending(st => st.Creation_Date);
        }
        public Autores GetEntity(int studentId)
        {
            return context.Autores.Find(studentId);
        }
        public void Remove(Autores autores)
        {
            throw new NotImplementedException();
        }

        public void Save(Autores autores)
        {
            context.Autores.Add(autores);
            context.SaveChanges();
        }
        public void Update(Autores autores)
        {
            try
            {
                Autores autoresToModify = GetEntity(autores.ID);

                autoresToModify.Name = autores.Name;
                autoresToModify.LastName = autores.LastName;
                autoresToModify.ModifyDate = autores.ModifyDate;
                autoresToModify.UserMod = autores.UserMod;
                autoresToModify.ID = autores.ID;

                context.Autores.Update(autoresToModify);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
    }
}
