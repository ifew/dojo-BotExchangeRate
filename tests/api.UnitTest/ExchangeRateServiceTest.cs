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
            double actualResult = exchangeRate.CalculateFee(31.5408000);

            Assert.Equal(32.33, actualResult);
        }
    }
}
