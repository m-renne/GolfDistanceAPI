using AutoMapper;
using GolfDistanceAPI.Application.Mappers.Clubs.Enums;
using GolfDistanceAPI.Application.Mappers.Rounds;
using GolfDistanceAPI.Application.Mappers.Swings;

namespace GolfDistanceAPI.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure(IMapperConfiguration configuration)
        {
            configuration.AddProfile<SwingsMapper>();
            configuration.AddProfile<RoundsMapper>();
            configuration.AddProfile<ClubTypeMapper>();
        }
    }
}