﻿using GolfDistanceAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfDistanceAPI.Models.SwingModels
{
    public class Swing
    {
        public int Id { get; set; }
        public ClubType Club { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public bool IsTeed { get; set; }
    }
}