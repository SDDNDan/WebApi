using System;
using System.Collections.Generic;

namespace BusinessLayer.Services.Interfaces
{
    public interface IGenericServices<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        T GetById(Guid id);

        IEnumerable<T> GetAll();
    }
}
