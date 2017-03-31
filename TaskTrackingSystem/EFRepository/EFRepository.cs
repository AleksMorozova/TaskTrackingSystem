using DomainModel;
using System;
using System.Collections.Generic;

namespace EFRepository
{
    public class EFRepository<T> : IRepository<T> where T : Entity, new()
    {
        public ProjectDBContext DbContext;

        public EFRepository()
        {
            DbContext = new ProjectDBContext();
        }

        public virtual void Create(T entity)
        {
            DbContext.Set<T>().Add(entity);
            DbContext.SaveChanges();
        }

        public virtual T Read(Guid id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return DbContext.Set<T>();
        }

        public void Remove(Guid id)
        {
            var ent = Read(id);
            Remove(ent);
            DbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            DbContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            DbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}