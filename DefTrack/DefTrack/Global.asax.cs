using DataAccess.Repositories.Defects;
using DataAccess.Repositories.Products;
using DataAccess.Repositories.Releases;
using DefTrack.Common.Unity;
using DefTrack.Services.Contracts;
using DefTrack.Services.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DefTrack
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IUnityContainer _container;
        protected void Application_Start()
        {

            //Unity configuration
            ConfigureUnityContainer();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureUnityContainer()
        {
            _container = new UnityContainer();
            //Here register all dependencies
            //Register repositories
            _container.RegisterType<IProductsRepository, ProductsRepository>();
            _container.RegisterType<IDefectsRepository, DefectRepository>();
            _container.RegisterType<IReleasesRepository, ReleasesRepository>();

            //Register services
            _container.RegisterType<IProductService, ProductService>();
            _container.RegisterType<IReleaseService, ReleaseService>();
            _container.RegisterType<IDefectService, DefectService>();

            //UnityDependencyResolver exists in DefTrack.Common project
            DependencyResolver.SetResolver(new UnityDependencyResolver(_container));
        }
    }
}
