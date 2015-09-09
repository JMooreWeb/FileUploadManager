using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileUploadManager.Startup))]
namespace FileUploadManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
