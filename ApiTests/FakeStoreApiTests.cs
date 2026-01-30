using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace ApiTests
{
    public class FakeStoreApiTests
    {
        private HttpClient client;

        [SetUp]
        public void Setup()
        {
            client = new HttpClient();
        }

        [Test]
        public async Task GetProducts_ShouldReturnStatus200()
        {
            var response = await client.GetAsync("https://fakestoreapi.com/products");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
