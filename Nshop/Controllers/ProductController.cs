using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nshop.Controllers
{
    public class ProductController : Controller
    {
        private NShopContext db=new NShopContext();
        public IActionResult Index()
        {
            var products = db.Products;
            return View(products);
        }
        public ActionResult IndexProduct(string id)
        {
           var product =db.Products.Where(x=>x.CatalogId==id);
           
            ViewBag.CatalogIDSelecting = id;
           return View("IndexProduct",product);
        }
        public ActionResult DetailProduct(string id)
        {
            var product = db.Products.Find(id);
            return View("DetailProduct", product);
        }
        public ActionResult EditProduct(string id)
        {
            Products productid = db.Products.Find(id);
            ViewBag.CatalogId = new SelectList(db.Catalogs, "CatalogId", "CatalogName", productid.CatalogId);
            var product = db.Products.Find(id);
            return View("EditProduct", product);
        }
        public ActionResult SaveEditProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return View("DetailProduct",product);
            }
            ViewBag.CatalogId = new SelectList(db.Catalogs, "CatalogId", "CatalogName", product.CatalogId);
            return View("EditProduct",product);
        }
        public ActionResult DeleteProduct(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }
            Products product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            var listproduct = db.Products.Where(x => x.CatalogId == product.CatalogId);
            db.Products.Remove(product);
            db.SaveChanges();
            return View("IndexProduct", listproduct);
        }
        public ActionResult CreateForm(Products product,string id)
        {
            ViewBag.CatalogId = new SelectList(db.Catalogs, "CatalogId", "CatalogName");
            ViewBag.CatalogIDSelecting = id;
            var catalogName = db.Catalogs.FirstOrDefault(x=>x.CatalogId==id);
            if(catalogName!=null)
                ViewBag.CatalogName = catalogName.CatalogName;
            return View("AddProduct",product);
        }
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateProduct(Products pRODUCT,string id)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(pRODUCT);
                await db.SaveChangesAsync();
                var listproduct = db.Products.Where(x => x.CatalogId == pRODUCT.CatalogId);
                return View("IndexProduct",listproduct);
            }
            ViewBag.CatalogId = new SelectList(db.Catalogs, "CatalogId", "CatalogName", pRODUCT.CatalogId);
            return View("AddProduct",pRODUCT);
        }
        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
