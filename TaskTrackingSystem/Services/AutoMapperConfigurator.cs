using AutoMapper;
using DomainModel;
using EFRepository.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(MapperConfig);
        }

        private static void MapperConfig(IMapperConfigurationExpression config)
        {
            UserConfigurator(config);
            ProjectConfigurator(config);
            IssueConfigurator(config);
            CategoryConfigurator(config);
            HistoryConfigurator(config);
            RoleConfigurator(config);
            PermissionConfigurator(config);
        }

        private static void UserConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserDB>().PreserveReferences();
            config.CreateMap<UserDB, User>().PreserveReferences();
        }
        private static void ProjectConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<Project, ProjectDB>().PreserveReferences();
            config.CreateMap<ProjectDB, Project>().PreserveReferences();
        }
        private static void IssueConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<Issue, IssueDB>().PreserveReferences();
            config.CreateMap<IssueDB, Issue>().PreserveReferences();
        }
        private static void CategoryConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<Category, CategoryDB>().PreserveReferences();
            config.CreateMap<CategoryDB, Category>().PreserveReferences();
        }
        private static void HistoryConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<History, HistoryDB>().PreserveReferences();
            config.CreateMap<HistoryDB, History>().PreserveReferences();
        }
        private static void RoleConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<Role, RoleDB>().PreserveReferences();
            config.CreateMap<RoleDB, Role>().PreserveReferences();
        }
        private static void PermissionConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<Permission, PermissionDB>().PreserveReferences();
            config.CreateMap<PermissionDB, Permission>().PreserveReferences();
        }
    }
}
