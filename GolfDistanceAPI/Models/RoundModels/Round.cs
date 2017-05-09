using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfDistanceAPI.Models.RoundModels
{
    public class Round
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}