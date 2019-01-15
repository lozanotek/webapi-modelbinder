using System.Web.Http;
using System.Web.Http.ModelBinding;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class CustomerController : ApiController
    {
        public void Post([ModelBinder]CustomerInputModel inputModel)
        {

        }
    }
}
