
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repository;
using DataLayer.UnitOfWork.Interfaces;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationContext Context { get; }

        public GenericRepository<ShoppingCart> ShoppingCartRepository { get; }
        public GenericRepository<Product> ProductRepository { get; }

        public UnitOfWork(ApplicationContext context)
        {
            Context = context;
            this.ShoppingCartRepository = new GenericRepository<ShoppingCart>(Context);
            this.ProductRepository = new GenericRepository<Product>(Context);
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
