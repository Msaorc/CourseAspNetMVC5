using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MA.CursoMVC.UI.MVC.Startup))]
namespace MA.CursoMVC.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
