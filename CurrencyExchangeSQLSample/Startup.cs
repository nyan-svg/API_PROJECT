using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurrencyExchangeSQLSample.Startup))]
namespace CurrencyExchangeSQLSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
