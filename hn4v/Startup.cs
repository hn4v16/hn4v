using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hn4v.Startup))]
namespace hn4v
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
