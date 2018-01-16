using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenkPrintMVC_v0._5.Startup))]
namespace GenkPrintMVC_v0._5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
