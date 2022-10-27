using System.Reflection;
using Autofac;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;
using Project.Repository.Context;
using Project.Repository.Repositories;
using Project.Repository.UnitOfWork;
using Project.Service.Mapping;
using Project.Service.Services;
using Module = Autofac.Module;

namespace Project.WebUI.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            Assembly webAssembly = Assembly.GetExecutingAssembly();
            Assembly repoAssembly = Assembly.GetAssembly(typeof(YurtDbContext));
            Assembly serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));



            builder.RegisterAssemblyTypes(webAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(webAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();





        }
    }
}
