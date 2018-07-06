using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(samplerepository.Startup))]
namespace samplerepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
