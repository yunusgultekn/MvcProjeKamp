using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<TEntity>
    {
        List<TEntity> List();
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

        List<TEntity> List(Expression<Func<TEntity, bool>> filter);
    }
}
