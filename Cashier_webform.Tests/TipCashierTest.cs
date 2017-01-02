using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TipCalculator;

namespace Cashier_webform.Tests
{
    [TestClass]
    public class TipCashierTest
    {
        [TestMethod()]
        public void CalculatorTest()
        {
            var nsub = Substitute.For<ITipCalculator>();
            nsub.tip.Returns(10d);
            nsub.totalAmount.Returns(110d);

            var target = new TipAndTotalamountCalculator(nsub);
            target.Calculator(100d, 10);

            Assert.AreEqual(10d, target.Tip);
            Assert.AreEqual(110d, target.TotalAmount);
        }
    }
}
