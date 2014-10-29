using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSandBoxApplication.Web.App_Start
{
    public class AutofacConfig
    {
        public AutofacConfig()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegisterServices(builder);

            builder.Build();
        }

        private void RegisterServices(ContainerBuilder builder)
        {

        }
    }
}