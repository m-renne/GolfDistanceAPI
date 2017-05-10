using GolfDistanceAPI.Domain.Rounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Infrastructure.Interfaces.Repositories
{
    public interface IRoundsRepository
    {
        Round Get(int roundId);
        List<Round> Get();
        void Put(Round round);
        int Post(Round round);
        void Delete(int roundId);
    }
}
