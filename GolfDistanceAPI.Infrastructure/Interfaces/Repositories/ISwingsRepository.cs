using GolfDistanceAPI.Domain.Swings;

namespace GolfDistanceAPI.Infrastructure.Interfaces.Repositories
{
    public interface ISwingsRepository
    {
        Swing Get(int roundId, int swingId);
        void Put(int roundId, Swing swing);
        int Post(int roundId, Swing swing);
        void Delete(int roundId, int swingId);

    }
}
