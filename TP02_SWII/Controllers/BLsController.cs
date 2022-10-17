using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP02_SWII.Models;

namespace TP02_SWII.Controllers
{
    public class BLsController : Controller
    {
        private Context db = new Context();

        // GET: BLs
        public ActionResult Index()
        {
            return View(db.Bls.ToList());
        }

        // GET: BLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BL bL = db.Bls.Find(id);
            if (bL == null)
            {
                return HttpNotFound();
            }
            return View(bL);
        }

        // GET: BLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BLs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Consignee,Navio")] BL bL)
        {
            if (ModelState.IsValid)
            {
                db.Bls.Add(bL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bL);
        }

        // GET: BLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BL bL = db.Bls.Find(id);
            if (bL == null)
            {
                return HttpNotFound();
            }
            return View(bL);
        }

        // POST: BLs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Consignee,Navio")] BL bL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bL);
        }

        // GET: BLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BL bL = db.Bls.Find(id);
            if (bL == null)
            {
                return HttpNotFound();
            }
            return View(bL);
        }

        // POST: BLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BL bL = db.Bls.Find(id);
            db.Bls.Remove(bL);
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
