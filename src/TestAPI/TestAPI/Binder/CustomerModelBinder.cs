using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using Newtonsoft.Json;
using TestAPI.Models;

namespace TestAPI.Binder
{
    public class CustomerModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            var modelType = typeof(CustomerInputModel);
            if (bindingContext.ModelType != modelType)
            {
                return false;
            }

            var request = actionContext.Request;
            var jsonContent = request.Content.ReadAsStringAsync().Result;

            bindingContext.Model = null; //JsonConvert.DeserializeObject(jsonContent, modelType);

            return true;
        }
    }
}