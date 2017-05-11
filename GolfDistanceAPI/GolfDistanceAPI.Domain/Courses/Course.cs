using GolfDistanceAPI.Domain.GeoCoordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Domain.Courses
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public GeoCoordinate Location { get; set; }

        public GeoCoordinate TeeBox { get; set; }

        public GeoCoordinate Green { get; set; }
    }
}
