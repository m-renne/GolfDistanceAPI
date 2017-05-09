using GolfDistanceAPI.Models.RoundModels;
using GolfDistanceAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfDistanceAPI.Services
{
    public class RoundService : IRoundService
    {
        public IRoundRepository Repository { get; set; }

        public RoundService(IRoundRepository repository)
        {
            Repository = repository;
        }

        public Round Get(int roundId)
        {
            var round = Repository.Get(roundId);

            return round;
        }

        public List<Round> Get()
        {
            var rounds = Repository.Get();

            return rounds;
        }


        public Round Put(Round round)
        {
            Repository.Put(round);

            var updatedRound = Get(round.Id);

            return updatedRound;
        }

        public Round Post(Round round)
        {
            var roundId = Repository.Post(round);

            var savedRound = Get(roundId);

            return savedRound;
        }
        public void Delete(int roundId)
        {
            Repository.Delete(roundId);
        }
    }
}