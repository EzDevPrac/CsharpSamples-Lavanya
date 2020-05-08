using System;
using Xunit;

namespace ProxyPattern.Testing
{
    public class TestServer
    {
        [Theory]
        [InlineData("Proxy Pattern")]
        [InlineData("Factory pattern")]
        public void RealServer_DisplayResult_ShouldReturn_SearchDetails(string search)
        {
            RealServer real = new RealServer(search);
            string str = "Displaying  Result From Real Server : " + search;
            Assert.Equal(real.DisplayResult(),str);
        }
        [Theory]
        [InlineData("Proxy Pattern")]
        [InlineData("Builder Pattern")]
        public void ProxySever_SerachurlInCache_ShouldReturn_BooleanValue(string search)
        {
            ProxyServer proxy = new ProxyServer();
            Assert.False(proxy.SearchUrlInCache(search));
        }
    }
}
