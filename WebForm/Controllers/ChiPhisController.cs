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
    public class ChiPhisController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: ChiPhis
        public ActionResult Index()
        {
            var chiPhis = ChiPhi.getAll();
            return View(chiPhis.ToList());
        }

        // GET: ChiPhis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = ChiPhi.getItemById(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            return View(chiPhi);
        }

        // GET: ChiPhis/Create
        public ActionResult Create()
        {
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan");
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi");
            return View();
        }

        // POST: ChiPhis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiPhi,MaDoan,SoTien,MaLoaiChiPhi")] ChiPhi chiPhi)
        {
            if (ModelState.IsValid)
            {
                if(ChiPhi.addChiPhi(chiPhi) == 1)
                {
                    return RedirectToAction("Details","DoanDuLiches",new { id = chiPhi.MaDoan.Trim() });
                }
            }

            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // GET: ChiPhis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = ChiPhi.getItemById(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // POST: ChiPhis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiPhi,MaDoan,SoTien,MaLoaiChiPhi")] ChiPhi chiPhi)
        {
            if (ModelState.IsValid)
            {
                if(ChiPhi.edit(chiPhi) == 1)
                {
                    return RedirectToAction("Details","DoanDuLiches",new { id = chiPhi.MaDoan.Trim()});

                }
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // GET: ChiPhis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = ChiPhi.getItemById(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            return View(chiPhi);
        }

        // POST: ChiPhis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            
            if(ChiPhi.delectChiPhi(id) == 1)
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
