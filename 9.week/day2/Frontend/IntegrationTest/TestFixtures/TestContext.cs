using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Text;

namespace IntegrationTest.TestFixtures
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private readonly TestServer Server;

        public TestContext()
        {

        }
    }
}
