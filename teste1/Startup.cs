using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teste1.Startup))]
namespace teste1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
