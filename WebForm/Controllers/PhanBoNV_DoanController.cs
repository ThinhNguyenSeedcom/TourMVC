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
    public class PhanBoNV_DoanController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: PhanBoNV_Doan
        public ActionResult Index()
        {
            var phanBoNV_Doan = db.PhanBoNV_Doan.Include(p => p.DoanDuLich).Include(p => p.NhanVien);
            return View(phanBoNV_Doan.ToList());
        }

        // GET: PhanBoNV_Doan/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanBoNV_Doan phanBoNV_Doan = db.PhanBoNV_Doan.Find(id);
            if (phanBoNV_Doan == null)
            {
                return HttpNotFound();
            }
            return View(phanBoNV_Doan);
        }

        // GET: PhanBoNV_Doan/Create
        public ActionResult Create()
        {
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan");
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "TenNV");
            return View();
        }

        // POST: PhanBoNV_Doan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,MaDoan,NhiemVu")] PhanBoNV_Doan phanBoNV_Doan)
        {
            if (ModelState.IsValid)
            {
                db.PhanBoNV_Doan.Add(phanBoNV_Doan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaTour", phanBoNV_Doan.MaDoan);
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "TenNV", phanBoNV_Doan.MaNV);
            return View(phanBoNV_Doan);
        }

        // GET: PhanBoNV_Doan/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanBoNV_Doan phanBoNV_Doan = db.PhanBoNV_Doan.Find(id);
            if (phanBoNV_Doan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaTour", phanBoNV_Doan.MaDoan);
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "TenNV", phanBoNV_Doan.MaNV);
            return View(phanBoNV_Doan);
        }

        // POST: PhanBoNV_Doan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,MaDoan,NhiemVu")] PhanBoNV_Doan phanBoNV_Doan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phanBoNV_Doan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaTour", phanBoNV_Doan.MaDoan);
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "TenNV", phanBoNV_Doan.MaNV);
            return View(phanBoNV_Doan);
        }

        // GET: PhanBoNV_Doan/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhanBoNV_Doan phanBoNV_Doan = db.PhanBoNV_Doan.Find(id);
            if (phanBoNV_Doan == null)
            {
                return HttpNotFound();
            }
            return View(phanBoNV_Doan);
        }

        // POST: PhanBoNV_Doan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PhanBoNV_Doan phanBoNV_Doan = db.PhanBoNV_Doan.Find(id);
            db.PhanBoNV_Doan.Remove(phanBoNV_Doan);
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
