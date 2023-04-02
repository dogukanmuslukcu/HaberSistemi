using Autofac;
using Autofac.Integration.Mvc;
using HaberSistemi.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.Class
{
    
    public class BootStrapper
    {
        public static void RunConfig()
        {
            BuildAutoFac();

        }
        public static void BuildAutoFac() 
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        
        }
    }
}