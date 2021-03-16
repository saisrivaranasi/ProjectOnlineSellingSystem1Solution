using ProjectOnlineSellingSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnlineSellingSystem1.Controllers
{
    public class CustomerDetailsController : Controller
    {
        sellingsystemdbEntities context = new sellingsystemdbEntities();
    // GET: SellerDetails
    public ActionResult CustomerNavigate()
    {
        return View();
    }

    [HttpGet]
    public ActionResult ViewProducts()
    {
        sellingsystemdbEntities d1 = new sellingsystemdbEntities();


        var image = d1.products;
        return View(image);


    }
     public ActionResult SearchProducts(string searching)
        {
            var products = from p in context.products select p;
            if(!string.IsNullOrEmpty(searching))
            {
                products = products.Where(p => p.ProductName.Contains(searching));
            }

            return View(products.ToList());
        }

        
        public ActionResult PlaceOrder()
        {
            using (var details = new sellingsystemdbEntities())
            {
                //context.orders.Add(orders);
                //context.SaveChanges();
            }
            string message = "Order placed successfully";
            ViewBag.Message = message;
            return View();


        }
        [HttpPost]
        public ActionResult PlaceOrder(order orders)
        {
            using (var details = new sellingsystemdbEntities())
            {
                context.orders.Add(orders);
                context.SaveChanges();
            }
            string message = "Order placed successfully";
            ViewBag.Message = message;
            return View();


        }
    }
}