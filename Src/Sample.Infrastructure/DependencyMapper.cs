using System.ServiceModel;
using Autofac;
using Sample.Model.Models;
using Sample.Model.Models.Mapping;
using Sample.Repository;
using Sample.Repository.Interfaces;
using Sample.Services.DataContract;

namespace Sample.Infrastructure
{
    public class DependencyMapper
    {
        public ContainerBuilder Register(ContainerBuilder builder)
        {
            builder.Register(
                c =>
                new ChannelFactory<Sample.Services.DataContract.IEmployee>("EmployeeServiceEndPoint").CreateChannel()).
                As<Sample.Services.DataContract.IEmployee>().InstancePerDependency();

            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>().SingleInstance();
            builder.RegisterType<SAMPLEDBContext>().As<IDbContext>();
            return builder;
        }
    }
}