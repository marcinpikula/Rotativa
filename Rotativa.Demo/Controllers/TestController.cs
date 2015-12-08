using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa.Demo.Models;
using Rotativa.Options;

namespace Rotativa.Demo.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index(string name)
        {
            ViewBag.Message = string.Format("Hello {0} to the test route!", name);
            return View();
        }

        public ActionResult Template(int id)
        {
            var model = new BirthCertViewModel { Id = id, FamilyName = "Pikula", MiddelName = "Tomasz", FirstName = "Marcin" };

            return new ViewAsPdf(model)
            {
                FileName = "Birth Certificate-" + model.Id,
                PageSize = Size.A3,
                PageOrientation = Orientation.Landscape,
                PageMargins = { Left = 0, Right = 0 }
            };
        }

    }
}
