using ParkingManagementSys.DBModel;
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
        ParkingManageEntities parking = new ParkingManageEntities();
        // GET: Acc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            UserModel user = new UserModel();
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (!parking.Admins.Any(m => m.EmailID== user.EmailID))
                {
                    Admin objUser = new DBModel.Admin();
                    objUser.FirstName = user.FirstName;
                    objUser.LastName = user.LastName;
                    objUser.Password=user.Password;
                    objUser.EmailID= user.EmailID;
                    parking.Admins.Add(objUser);
                    parking.SaveChanges();
                    user= new UserModel();
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
                if (parking.Admins.Where(m => m.EmailID== objLoginModel.EmailID && m.Password==objLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid EmailID And Password");
                    return View();
                }
                else
                {
                    Session["EmailID"]=objLoginModel.EmailID;
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