using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDNVN.MediaSocialNetwork.Web.Startup))]
namespace CDNVN.MediaSocialNetwork.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
