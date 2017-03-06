using Autofac;
using EFRepository;
using EFRepository.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Registration
    {
        static IContainer container;

        static Registration()
        {
            Registrate();
        }

        public static IRepository<UserDB> UserRepository
        {
            get
            {
                return container.Resolve<IRepository<UserDB>>();
            }
        }
        public static IRepository<IssueDB> IssueRepository
        {
            get
            {
                return container.Resolve<IRepository<IssueDB>>();
            }
        }

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType(typeof(EFRepository<UserDB>)).As(typeof(IRepository<UserDB>));
            builder.RegisterType(typeof(EFRepository<IssueDB>)).As(typeof(IRepository<IssueDB>));

            container = builder.Build();
        }
    }
}
