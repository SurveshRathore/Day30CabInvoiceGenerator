using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30CabInvoiceGenerator
{
    //return total number of rides, total fare, average fare per ride
    public class UC3RideEnhancedInvoice
    {
        public double calcFair(double distance, int time)
        {
            double minFare = 5;
            double kmCost = 10;
            double minCost = 1;

            double fairCost = kmCost * distance + minCost * time;
            return Math.Max(minFare, fairCost);
        }
        //calculate the number of rides using the length of the array
        public InvoiceSummary calcFair(UC2Ride[] totalRides)
        {
            double totalFare = 0;
            int numberOfRide = 0;
            foreach (UC2Ride numberOfRides in totalRides)
            {
                totalFare += this.calcFair(numberOfRides.distance, numberOfRides.time);
                numberOfRide++;

            }
            return new InvoiceSummary(totalRides.Length, totalFare);
        }
    }
}
