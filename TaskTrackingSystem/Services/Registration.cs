using Autofac;
using EFRepository;
using EFRepository.DBModel;

namespace Services
{
    public static class Registration
    {
        private static IContainer _container;

        static Registration()
        {
            Registrate();
        }

        public static IRepository<UserDB> UserRepository => _container.Resolve<IRepository<UserDB>>();

        public static IRepository<IssueDB> IssueRepository => _container.Resolve<IRepository<IssueDB>>();

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType(typeof(EFRepository<UserDB>)).As(typeof(IRepository<UserDB>));
            builder.RegisterType(typeof(EFRepository<IssueDB>)).As(typeof(IRepository<IssueDB>));

            _container = builder.Build();
        }
    }
}
