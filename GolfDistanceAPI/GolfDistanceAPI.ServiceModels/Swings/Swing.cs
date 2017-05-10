using GolfDistanceAPI.ServiceModels.Clubs.Enums;

namespace GolfDistanceAPI.ServiceModels.Swings
{
    public class Swing
    {
        public int Id { get; internal set; }
        public ClubType Club { get; internal set; }

        public double Longitude { get; internal set; }

        public double Latitude { get; internal set; }

        public bool IsTeed { get; internal set; }
    }
}