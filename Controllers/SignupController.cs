using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class SignupController : Controller
    {
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(UserDetail obj)
        {
            {
                
                //var data = Encoding.Unicode.GetBytes(obj.Password);
                //byte[] encrypted = ProtectedData.Protect(data, null, Scope);
                //string password = Convert.ToBase64String(encrypted);
                //obj.Password=password;
                KamayaniDBEntities2 obj1 = new KamayaniDBEntities2();
                obj1.UserDetails.Add(obj);
                obj1.SaveChanges();
                Session["name"] = obj.Name;
                Session["age"] = obj.Age;
                Session["emailid"] = obj.EmailID;
                return RedirectToAction("Dashboard", "Dashboard");
            }

        }

        public string Password { get; set; }

        public DataProtectionScope Scope { get; set; }
    }
}