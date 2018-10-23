using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mywebapp1.Startup))]
namespace mywebapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
