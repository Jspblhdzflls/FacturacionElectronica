using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacturacionElectronica.Startup))]
namespace FacturacionElectronica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
