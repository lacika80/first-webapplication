using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ToDoController : Controller
    {
        public ActionResult Index()
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