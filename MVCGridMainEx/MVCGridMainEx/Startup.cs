using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGridMainEx.Startup))]
namespace MVCGridMainEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
