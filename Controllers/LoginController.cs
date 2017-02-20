using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(string User, string Password)
        {
            KamayaniDBEntities2 context = new KamayaniDBEntities2();
            var res = (from usr in context.UserDetails where usr.EmailID == User && usr.Password == Password select usr).FirstOrDefault();
            
            if (res == null)
            {
                return Json(false);
            }
            else
            {
                Session["name"] = res.Name;
                Session["age"] = res.Age;
                Session["emailid"] = res.EmailID;
                return Json(true);
            }

        }

   
    }

}