using System;
using System.Collections.Generic;

namespace DataLayer.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        T GetById(Guid id);

        IEnumerable<T> GetAll();
    }
}
