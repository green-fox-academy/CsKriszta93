using System;
using Xunit;
using System.Net.Http;



namespace IntegrationTest
{
    public class RestDoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoublingShould()
        {
            Server = new TestServer();

        }

        [Fact]
        public void Test1()
        {
           
        }
    }
}
