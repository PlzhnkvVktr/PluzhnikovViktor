using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public static class Circle
    {
        public static double GetLengthOfCircle(double radius)
        {
            return Math.Round(radius * Math.PI * 2, 2);
        }
    }
}
