﻿using System;

namespace TipCalculator
{
    public class TipCalculator : ITipCalculator
    {
        private double _tip;

        public double tip
        {
            get { return _tip; }
            set { _tip = value; }
        }

        private double _totalAmount;

        public double totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        public void CaclTipAndTotalAmount(double billAmount, double tipRate)
        {
            CaclTip(billAmount, tipRate);
            CaclTotalAmount(billAmount);
        }

        private void CaclTip(double billAmount, double tipRate)
        {
            _tip = Math.Round(billAmount * tipRate / 100, 2);
        }

        private void CaclTotalAmount(double billAmount)
        {
            _totalAmount = billAmount + _tip;
        }
    }
}
