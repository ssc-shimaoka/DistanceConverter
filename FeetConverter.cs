using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public static class FeetConverter
    {

        // [定数]倍率
        private static readonly double RATIO = 0.3048;

        // m -> ft
        public static double FromMeter(double meter)
        {
            return meter / RATIO;
        }

        // ft -> m
        public static double ToMeter(double feet)
        {
            return feet * RATIO;
        }

    }
}
