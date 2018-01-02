using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HideRugs.Models;

namespace HideRugs.Controllers
{
    public class RugsController : Controller
    {
        private HideRugs_DBEntities db = new HideRugs_DBEntities();

        // GET: Rugs
        public ActionResult Index()
        {
            return View(db.Table1.ToList());
        }

        // GET: Rugs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = db.Table1.Find(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // GET: Rugs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Animal,Type,Colour,Size,ProductID")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                db.Table1.Add(table1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table1);
        }

        // GET: Rugs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = db.Table1.Find(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // POST: Rugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Animal,Type,Colour,Size,ProductID")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table1);
        }

        // GET: Rugs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = db.Table1.Find(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // POST: Rugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table1 table1 = db.Table1.Find(id);
            db.Table1.Remove(table1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
