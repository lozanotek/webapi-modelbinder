using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;
using TestAPI.Binder;
using TestAPI.Models;

namespace TestAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var provider = new SimpleModelBinderProvider(
                typeof(CustomerInputModel), new CustomerModelBinder());

            config.Services.Insert(typeof(ModelBinderProvider), 0, provider);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
