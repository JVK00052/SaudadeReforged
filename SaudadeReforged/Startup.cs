using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaudadeReforged.Startup))]
namespace SaudadeReforged
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
