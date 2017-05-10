using GolfDistanceAPI.ServiceModels.Swings;

namespace GolfDistanceAPI.Application.Interfaces.Services
{
    public interface ISwingService
    {
        Swing Get(int roundId, int swingId);
        Swing Put(int roundId, Swing swing);
        Swing Post(int roundId, Swing swing);
        void Delete(int roundId, int swingId);
    }
}
