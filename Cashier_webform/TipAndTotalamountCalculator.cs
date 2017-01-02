using TipCalculator;

namespace Cashier_webform
{
    public class TipAndTotalamountCalculator
    {
        private readonly ITipCalculator _objCalculator;
        private double _tip;
        private double _totalAmount;

        public TipAndTotalamountCalculator()
        {
            _objCalculator = new TipCalculator.TipCalculator();
        }

        public TipAndTotalamountCalculator(ITipCalculator objCalculator)
        {
            _objCalculator = objCalculator;
        }

        public double Tip => _tip;

        public double TotalAmount => _totalAmount;

        public void Calculator(double billAmount, double tipRate)
        {
            _objCalculator.CaclTipAndTotalAmount(billAmount, tipRate);
            _tip = _objCalculator.tip;
            _totalAmount = _objCalculator.totalAmount;
        }
    }
}