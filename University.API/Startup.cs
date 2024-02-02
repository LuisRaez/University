using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using University.BLL.Data;

namespace University.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //configure the db context to use singleton instance per request
            app.CreatePerOwinContext(UniversityContext.Create);
        }
    }
}
