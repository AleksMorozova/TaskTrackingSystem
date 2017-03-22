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

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType(typeof(EFRepository<User>)).As(typeof(IRepository<User>));
            builder.RegisterType(typeof(EFRepository<Issue>)).As(typeof(IRepository<Issue>));

            _container = builder.Build();
        }
    }
}
