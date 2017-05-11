using System;
using System.Collections.Generic;

namespace EFRepository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(Guid id);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
    }
}
