using Frontend;
using IntegrationTests.TestFixtures;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    [Collection("BaseCollection")]
    public class RestDoublingShould
    {
        private TestContext Context;

        public RestDoublingShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/rest/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
