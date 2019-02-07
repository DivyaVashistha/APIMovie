using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APIMovie.Startup))]
namespace APIMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
