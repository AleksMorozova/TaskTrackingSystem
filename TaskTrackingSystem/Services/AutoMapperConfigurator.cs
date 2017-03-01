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
        }

        private static void UserConfigurator(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserDB>();
            config.CreateMap<UserDB, User>();
        }
    }
}
