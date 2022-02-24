using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ServiceReference1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            service.CreateEmployee(employee);
            return RedirectToAction("ListEmployee");
        }        
        public ActionResult ListEmployee(string searchString)
        {
            return View(service.ListEmployee(searchString));
        }
    }
}