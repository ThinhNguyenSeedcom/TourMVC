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
    public class GiaToursController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: GiaTours
        public ActionResult Index()
        {
            var giaTours = GiaTour.getAll();
            return View(giaTours.ToList());
        }

        // GET: GiaTours/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = GiaTour.findElementById(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            return View(giaTour);
        }

        // GET: GiaTours/Create
        public ActionResult Create()
        {
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi");
            return View();
        }

        // POST: GiaTours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGia,ThoiGianBatDau,ThoiGianKetThuc,ThanhTien,MaTour")] GiaTour giaTour)
        {
            if (ModelState.IsValid)
            {
                if (GiaTour.addGiaTour(giaTour) == 1)
                {
                    return RedirectToAction("Details", "TourDuLiches", new { id = giaTour.MaTour.Trim() });
                }
            }

            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", giaTour.MaTour);
            return View(giaTour);
        }

        // GET: GiaTours/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = GiaTour.findElementById(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", giaTour.MaTour);
            return View(giaTour);
        }

        // POST: GiaTours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGia,ThoiGianBatDau,ThoiGianKetThuc,ThanhTien,MaTour")] GiaTour giaTour)
        {
            if (ModelState.IsValid)
            {
                if(GiaTour.editGiaTour(giaTour) == 1)
                {
                    return RedirectToAction("Details", "TourDuLiches", new { id = giaTour.MaTour.Trim() });

                }
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenGoi", giaTour.MaTour);
            return View(giaTour);
        }

        // GET: GiaTours/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = GiaTour.findElementById(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            return View(giaTour);
        }

        // POST: GiaTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            
            if(GiaTour.remove(id) == 1)
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
