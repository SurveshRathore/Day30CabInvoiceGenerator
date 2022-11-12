using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30CabInvoiceGenerator
{
    public class UC1CalculateFare
    {
        double distance;
        int time;

        UC1CalculateFare() { }
        public UC1CalculateFare(double dis, int t)
        {
            this.distance = dis;
            this.time = t;
        }
        public double calcFair()
        {
            double minFare = 5;
            double kmCost = 10;
            double minCost = 1;

            double fairCost = kmCost * distance + minCost * time;
            return Math.Max(minFare, fairCost);
        }
    }
}
