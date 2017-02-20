using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class BlogEntryController : Controller
    {
        [HttpGet]
        public ActionResult BlogEntry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogEntry(BlogTable obj)
        {
            {
                KamayaniDBEntities2 obj2 = new KamayaniDBEntities2();
                obj2.BlogTables.Add(obj);
                obj2.SaveChanges();
                return RedirectToAction("Recipes", "Recipes");
            }

        }
    }
}
