using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatalogoDeProdutos.UI.Startup))]
namespace CatalogoDeProdutos.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
