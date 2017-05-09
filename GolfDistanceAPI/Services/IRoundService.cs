using GolfDistanceAPI.Models.RoundModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Services
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
