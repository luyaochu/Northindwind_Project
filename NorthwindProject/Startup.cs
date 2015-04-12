using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindProject.Startup))]
namespace NorthwindProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
