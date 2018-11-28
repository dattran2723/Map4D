using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Map4D.Startup))]
namespace Map4D
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
