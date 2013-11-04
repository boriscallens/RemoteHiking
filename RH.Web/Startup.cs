using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RH.Web.Startup))]
namespace RH.Web
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
