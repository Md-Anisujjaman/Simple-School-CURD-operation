using Simple_School_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_School_Management.Controllers
{
    public class LogInController : Controller
    {
        LimdaEntities db = new LimdaEntities();
        // GET: LogIn
       public ActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User Object)
        {
            if(ModelState.IsValid)
            {
                var obj = db.Users.Where(a => a.userName.Equals(Object.userName) && a.password.Equals(Object.password)).FirstOrDefault();

                if (obj != null)
                {
                    Session["UserID"] = obj.ID.ToString();
                    Session["UserName"] = obj.userName.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User name or password is incorrect");
                }
            }
            
                return View(Object);
            
        }

        ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "LogIn");
        }
    }
}