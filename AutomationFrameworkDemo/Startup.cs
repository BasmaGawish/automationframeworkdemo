using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomationFrameworkDemo.Startup))]
namespace AutomationFrameworkDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
