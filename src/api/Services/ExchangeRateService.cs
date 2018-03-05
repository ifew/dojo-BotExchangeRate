using System;

namespace api.Services
{
    public class ExchangeRateService
    {
        public double ExchangeRate(double inputAmountUSD)
        {
            if (inputAmountUSD < 1)
            {
                double inputAmount = inputAmountUSD * 31.5408000;
                double fee = _GetFee(inputAmountUSD);
                return CalculateAmountWithFee(inputAmount, fee);
            }
            else
            {
                return 0;
            }
        }
        public double CalculateAmountWithFee(double inputAmount, double fee)
        {
            double amountWithFee = inputAmount + (inputAmount * fee);

            return _RoundCeiling2Digit(amountWithFee);
        }

        private double _GetFee(double inputAmount)
        {
            if (inputAmount <= 100)
            {
                return 0.0250;
            }
            else if (inputAmount > 100 && inputAmount <= 500)
            {
                return 0.0215;
            }
            else
            {
                return 0.0200;
            }
        }

        private double _RoundCeiling2Digit(double number)
        {
            double result = Math.Round(Math.Ceiling(number * 100) / 100, 2, MidpointRounding.AwayFromZero);

            return result;
        }
    }
}
