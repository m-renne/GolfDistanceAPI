using AutoMapper;

namespace GolfDistanceAPI.Application.Mappers.Clubs.Enums
{
    public class ClubTypeMapper : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<Domain.Clubs.Enums.ClubType, ServiceModels.Clubs.Enums.ClubType>();
            this.CreateMap<ServiceModels.Clubs.Enums.ClubType, Domain.Clubs.Enums.ClubType>();
        }
    }
}
