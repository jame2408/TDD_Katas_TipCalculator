namespace TipCalculator
{
    public interface ITipCalculator
    {
        double tip { get; set; }
        double totalAmount { get; set; }

        void CaclTipAndTotalAmount(double billAmount, double tipRate);

    }
}