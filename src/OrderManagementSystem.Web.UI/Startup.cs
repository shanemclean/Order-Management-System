using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderManagementSystem.Web.UI.Startup))]
namespace OrderManagementSystem.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
