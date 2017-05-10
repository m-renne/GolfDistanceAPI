using GolfDistanceAPI.ServiceModels.Rounds;
using System.Collections.Generic;

namespace GolfDistanceAPI.Application.Interfaces.Services
{
    public interface IRoundService
    {
        Round Get(int roundId);
        List<Round> Get();
        Round Put(Round round);
        Round Post(Round round);
        void Delete(int roundId);
    }
}
