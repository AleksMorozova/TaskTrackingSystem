using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Server.Services.Implementation;
using Services.Implementation;

namespace Server
{
    public class AutofacBootstrap
    {
        public static IContainer RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType(typeof(TaskService)).AsImplementedInterfaces();
            builder.RegisterType(typeof(UserService)).AsImplementedInterfaces();
            builder.RegisterType(typeof(ProjectService)).AsImplementedInterfaces();
            builder.RegisterType(typeof(ProjectImplementation)).AsImplementedInterfaces();
            builder.RegisterType(typeof(IssueImplementation)).AsImplementedInterfaces();
            builder.RegisterType(typeof(UserImplementation)).AsImplementedInterfaces();
            var container = builder.Build();

            // Create the depenedency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            return container;
        }
    }
}