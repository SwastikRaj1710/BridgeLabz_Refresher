using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class EuclideanDist
    {
        public double CalculateEuclidean(double x, double y)
        {
            double dist = Math.Pow((x * x + y * y),0.5);
            return dist;
        }
    }
}
