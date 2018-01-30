using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameOfThrones.Models;

namespace GameOfThrones.Controllers
{
    public class CharactersController : Controller
    {
        private GOT_DBEntities1 db = new GOT_DBEntities1();

        // GET: Characters
        public ActionResult Index()
        {
            var characters = db.Characters.Include(c => c.House);
            return View(characters.ToList());
        }

        // GET: Characters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // GET: Characters/Create
        public ActionResult Create()
        {
            ViewBag.HouseId = new SelectList(db.Houses, "Id", "Name");
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Image,Name,Titles,Origin,HouseId,Status,Death,Actor")] Character character)
        {
            if (character.Image == null)
            {
                character.Image = "https://edge.alluremedia.com.au/m/l/2015/05/Gameofthrones.jpg";
            }


            if (ModelState.IsValid)
            {
                db.Characters.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HouseId = new SelectList(db.Houses, "Id", "Name", character.HouseId);
            return View(character);
        }

        // GET: Characters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            ViewBag.HouseId = new SelectList(db.Houses, "Id", "Name", character.HouseId);
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,Name,Titles,Origin,HouseId,Status,Death,Actor")] Character character)
        {
            if (character.Image == null)
            {
                character.Image = "https://edge.alluremedia.com.au/m/l/2015/05/Gameofthrones.jpg";
            }


            if (ModelState.IsValid)
            {
                db.Entry(character).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HouseId = new SelectList(db.Houses, "Id", "Name", character.HouseId);
            return View(character);
        }

        // GET: Characters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Characters.Find(id);
            db.Characters.Remove(character);
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
