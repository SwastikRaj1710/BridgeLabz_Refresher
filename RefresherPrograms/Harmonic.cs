using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class Harmonic
    {
        public float NthHarmonic(int n)
        {
            float harmonicSum = 0;
            for(int i=1;i<=n;i++)
            {
                harmonicSum+= (float)1/i;
            }
            return harmonicSum;
        }
    }
}
