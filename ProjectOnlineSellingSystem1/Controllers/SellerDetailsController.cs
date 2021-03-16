using ProjectOnlineSellingSystem1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnlineSellingSystem1.Controllers
{
    public class SellerDetailsController : Controller
    {
        sellingsystemdbEntities context = new sellingsystemdbEntities();
        // GET: SellerDetails
        public ActionResult Navigate()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProducts(product image)
        {
            string fileName = Path.GetFileNameWithoutExtension(image.ImageFile.FileName);
            string extension = Path.GetExtension(image.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            image.ProductImage = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            image.ImageFile.SaveAs(fileName);
            using (sellingsystemdbEntities d = new sellingsystemdbEntities())
            {
                d.products.Add(image);
                d.SaveChanges();
            }
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult ViewProducts()
        {
            sellingsystemdbEntities d1 = new sellingsystemdbEntities();


            var image = d1.products;
            return View(image);


        }
        //[HttpDelete]
        //public ActionResult DeleteProducts(int id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    var product = context.products.Find(id);

        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    string currentImg = Request.MapPath(product.ProductImage);
        //    context.Entry(product).State = EntityState.Deleted;
        //    if (context.SaveChanges() > 0)
        //    {
        //        if (System.IO.File.Exists(currentImg))
        //        {
        //            System.IO.File.Delete(currentImg);
        //        }
        //        TempData["msg"] = "Data Deleted";
        //        return RedirectToAction("Index");
        //    }

        //    return View();
        //}
        [HttpGet]
        public ActionResult ViewPlaceorderdetails()
        {
            sellingsystemdbEntities d1 = new sellingsystemdbEntities();


            var list = d1.orders;
            return View(list);


        }
    }

}