using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity :class
        
    {
        Context context = new Context();
        DbSet<TEntity> _object;

        public GenericRepository()
        {
            _object = context.Set<TEntity>();
        }
        public void Delete(TEntity entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public void Insert(TEntity entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public List<TEntity> List()
        {
            return _object.ToList();
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            context.SaveChanges();
        }
    }
}
