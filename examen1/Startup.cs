using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(examen1.Startup))]
namespace examen1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
