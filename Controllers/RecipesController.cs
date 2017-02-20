using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet]
        public ActionResult Recipes()
        {
            KamayaniDBEntities2 obj1 = new KamayaniDBEntities2();
            List<BlogTable> obj = new List<BlogTable>();
            obj = obj1.BlogTables.ToList();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Recipes(BlogTable obj)
        {
            {
                KamayaniDBEntities2 obj2 = new KamayaniDBEntities2();
                obj2.BlogTables.Add(obj);
                obj2.SaveChanges();
                return View();
            }
        }
    }
}