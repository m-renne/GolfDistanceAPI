using GolfDistanceAPI.Domain.Swings;
using GolfDistanceAPI.Infrastructure.Interfaces.Repositories;

namespace GolfDistanceAPI.Infrastructure.Repositories
{
    public class SwingsRepository : ISwingsRepository
    {
        public Swing Get(int roundId, int swingId)
        {
            return new Swing();
        }

        public void Put(int roundId, Swing swing)
        {

        }

        public int Post(int roundId, Swing swing)
        {
            return 1;
        }

        public void Delete(int roundId, int swingId)
        {

        }
    }
}