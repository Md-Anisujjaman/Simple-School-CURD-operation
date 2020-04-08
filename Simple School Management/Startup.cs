using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_School_Management.Startup))]
namespace Simple_School_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
