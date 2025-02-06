﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After.Model
{
    public class Route
    {
        public string Title { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public TimeSpan Duration { get; set; }
        public int DistanceInKM { get; set; }

        public RoutePreference RoutePreference { get; set; }
        public List<string> Directions { get; set; }

        public override string ToString()
        {
            string formattedDuration = $"{Duration.Hours} hr {Duration.Minutes} min";
            string formattedDistance = $"{DistanceInKM} km";

            var result = $"'{RoutePreference}' route [{Origin} → {Destination}]";

            result = $"{Title}\t [{formattedDuration}] ({formattedDistance})\n";
            foreach (var direction in Directions)
            {
                result += $"   ├ {direction}\n";
            }

            return result;
        }
    }
}
