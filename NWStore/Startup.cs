using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWStore.Startup))]
namespace NWStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
