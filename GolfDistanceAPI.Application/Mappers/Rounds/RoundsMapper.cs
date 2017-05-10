using AutoMapper;

namespace GolfDistanceAPI.Application.Mappers.Rounds
{
    public class RoundsMapper : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<Domain.Rounds.Round, ServiceModels.Rounds.Round>();
            this.CreateMap<ServiceModels.Rounds.Round, Domain.Rounds.Round>();
        }
    }
}
