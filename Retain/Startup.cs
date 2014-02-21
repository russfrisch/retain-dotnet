using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Retain.Startup))]
namespace Retain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
