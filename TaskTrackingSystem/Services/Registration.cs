using Autofac;
using DomainModel;
using EFRepository;

namespace Services
{
    public static class Registration
    {
        private static IContainer _container;

        static Registration()
        {
            Registrate();
        }

        public static IRepository<User> UserRepository => _container.Resolve<IRepository<User>>();

        public static IRepository<Issue> IssueRepository => _container.Resolve<IRepository<Issue>>();

        public static IRepository<Project> ProjectRepository => _container.Resolve<IRepository<Project>>();
        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType(typeof(EFRepository<User>)).As(typeof(IRepository<User>));
            builder.RegisterType(typeof(EFRepository<Issue>)).As(typeof(IRepository<Issue>));
            builder.RegisterType(typeof(EFRepository<Project>)).As(typeof(IRepository<Project>));
            _container = builder.Build();
        }
    }
}
