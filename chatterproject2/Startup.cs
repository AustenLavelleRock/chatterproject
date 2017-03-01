using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatterproject2.Startup))]
namespace chatterproject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
