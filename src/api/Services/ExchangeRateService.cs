using System;

namespace api.Services
{
    public class ExchangeRateService
    {
        public double CalculateAmountWithFee(double inputAmount)
        {
            double amountWithFee = inputAmount + (inputAmount * 0.025);

            return _RoundCeiling2Digit(amountWithFee);
        }

        private double _RoundCeiling2Digit(double inputAmount)
        {
            double result = Math.Round(Math.Ceiling(inputAmount * 100)/100, 2, MidpointRounding.AwayFromZero);

            return result;
        }
    }
}
