using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JalkaHoitola.Startup))]
namespace JalkaHoitola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
