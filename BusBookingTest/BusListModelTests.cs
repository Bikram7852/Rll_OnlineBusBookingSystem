using NUnit.Framework;
using OnlineBusBookingSystem.Models;

namespace BusBookingTest
{
    [TestFixture]
    public class BusListModelTests
    {
        [Test]
        public void BusListModel_Properties()
        {
            // Arrange
            var busModel = new BusListModel
            {
                BusNo = 5001,
                BusName = "Point to point"
            };

            // Act - No specific action for properties

            // Assert
            Assert.AreEqual(5001, busModel.BusNo);
            Assert.AreEqual("Point to point", busModel.BusName);
        }
    }
}