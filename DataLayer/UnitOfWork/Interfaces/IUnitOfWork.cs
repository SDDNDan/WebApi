using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repository;
using System;

namespace DataLayer.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }

        GenericRepository<ShoppingCart> ShoppingCartRepository { get; }

        GenericRepository<Product> ProductRepository { get; }

        void Commit();
    }
}
