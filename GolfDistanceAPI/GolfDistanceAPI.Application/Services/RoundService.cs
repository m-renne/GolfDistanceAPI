using AutoMapper;
using GolfDistanceAPI.Application.Interfaces.Services;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using GolfDistanceAPI.Infrastructure.Interfaces.Repositories;
using GolfDistanceAPI.ServiceModels.Rounds;
using System.Collections.Generic;
using System.Linq;

namespace GolfDistanceAPI.Application.Services
{
    public class RoundService : IRoundService
    {
        private IBaseFactory RepositoryFactory { get; set; }

        private IMapper Mapper;

        public RoundService(IBaseFactory repositoryFactory, IMapper mapper)
        {
            RepositoryFactory = repositoryFactory;
            Mapper = mapper;
        }

        public Round Get(int roundId)
        {
            IRoundsRepository repository = this.RepositoryFactory.Create<IRoundsRepository>();

            var domainRound = repository.Get(roundId);

            return Mapper.Map<Round>(domainRound);
        }

        public List<Round> Get()
        {
            IRoundsRepository repository = this.RepositoryFactory.Create<IRoundsRepository>();

            var domainRounds = repository.Get();

            return domainRounds.Select(i => Mapper.Map<Round>(i)).ToList();
        }


        public Round Put(Round round)
        {
            IRoundsRepository repository = this.RepositoryFactory.Create<IRoundsRepository>();

            Domain.Rounds.Round roundDomain = Mapper.Map<Domain.Rounds.Round>(round);

            repository.Put(roundDomain);

            Round updatedRound = Get(round.Id);

            return updatedRound;
        }

        public Round Post(Round round)
        {
            IRoundsRepository repository = this.RepositoryFactory.Create<IRoundsRepository>();

            Domain.Rounds.Round roundDomain = Mapper.Map<Domain.Rounds.Round>(round);

            var roundId = repository.Post(roundDomain);

            Round savedRound = Get(roundId);

            return savedRound;
        }
        public void Delete(int roundId)
        {
            IRoundsRepository repository = this.RepositoryFactory.Create<IRoundsRepository>();

            repository.Delete(roundId);
        }
    }
}