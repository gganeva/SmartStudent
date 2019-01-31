using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartStudent.Startup))]
namespace SmartStudent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
