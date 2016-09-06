using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_7.Startup))]
namespace Lab_7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
