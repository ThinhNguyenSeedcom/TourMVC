using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebForm
{
    public class DoanDuLichesController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: DoanDuLiches
        public ActionResult Index()
        {
            var doanDuLiches = DoanDuLich.GetAll();
            return View(doanDuLiches.ToList());
        }

        // GET: DoanDuLiches/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = DoanDuLich.findElementById(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Create
        public ActionResult Create()
        {
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi");
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh");
            return View();
        }

        // POST: DoanDuLiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoan,NgayKhoiHanh,NgayKetThuc,DoanhThu,MaTour")] DoanDuLich doanDuLich)
        {
            if (ModelState.IsValid)
            {
                if(DoanDuLich.addDoanDuLich(doanDuLich) == 1)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }

            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = DoanDuLich.findElementById(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // POST: DoanDuLiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoan,NgayKhoiHanh,NgayKetThuc,DoanhThu,MaTour")] DoanDuLich doanDuLich)
        {
            if (ModelState.IsValid)
            {
                /*db.Entry(doanDuLich).State = EntityState.Modified;
                db.SaveChanges();*/
                if(DoanDuLich.edit(doanDuLich) == 1)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = DoanDuLich.findElementById(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            return View(doanDuLich);
        }

        // POST: DoanDuLiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            /*DoanDuLich doanDuLich = db.DoanDuLiches.Find(id);
            db.DoanDuLiches.Remove(doanDuLich);
            db.SaveChanges();*/
            if(DoanDuLich.delete(id) == 1)
            {
                return RedirectToAction("Index");
            }
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
