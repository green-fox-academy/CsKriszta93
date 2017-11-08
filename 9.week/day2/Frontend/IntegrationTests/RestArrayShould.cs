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
    public class RestArrayShould
    {
        private TestContext Context;

        public RestArrayShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/rest/array?what=double,numbers=[1,2,5,10]");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
