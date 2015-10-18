using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTML5.Startup))]
namespace HTML5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
