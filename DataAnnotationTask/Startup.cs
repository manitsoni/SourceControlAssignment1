using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAnnotationTask.Startup))]
namespace DataAnnotationTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
