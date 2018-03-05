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
            double actualResult = exchangeRate.ExchangeRate(1.00);

            Assert.Equal(32.33, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_100USD_To_3154_08000THB_Plus_Fee_Should_Be_3232_94THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(100.00);

            Assert.Equal(3232.94, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_101USD_To_3185_620800THB_Plus_Fee_Should_Be_3254_12THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(101.00);

            Assert.Equal(3254.12, actualResult);
        }
    }
}
