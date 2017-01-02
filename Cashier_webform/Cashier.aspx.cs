using System;

namespace Cashier_webform
{
    public partial class Cashier : System.Web.UI.Page
    {
        private readonly TipAndTotalamountCalculator _tipAndTotalamountCalculator = new TipAndTotalamountCalculator();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculator_Click(object sender, EventArgs e)
        {
            var BillAmount = Convert.ToDouble(billAmount.Text);
            var TipRate = Convert.ToDouble(tipRate.Text);
            _tipAndTotalamountCalculator.Calculator(BillAmount, TipRate);

            tip.Text = _tipAndTotalamountCalculator.Tip.ToString();
            totalAmount.Text = _tipAndTotalamountCalculator.TotalAmount.ToString();
        }
    }
}