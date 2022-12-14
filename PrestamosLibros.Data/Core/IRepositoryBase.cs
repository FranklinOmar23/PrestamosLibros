using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PrestamosLibros.Data.Core
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetEntity(int entityid);
        bool Exists(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetEntities();
    }
}
