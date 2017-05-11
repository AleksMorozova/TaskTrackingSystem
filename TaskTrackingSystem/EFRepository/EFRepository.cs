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
            ent.IsActive = false;
            Update(ent);
        }

        public virtual void Update(T entity)
        {
            var updated = Read(entity.Id);
            DbContext.Entry(updated).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}