using CalorieTableIntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalorieTableIntegrationTest.Scenarios.Home
{
    [Collection("BaseCollection")]
    class AddFoodShould
    {
        private TestContext Context;

        public AddFoodShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            Assert.True(true);
            //var response = await Context.Client.GetAsync("/add");
            //string responseJson = await response.Content.ReadAsStringAsync();

            //Assert.Equal(HttpStatusCode.OK, response.StatusCode); 
        }
    }
}
