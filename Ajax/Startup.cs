using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aprendendo.Startup))]
namespace Aprendendo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
