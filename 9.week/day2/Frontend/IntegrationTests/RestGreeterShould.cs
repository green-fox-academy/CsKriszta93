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
    public class RestGreeterShould
    {
        private TestContext Context;

        public RestGreeterShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/rest/greeter?name=Petike,title=student");
            string responseJson = await response.Content.ReadAsStringAsync();
        }
    }
}
