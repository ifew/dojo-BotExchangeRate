using System;
using api.Services;
using Xunit;

namespace api.UnitTest
{
    public class ExchangeRateServiceTest
    {
        [Fact]
        public void When_Exchange_Rate_31_5408000_Plus_Fee_Should_Be_32_33()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.CalculateAmountWithFee(31.5408000);

            Assert.Equal(32.33, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_3154_08000_Plus_Fee_Should_Be_3232_94()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.CalculateAmountWithFee(3154.08000);

            Assert.Equal(3232.94, actualResult);
        }
    }
}
