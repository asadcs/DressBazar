using DressBazar.Entities;
using DressBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DressBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService sc = new CategoryService();
        // GET: Category

        [HttpGet]
        public ActionResult Index()
        {
            var categories = sc.GetCategories();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            sc.SaveCategory(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
           var category= sc.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            sc.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = sc.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            //category = sc.GetCategory(category.ID);
            sc.DeleteCategory(category);
            return RedirectToAction("Index");
        }
    }
}