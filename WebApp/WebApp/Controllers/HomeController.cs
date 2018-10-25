using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
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

        public ActionResult TodoList()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item() { Name = "só", Quantity = 2, Unit = "kg", Done = true });
            lista.Add(new Item() { Name = "cukor", Quantity = 1, Unit = "kg", Done = false });
            lista.Add(new Item() { Name = "liszt", Quantity = 500, Unit = "gramm", Done = false });
            lista.Add(new Item() { Name = "kömény", Quantity = 1, Unit = "tasak", Done = false });
            ViewBag.Lista = lista;
            return View(lista);
        }
    }
}