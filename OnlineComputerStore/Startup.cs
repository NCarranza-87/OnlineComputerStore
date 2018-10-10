using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineComputerStore.Startup))]
namespace OnlineComputerStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
