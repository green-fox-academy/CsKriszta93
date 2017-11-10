using Groot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace GuardianTests
{
    public class GuardianTest
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
