using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AffiliateWebApi.Startup))]
namespace AffiliateWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
