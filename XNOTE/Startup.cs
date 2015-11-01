using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XNOTE.Startup))]
namespace XNOTE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
