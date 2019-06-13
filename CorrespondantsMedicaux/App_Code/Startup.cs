using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorrespondantsMedicaux.Startup))]
namespace CorrespondantsMedicaux
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
