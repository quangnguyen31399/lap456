using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenLeHongQuang_lab456.Startup))]
namespace NguyenLeHongQuang_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
