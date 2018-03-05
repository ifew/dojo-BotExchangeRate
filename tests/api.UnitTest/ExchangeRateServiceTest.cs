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

        [Fact]
        public void When_Exchange_Rate_499USD_To_15738_859200THB_Plus_Fee_Should_Be_16077_25THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(499.00);

            Assert.Equal(16077.25, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_500USD_To_15770_400000THB_Plus_Fee_Should_Be_16109_47THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(500.00);

            Assert.Equal(16109.47, actualResult);
        }

        [Fact]
        public void When_Exchange_Rate_501USD_To_15801_940800THB_Plus_Fee_Should_Be_16117_98THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(501.00);

            Assert.Equal(16117.98, actualResult);
        }
        
        [Fact]
        public void When_Exchange_Rate_1000USD_To_31540_800000THB_Plus_Fee_Should_Be_32171_62THB()
        {
            ExchangeRateService exchangeRate = new ExchangeRateService();
            double actualResult = exchangeRate.ExchangeRate(1000.00);

            Assert.Equal(32171.62, actualResult);
        }
    }
}
