using DressBazar.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DressBazar.Web.Controllers
{
    public class EmployeeController : Controller
    {
        DressBazar.Services.EmployeeService empService = new Services.EmployeeService();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            var emp  = empService.GetAllEmployees();
            return View(emp);
        }

        public ActionResult AddorEditEmployee(int id=0)
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddorEditEmployee(Employee emp)
        {
            if(emp.ImageUpload!=null)
            { 
            string fileName = Path.GetFileNameWithoutExtension(emp.ImageUpload.FileName);
            string extension = Path.GetExtension(emp.ImageUpload.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
            emp.ImagePath = "~/AppFiles/Images/" + fileName;
            emp.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFiles/Images/"),fileName));
            }
            empService.SaveEmployees(emp);
            return RedirectToAction("ViewAll");
        }
    }
}