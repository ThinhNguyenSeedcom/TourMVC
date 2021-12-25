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
    public class TourDuLichesController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: TourDuLiches
        public ActionResult Index()
        {
            var tourDuLiches = TourDuLich.GetAll();
            return View(tourDuLiches.ToList());
        }

        // GET: TourDuLiches/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = TourDuLich.findById(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            return View(tourDuLich);
        }

        public ActionResult DetailsGiaTour()
        {
            return RedirectToAction( "Index", "GiaToursController");
        }

        // GET: TourDuLiches/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh");
            return View();
        }

        // POST: TourDuLiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTour,TenGoi,DacDiem,MaLoaiHinh")] TourDuLich tourDuLich)
        {
            if (ModelState.IsValid)
            {
/*                db.TourDuLiches.Add(tourDuLich);
                db.SaveChanges();*/
                if(TourDuLich.addTour(tourDuLich) == 1)
                {
                    return RedirectToAction("Index");
                }
                
            }

            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // GET: TourDuLiches/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = TourDuLich.findById(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // POST: TourDuLiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTour,TenGoi,DacDiem,MaLoaiHinh")] TourDuLich tourDuLich)
        {
            if (ModelState.IsValid)
            {
/*                db.Entry(tourDuLich).State = EntityState.Modified;
                db.SaveChanges();*/
                if(TourDuLich.edit(tourDuLich) == 1)
                {
                    return RedirectToAction("Index");
                }
                /*return RedirectToAction("Index");*/
            }
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // GET: TourDuLiches/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = TourDuLich.findById(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            return View(tourDuLich);
        }

        // POST: TourDuLiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            /*TourDuLich tourDuLich = db.TourDuLiches.Find(id);
            db.TourDuLiches.Remove(tourDuLich);
            db.SaveChanges();*/

            if(TourDuLich.delete(id) == 1)
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
