using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProtfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MyProtfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        public ActionResult DownloadPdf()
        {
            var fileName = "PrajwlBonde-7030554623.pdf";
            var filePath = "C:/Users/HP/OneDrive/Desktop/Api/MyProtfolio/MyProtfolio/assets/css/PrajwalBonde-7030554623.pdf";

            if (System.IO.File.Exists(filePath))
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                Response.ContentType = "application/pdf";
                Response.Headers.Add("content-disposition", "inline; filename=" + fileName);
                return File(fileBytes, "application/octet-stream", fileName);
            }
            else
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Sendmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult sendmail( )
        {
            return View();
        }
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }

     
    }
}