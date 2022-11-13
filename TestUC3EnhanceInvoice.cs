using Day30CabInvoiceGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceTest
{
    internal class TestUC3EnhanceInvoice
    {
        UC3RideEnhancedInvoice generateInvoice;

        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            generateInvoice = new();
             UC2Ride[] rides = { new UC2Ride(2.0, 5), new UC2Ride(0.1, 5) };
            InvoiceSummary summary = generateInvoice.calcFair(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 31.0);
            //Assert.AreEqual(expectedSummary.GetType(), summary.GetType());
            Assert.AreEqual(summary, expectedSummary);
        }
    }
}
