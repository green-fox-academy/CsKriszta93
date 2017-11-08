using IntegrationTests.TestFixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    [Collection("BaseCollection")]
    public class RestDountilShould
    {
        private TestContext Context;

        public RestDountilShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/rest/dountil?what=sum,number=15");
            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
