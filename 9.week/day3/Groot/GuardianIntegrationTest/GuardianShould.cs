using GuardianIntegrationTest.TestFixture;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace GuardianIntegrationTest
{
    public class GuardianShould
    {
        TestContext Context = new TestContext();

        //public GuardianShould(TestContext context)
        //{
        //    Context = context;
        //}

        [Fact]
        public async Task ResultTest()
        {
            var response = await Context.Client.GetAsync("/groot?message=somemessage");
            var responseContent = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"somemessage\",\"translated\":\"I am Groot!\"}", responseContent);
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
