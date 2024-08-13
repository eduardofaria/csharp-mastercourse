using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CalculateData
    {
        public static double AddDoubles(double x, double y)
        {
            double output = x + y;
            return output;
        }
    }
}

// Usually you should not store data in static classes. This will be alocated in memory for the entery life of the application. Unless it is intentional.
