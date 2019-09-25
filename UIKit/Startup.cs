using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIKit.Startup))]
namespace UIKit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
