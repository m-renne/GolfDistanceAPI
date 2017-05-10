using AutoMapper;
using GolfDistanceAPI.Application.Interfaces.Services;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using GolfDistanceAPI.Infrastructure.Interfaces.Repositories;
using GolfDistanceAPI.ServiceModels.Swings;

namespace GolfDistanceAPI.Application.Services
{
    public class SwingService : ISwingService
    {
        private IBaseFactory RepositoryFactory { get; set; }

        private IMapper Mapper;

        public SwingService(IBaseFactory repositoryFactory, IMapper mapper)
        {
            RepositoryFactory = repositoryFactory;
            Mapper = mapper;
        }

        public Swing Get(int roundId, int swingId)
        {
            ISwingsRepository repository = this.RepositoryFactory.Create<ISwingsRepository>();

            Domain.Swings.Swing domainSwing = repository.Get(roundId, swingId);

            return Mapper.Map<Swing>(domainSwing);
        }

        public Swing Put(int roundId, Swing swing)
        {
            ISwingsRepository repository = this.RepositoryFactory.Create<ISwingsRepository>();

            Domain.Swings.Swing domainSwing = Mapper.Map<Domain.Swings.Swing>(swing);

            repository.Put(roundId, domainSwing);

            Swing updateSwing = Get(roundId, swing.Id);

            return updateSwing;
        }

        public Swing Post(int roundId, Swing swing)
        {
            ISwingsRepository repository = this.RepositoryFactory.Create<ISwingsRepository>();

            Domain.Swings.Swing domainSwing = Mapper.Map<Domain.Swings.Swing>(swing);

            var swingId = repository.Post(roundId, domainSwing);

            Swing updateSwing = Get(roundId, swingId);

            return updateSwing;
        }

        public void Delete(int roundId, int swingId)
        {
            ISwingsRepository repository = this.RepositoryFactory.Create<ISwingsRepository>();

            repository.Delete(roundId, swingId);
        }
    }
}