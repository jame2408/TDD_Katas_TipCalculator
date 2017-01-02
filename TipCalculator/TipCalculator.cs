﻿namespace TipCalculator
{
    public class TipCalculator
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
            _tip = billAmount * tipRate / 100;
            _totalAmount = billAmount + _tip;
        }
    }
}