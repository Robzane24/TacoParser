using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    public static class DataConversion
    {
        public static double ConvertMetersToMiles(double meters)
        {
            return (meters / 1609.344);
        }
    }
}
