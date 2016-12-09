using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapModel.Startup))]
namespace BootstrapModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
