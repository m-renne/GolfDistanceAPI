using GolfDistanceAPI.Models.RoundModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Repositories
{
    public interface IRoundRepository
    {
        Round Get(int roundId);
        List<Round> Get();
        void Put(Round round);
        int Post(Round round);
        void Delete(int roundId);
    }
}
