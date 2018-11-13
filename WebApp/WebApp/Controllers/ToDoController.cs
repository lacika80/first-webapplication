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
        Db db = new Db();
        public ActionResult Index()
        {

            return View(db.Items.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = db.Items.Single(x => x.Id == id);
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(int id, string name, bool Done)
        {
            var item = db.Items.Single(x => x.Id == id);
            item.Name = name;
            item.Done = Done;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Create(string name, bool IsDone)
        {
            if (!string.IsNullOrEmpty(name))
            {
                db.Items.Add(new Item() {Name = name, Quantity = 0, Unit = "kg", Done = IsDone });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = db.Items.Single(x => x.Id == id);
            return View(item);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = db.Items.Single(x => x.Id == id);
            ideiglenes.lista.Remove(item);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}