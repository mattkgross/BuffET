using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuffET.Startup))]
namespace BuffET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
