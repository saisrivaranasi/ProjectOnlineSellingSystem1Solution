using ProjectOnlineSellingSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


    namespace ProjectOnlineSellingSystem.Controllers
    {
        public class UserDetailController : Controller
        {

        sellingsystemdbEntities db = new sellingsystemdbEntities();
            // GET: userDetails
            public ActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Register(UserDetail U)
            {

                db.UserDetails.Add(U);
                db.SaveChanges();
                var user = db.UserDetails.Single(u => u.UserName == U.UserName);
                if (user.Role == "Seller")
                {
                    seller seller = new seller(user.Name, user.UserName, user.Email, user.Password);
                    db.sellers.Add(seller);
                    db.SaveChanges();
                }
                if (user.Role == "Customer")
                {
                    Customer customer = new Customer(user.Name, user.UserName, user.Email, user.Password);
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                return View();
            }
            public ActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Login(UserDetail Ud)
            {
                try
                {
                    UserDetail ud1 = db.UserDetails.Single(x => x.UserName == Ud.UserName && x.Name == Ud.Name && x.Password == Ud.Password && x.Role == Ud.Role && x.Email == Ud.Email);
                    if (ud1 != null)
                    {
                        if (ud1.Role == "Seller")
                        {
                            return RedirectToAction("Navigate", "SellerDetails");
                        }
                        if (ud1.Role == "Customer")
                        {
                            return RedirectToAction("CustomerNavigate", "CustomerDetails");
                        }


                    }
                }
                catch
                {
                    ViewBag.Message = "User not found... please enter correct details";
                }
                return View();





            }
        }
    }