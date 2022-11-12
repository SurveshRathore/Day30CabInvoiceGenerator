using Day30CabInvoiceGenerator;

namespace CabInvoiceTest
{
    public class Tests
    {
        UC1CalculateFare calcTotalFare;

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            double distance = 2.0;
            int time = 5;
            calcTotalFare = new(distance, time);
            double fare = calcTotalFare.calcFair();
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [Test]
        public void GivenDistanceAndTimeShouldReturnMinimumFare()
        {
            double distance = 0;
            int time = 0;
            calcTotalFare = new(distance, time);
            double fare = calcTotalFare.calcFair();
            double expected = 5;
            Assert.AreEqual(expected, fare);
        }
    }
}