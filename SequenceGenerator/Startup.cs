using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SequenceGenerator.Startup))]
namespace SequenceGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
