using Autofac;
using DataLayer.Repository;
using DataLayer.Repository.Interfaces;
using DataLayer.UnitOfWork;
using DataLayer.UnitOfWork.Interfaces;

namespace Infrastructure.IoC
{
    public class IoCBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
        }
    }
}
