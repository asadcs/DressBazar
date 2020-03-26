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
                products = products.Where(x => x.Name.Contains(search)).ToList();
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
    }
}