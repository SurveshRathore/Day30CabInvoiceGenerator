using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30CabInvoiceGenerator
{
    //get a list of rides and return total rides and total fare
    public class UC2MultipleRide
    {
        
        public double calcFair(double distance, int time)
        {
            double minFare = 5;
            double kmCost = 10;
            double minCost = 1;

            double fairCost = kmCost * distance + minCost * time;
            return Math.Max(minFare, fairCost);
        }
        //UC2Ride class to store the distance and time
        public double calcFair(UC2Ride[] totalRides)
        {
            double totalFare = 0;
            //object of the UC2Ride class is numberOfRides
            foreach (UC2Ride numberOfRides in totalRides)
            {
                totalFare += this.calcFair(numberOfRides.distance, numberOfRides.time);

            }
            return totalFare;
        }
    }
}
