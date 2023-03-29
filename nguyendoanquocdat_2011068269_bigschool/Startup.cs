using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyendoanquocdat_2011068269_bigschool.Startup))]
namespace nguyendoanquocdat_2011068269_bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
