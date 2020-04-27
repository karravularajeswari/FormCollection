using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class FormCollectionExController : Controller
    {
        // GET: FormCollectionEx
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(FormCollection frm)
        {
            ViewBag.name = frm["txtname"];
            ViewBag.price = frm["txtprice"];
            return View();
        }
    }
}