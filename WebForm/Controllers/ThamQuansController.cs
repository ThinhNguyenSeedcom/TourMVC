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
    public class ThamQuansController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: ThamQuans
        public ActionResult Index()
        {
            var thamQuans = ThamQuan.getAll();
            return View(thamQuans.ToList());
        }

        // GET: ThamQuans/Details/5
        public ActionResult Details(string id, string idDD)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThamQuan thamQuan = ThamQuan.findElementById(id, idDD);
            if (thamQuan == null)
            {
                return HttpNotFound();
            }
            return View(thamQuan);
        }

        // GET: ThamQuans/Create
        public ActionResult Create()
        {
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems, "MaDiaDiem", "TenDiaDiem");
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi");
            return View();
        }

        // POST: ThamQuans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTour,MaDiaDiem,ThuTu")] ThamQuan thamQuan)
        {
            if (ModelState.IsValid)
            {
                if(ThamQuan.addThamQuan(thamQuan) == 1)
                return RedirectToAction("Details", "TourDuLiches", new { id = thamQuan.MaTour.Trim() });
            }

            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems, "MaDiaDiem", "TenDiaDiem", thamQuan.MaDiaDiem);
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", thamQuan.MaTour);
            return View(thamQuan);
        }

        // GET: ThamQuans/Edit/5
        public ActionResult Edit(string id,string idDD)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThamQuan thamQuan = ThamQuan.findElementById(id, idDD);
            if (thamQuan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems, "MaDiaDiem", "TenDiaDiem", thamQuan.MaDiaDiem);
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", thamQuan.MaTour);
            return View(thamQuan);
        }

        // POST: ThamQuans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTour,MaDiaDiem,ThuTu")] ThamQuan thamQuan)
        {
            if (ModelState.IsValid)
            {
                if(ThamQuan.editThamQuan(thamQuan) == 1)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems, "MaDiaDiem", "TenDiaDiem", thamQuan.MaDiaDiem);
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", thamQuan.MaTour);
            return View(thamQuan);
        }

        // GET: ThamQuans/Delete/5
        public ActionResult Delete(string id,string idDD)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThamQuan thamQuan = ThamQuan.findElementById(id, idDD);
            if (thamQuan == null)
            {
                return HttpNotFound();
            }
            return View(thamQuan);
        }

        // POST: ThamQuans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id, string idDD)
        {
            if(ThamQuan.deleteThamQuan(id,idDD) == 1)
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
