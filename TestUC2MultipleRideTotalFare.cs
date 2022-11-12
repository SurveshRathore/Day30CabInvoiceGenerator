using Day30CabInvoiceGenerator;
using System.IO;

namespace CabInvoiceTest
{
    public class TestUC2MultipleRideTotalFare
    {
        UC2MultipleRide calcTotalFare;

        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            calcTotalFare = new();
            UC2Ride[] rides = { new UC2Ride(2.0, 5), new UC2Ride(0.1, 5) };
            double fare = calcTotalFare.calcFair(rides);
            double expected = 31;
            Assert.AreEqual(fare, expected);
        }
        //[Test]
        //public void GivenDistanceAndTimeShouldReturnMinimumFare()
        //{
        //    double distance = 0;
        //    int time = 0;
        //    calcTotalFare = new(distance, time);
        //    double fare = calcTotalFare.calcFair();
        //    double expected = 5;
        //    Assert.AreEqual(expected, fare);
        //}
    }
}