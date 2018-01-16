using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(genkPrint_v0._2.Startup))]
namespace genkPrint_v0._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
