using AutoMapper;
using FootballDataWrapper.Business.DTO;
using FootballDataWrapper.Data.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CompetitionDTO, Competition>()
                .ForMember(d => d.CompetitionId, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Id, o => o.MapFrom(c => 0) );
            CreateMap<TeamDTO, Team>()
                .ForMember(d => d.TeamId, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Id, o => o.MapFrom(c => 0));
            CreateMap<PlayerDTO, Player>()
                .ForMember(d => d.PlayerId, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Id, o => o.MapFrom(c => 0));
        }
    }

    public class ObjectMapper
    {
        public static IMapper Mapper
        {
            get { return mapper.Value; }
        }

        public static IConfigurationProvider Configuration
        {
            get { return config.Value; }
        }

        public static Lazy<IMapper> mapper = new Lazy<IMapper>(() =>
        {
            var mapper = new Mapper(Configuration);
            return mapper;
        });

        public static Lazy<IConfigurationProvider> config = new Lazy<IConfigurationProvider>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            return config;
        });
    }
}
