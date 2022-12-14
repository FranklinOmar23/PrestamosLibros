using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace PrestamosLibros.Data.Core
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> entities;
        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = this.dbContext.Set<TEntity>();
        }
        public virtual bool Exists(Expression<Func<TEntity, bool>> filter) => this.entities.Any(filter);
        public virtual IEnumerable<TEntity> GetEntities() => this.entities;
        public virtual TEntity GetEntity(int entityid) => this.entities.Find(entityid);
        public virtual void Remove(TEntity entity) => this.entities.Remove(entity);
        public virtual void Save(TEntity entity)
        {
            this.entities.Add(entity);
            this.dbContext.SaveChanges();
        }
        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);
            this.dbContext.SaveChanges();
        }
    }
}
