using System;
using api.Services;
using Xunit;

namespace api.UnitTest
{
    public class ExchangeRateServiceTest
    {
        ExchangeRateService _exchangeRate = new ExchangeRateService();

        [Theory]
        [InlineData(1, 32.33)]
        [InlineData(100, 3232.94)]
        [InlineData(101, 3254.12)]
        [InlineData(499, 16077.25)]
        [InlineData(500, 16109.47)]
        [InlineData(501, 16117.98)]
        [InlineData(1000, 32171.62)]
        public void When_Exchange_Rate_As_Of_1Feb2018_And_Plus_Fee(double inputAmountUSD, double expectedAmountTHB)
        {
            double actualResult = _exchangeRate.ExchangeRate(inputAmountUSD);

            Assert.Equal(expectedAmountTHB, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_0USD_Should_Be_0THB()
        {
            double actualResult = _exchangeRate.ExchangeRate(0.00);

            Assert.Equal(0, actualResult);
        }
        
        [Fact]
        public void When_Exchange_Rate_0_1USD_Should_Be_0THB()
        {
            double actualResult = _exchangeRate.ExchangeRate(0.10);

            Assert.Equal(0, actualResult);
        }
    }
}
