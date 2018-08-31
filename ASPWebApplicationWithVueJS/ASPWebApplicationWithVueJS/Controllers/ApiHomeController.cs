using ASPWebApplicationWithVueJS.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace ASPWebApplicationWithVueJS.Controllers
{
    #region Validate Method
    public static class APIHelper
    {
        public static string ErrorsToJsonResult(this ModelStateDictionary modelState)
        {
            IEnumerable<KeyValuePair<string, string[]>> errors = modelState.IsValid
                ? null
                : modelState
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray())
                    .Where(m => m.Value.Any());
           
            return JsonConvert.SerializeObject(errors);
        }
    }
    #endregion

    public class ApiHomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            var ViewModel = new EmpViewModel
            {
                ID = Guid.NewGuid(),
                Name = "Admin",
                Number = 5000,
            };

            return Json(ViewModel);
        }

        [HttpPost]
        public HttpResponseMessage Post(EmpViewModel obj)
        {
            if (ModelState.IsValid)
            {
                // Do something with the product (not shown).

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                var state=ModelState;

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.ErrorsToJsonResult());
            }
        }

    }
}
