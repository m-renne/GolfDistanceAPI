
namespace GolfDistanceAPI.ServiceModels.Rounds
{
    public class Round
    {
        public int Id { get; internal set; }

        public string CourseName { get; internal set; }

        public double Longitude { get; internal set; }

        public double Latitude { get; internal set; }
    }
}