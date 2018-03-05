using System;
using api.Services;
using Xunit;

namespace api.UnitTest
{
    public class ExchangeRateServiceTest
    {
        [Fact]
        public void When_Exchange_Rate_1USD_To_31_5408000THB_Plus_Fee_Should_Be_32_33THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.CalculateAmountWithFee(31.5408000);

            Assert.Equal(32.33, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_100USD_To_3154_08000THB_Plus_Fee_Should_Be_3232_94THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.CalculateAmountWithFee(3154.08000);

            Assert.Equal(3232.94, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_101USD_To_3185_620800THB_Plus_Fee_Should_Be_3254_12THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.CalculateAmountWithFee(3185.620800);

            Assert.Equal(3254.12, actualResult);
        }
    }
}
