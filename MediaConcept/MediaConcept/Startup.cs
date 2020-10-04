using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaConcept.Startup))]
namespace MediaConcept
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
