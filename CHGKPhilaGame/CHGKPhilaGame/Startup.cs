using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHGKPhilaGame.Startup))]
namespace CHGKPhilaGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
