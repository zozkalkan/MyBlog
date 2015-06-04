using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JusttBlogg.Startup))]
namespace JusttBlogg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
