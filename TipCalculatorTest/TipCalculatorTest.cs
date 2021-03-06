﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipCalculatorTest
{
    [TestClass]
    public class TipCalculatorTest
    {
        TipCalculator.ITipCalculator target;
        public TipCalculatorTest()
        {
            target = new TipCalculator.TipCalculator();
        }
        [TestMethod]
        public void 輸入10元_小費15啪_需給額外小費1點50元_總共要給11點50元()
        {
            //arrange
            double billAmount = 10d;
            double tipRate = 15;

            //Act
            target.CaclTipAndTotalAmount(billAmount, tipRate);

            //Assert
            Assert.AreEqual(1.50d, target.tip);
            Assert.AreEqual(11.50d, target.totalAmount);
        }

        [TestMethod]
        public void 確認計算小費時是否有四捨五入至小數第二位()
        {
            //arrange
            double billAmount = 11.25d;
            double tipRate = 15;

            //Act
            target.CaclTipAndTotalAmount(billAmount, tipRate);

            //Assert
            Assert.AreEqual(1.69d, target.tip);
            Assert.AreEqual(12.94d, target.totalAmount);
        }

        [TestMethod]
        public void 確認費率為0時計算結果()
        {
            //arrange
            double billAmount = 8d;
            double tipRate = 0;

            //Act
            target.CaclTipAndTotalAmount(billAmount, tipRate);

            //Assert
            Assert.AreEqual(0d, target.tip);
            Assert.AreEqual(8d, target.totalAmount);
        }

        [TestMethod]
        public void 確認沒消費時計算結果()
        {
            //arrange
            double billAmount = 0d;
            double tipRate = 10;

            //Act
            target.CaclTipAndTotalAmount(billAmount, tipRate);

            //Assert
            Assert.AreEqual(0d, target.tip);
            Assert.AreEqual(0d, target.totalAmount);
        }
    }
}
