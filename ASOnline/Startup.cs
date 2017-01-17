using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASOnline.Startup))]
namespace ASOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
