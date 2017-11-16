using CalorieTableIntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalorieTableIntegrationTest
{
    [Collection("BaseCollection")]
    public class HomeShould
    {
        public TestContext Context;

        public HomeShould(TestContext Context)
        {
            this.Context = Context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/add");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
