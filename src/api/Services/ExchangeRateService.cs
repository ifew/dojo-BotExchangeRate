using System;

namespace api.Services
{
    public class ExchangeRateService
    {
        public double CalculateAmountWithFee(double inputAmount)
        {
            double amountWithFee = inputAmount + (inputAmount * 0.025);

            amountWithFee = Math.Round(Math.Ceiling(amountWithFee * 100)/100, 2, MidpointRounding.AwayFromZero);

            return amountWithFee;
        }
    }
}
