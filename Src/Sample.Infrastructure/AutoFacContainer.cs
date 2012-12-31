using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace Sample.Infrastructure
{
    public class AutoFacContainer
    {
        public static IContainer Container;
        private static DependencyMapper _dependencyMapper = new DependencyMapper();

        static AutoFacContainer()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder = RegisterDependencies(containerBuilder);
            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());
            Container = containerBuilder.Build();
        }
        public static ContainerBuilder RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder = _dependencyMapper.Register(containerBuilder);
            return containerBuilder;
        }

        public static T Resolve<T>()
        {
            var resolve = Container.Resolve<T>();
            return resolve;
        }
    }
}
