using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningBox.Startup))]
namespace LearningBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
