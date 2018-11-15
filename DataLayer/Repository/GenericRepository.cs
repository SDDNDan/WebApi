using DataLayer.Context;
using DataLayer.Repository.Interfaces;
using DataLayer.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext applicationContext;

        public GenericRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext ?? throw new ArgumentException();
        }

        public void Add(T entity)
        {
            applicationContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T existing = applicationContext.Set<T>().Find(entity);
            if (existing != null) applicationContext.Set<T>().Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return applicationContext.Set<T>().AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return applicationContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            applicationContext.Entry(entity).State = EntityState.Modified;
            applicationContext.Set<T>().Attach(entity);
        }
    }
}
