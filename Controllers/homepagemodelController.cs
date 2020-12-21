using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class homepagemodelController : Controller
    {
        // GET: homepage
        public ActionResult homepage()
        {
            var obj = new homepagemodel() { Prod_Price = 12,Prod_ID=22 };
            return View(obj);
        }
    }
}