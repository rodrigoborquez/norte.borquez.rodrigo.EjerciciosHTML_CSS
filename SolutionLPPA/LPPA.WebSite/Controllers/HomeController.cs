using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA.WebSite.Controllers
{
    public class HomeController : Controller
    {
        
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

        public ActionResult Ejercicio1()
        {
            return View();
        }

        public ActionResult Ejercicio2()
        {
            return View();
        }

        public ActionResult Ejercicio3()
        {
            return View();
        }

        public ActionResult Ejercicio4()
        {
            return View();
        }

        public ActionResult Ejercicio5()
        {
            return View();
        }

        public ActionResult Ejercicio6()
        {
            return View();
        }

        public ActionResult Ejercicio7()
        {
            return View();
        }

        public ActionResult Ejercicios1CSS()
        {
            return View();
        }

        public ActionResult Ejercicios2CSS()
        {
            return View();
        }

        public ActionResult Ejercicios3CSS()
        {
            return View();
        }
        public ActionResult Ejercicios4CSS()
        {
            return View();
        }
    }
}