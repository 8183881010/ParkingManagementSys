using ParkingManagementSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParkingManagementSys.Controllers
{
    public class AccountController : Controller
    {
        ParkingManagmentEntities db = new ParkingManagmentEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            Admin user = new Admin();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Admin user)
        {
            if (ModelState.IsValid)
            {
                if (!db.Admins.Any(m => m.EmailId== user.EmailId))
                {
                    Admin objUser = new Models.Admin();
                    objUser.FirstName = user.FirstName;
                    objUser.LastName = user.LastName;
                    objUser.Password=user.Password;
                    objUser.EmailId= user.EmailId;
                    db.Admins.Add(objUser);
                    db.SaveChanges();
                    user= new Admin();
                    user.SuccessMessage="Admin is Sucessfully Registerd";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "EmailID Is Already Exists!");
                    return View();

                }
            }
            return View();
        }
        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }
        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                if (db.Admins.Where(m => m.EmailId== objLoginModel.EmailId && m.Password==objLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid EmailID And Password");
                    return View();
                }
                else
                {
                    Session["EmailId"]=objLoginModel.EmailId;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}