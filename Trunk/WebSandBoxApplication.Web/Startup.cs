﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSandBoxApplication.Web.Startup))]
namespace WebSandBoxApplication.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
