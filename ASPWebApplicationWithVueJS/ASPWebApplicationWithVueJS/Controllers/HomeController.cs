using ASPWebApplicationWithVueJS.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWebApplicationWithVueJS.Controllers
{
    #region Validate Method
    public static class WebHelper
    {
        public static ContentResult ErrorsToJsonResult(this ModelStateDictionary modelState)
        {
            //若modelState.IsValid == false(沒過驗證)則組errors
            IEnumerable<KeyValuePair<string, string[]>> errors = modelState.IsValid
                ? null
                : modelState
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray())
                    .Where(m => m.Value.Any());
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(errors),
                ContentType = "application/json"
            };
        }
    }
    #endregion


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VueMVC()
        {
            ViewBag.Message = "The Progressive JavaScript Framework With Vue";

            var ViewModel = new EmpViewModel
            {
                ID = Guid.NewGuid(),
                Name = "Admin",
                Number = 5000,
            };

            //ViewModel.ModelStates = ViewModel.GetModelStates();

            ViewBag.Object = ViewModel;


            return View();
        }

        [HttpPost]
        public JsonResult Search(EmpViewModel obj)
        {
            var Data = ModelState;
            if (ModelState.IsValid)
            {
                var response = ModelState.ErrorsToJsonResult();

                return Json(response.Content, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var response = ModelState.ErrorsToJsonResult();

                return Json(response.Content, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult VueAPI()
        {
            return View();
        }
    }
}