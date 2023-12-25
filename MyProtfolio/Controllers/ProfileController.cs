using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProtfolio.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult download()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Download()
        {
            return View();
        }
    }
}