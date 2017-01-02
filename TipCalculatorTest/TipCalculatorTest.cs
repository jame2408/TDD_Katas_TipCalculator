using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipCalculatorTest
{
    [TestClass]
    public class TipCalculatorTest
    {
        [TestMethod]
        public void 輸入10元_小費15啪_需給額外小費1點50元_總共要給11點50元()
        {
            //arrange
            double billAmount = 10d;
            double tipRate = 15;

            //Act
            var target = new TipCalculator.TipCalculator();
            target.CaclTipAndTotalAmount(billAmount, tipRate);

            //Assert
            Assert.AreEqual(1.50d, target.tip);
            Assert.AreEqual(11.50d, target.totalAmount);
        }
    }
}
