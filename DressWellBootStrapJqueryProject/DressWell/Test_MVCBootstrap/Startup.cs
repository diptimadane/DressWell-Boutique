using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_MVCBootstrap.Startup))]
namespace Test_MVCBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
