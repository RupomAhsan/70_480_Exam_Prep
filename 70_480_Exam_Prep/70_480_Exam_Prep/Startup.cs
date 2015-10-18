using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_70_480_Exam_Prep.Startup))]
namespace _70_480_Exam_Prep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
