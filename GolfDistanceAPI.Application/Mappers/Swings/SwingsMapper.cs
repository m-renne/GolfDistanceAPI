using AutoMapper;

namespace GolfDistanceAPI.Application.Mappers.Swings
{
    public class SwingsMapper : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<Domain.Swings.Swing, ServiceModels.Swings.Swing>();
            this.CreateMap<ServiceModels.Swings.Swing, Domain.Swings.Swing>();
        }
    }
}
