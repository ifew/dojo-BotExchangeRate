using System;
using Xunit;
using api.Services;

namespace api.IntegrationTest
{
    public class BotServiceTest
    {
        [Fact]
        public void When_Selling_Amount_As_Of_1Feb2018_Should_Be_31_5408000THB()
        {
            BotService botService = new BotService();
            actualSelling = botService.GetSellingAverageDay("2018-02-01");

            Assert.Equal(31.5408000, actualSelling);
        }
    }
}
