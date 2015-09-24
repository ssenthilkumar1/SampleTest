using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleTestWebsite.Startup))]
namespace SampleTestWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
