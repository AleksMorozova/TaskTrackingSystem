using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Services.Contracts;
using Services.Implementation;

namespace Server
{
    public class AutofacBootstrap
    {
        public static IContainer RegisterAutoFac()
        {
            // Create the container builder.
            var builder = new ContainerBuilder();

            // Register the Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register other dependencies.
            builder.Register(c => new IssueImplementation()).As<IIssueContract>().InstancePerApiRequest();

            // Build the container.
            var container = builder.Build();

            // Create the depenedency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            return container;
        }
    }
}