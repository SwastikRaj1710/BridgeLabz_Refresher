using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Invoice
    {
        public int TotalFare(List<Ride> ride)
        {
            int totalFare = 5;
            for(int i=0;i<ride.Count;i++)
            {
                totalFare += 10 * ride[i].km + ride[i].minute;
            }
            return totalFare;
        }

        public int TotalNoOfRides(List<Ride> ride)
        {
            return ride.Count;
        }

        public double AverageFarePerRide(List<Ride> ride)
        {
            double averagePerRide = (double)TotalFare(ride) / TotalNoOfRides(ride);
            return averagePerRide;
        }

        public List<Ride> GetAllRides(int id, Dictionary<int,List<Ride>> dict)
        {
            return dict.GetValueOrDefault(id);
        }


    }
}
