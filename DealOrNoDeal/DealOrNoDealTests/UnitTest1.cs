using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealOrNoDealTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ouvreLaValiseBeaute = true;
            var accept_offer = false;
            Assert.IsTrue(ouvreLaValiseBeaute);
            Assert.IsFalse(accept_offer, "Offer Declined!");
        }
    }
}
