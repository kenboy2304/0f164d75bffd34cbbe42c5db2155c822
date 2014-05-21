using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDNVN.MediaSocialNetwork.Startup))]
namespace CDNVN.MediaSocialNetwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
