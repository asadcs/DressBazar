using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DressBazar.Services;
using DressBazar.Entities;

namespace DressBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductsTable(string search)
        {

            var products = productsService.GetProducts();

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(x => x.Name!=null&& x.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }
        public ActionResult create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult create(Product product)
        {
            productsService.SaveProducts(product);
            return RedirectToAction("ProductsTable");
        }

        public ActionResult edit(int id )
        {
            var product = productsService.GetProductsbyID(id);
                
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult edit(Product product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductsTable");
        }
        [HttpPost]
        public ActionResult delete(int id)
        {
            productsService.DeleteProduct(id);
            return RedirectToAction("ProductsTable");
        }
    }
}