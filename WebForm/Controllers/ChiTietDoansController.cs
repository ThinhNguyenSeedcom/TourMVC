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
    public class ChiTietDoansController : Controller
    {
        private QuanLyTourEntities db = new QuanLyTourEntities();

        // GET: ChiTietDoans
        public ActionResult Index()
        {
            var chiTietDoans = db.ChiTietDoans.Include(c => c.DoanDuLich).Include(c => c.KhachHang);
            return View(chiTietDoans.ToList());
        }

        // GET: ChiTietDoans/Details/5
        public ActionResult Details(string id,string id2)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDoan chiTietDoan = ChiTietDoan.findElementById(id, id2);
            if (chiTietDoan == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDoan);
        }

        // GET: ChiTietDoans/Create
        public ActionResult Create()
        {
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan");
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen");
            return View();
        }

        // POST: ChiTietDoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoan,MaKH,Ghichu")] ChiTietDoan chiTietDoan)
        {
            if (ModelState.IsValid)
            {

                if(ChiTietDoan.addChiTietDoan(chiTietDoan) == 1)
                {
                    return RedirectToAction("Details","DoanDuLiches",new { id = chiTietDoan.MaDoan.Trim() });

                }
            }

            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiTietDoan.MaDoan);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", chiTietDoan.MaKH);
            return View(chiTietDoan);
        }

        // GET: ChiTietDoans/Edit/5
        public ActionResult Edit(string id,string id2)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDoan chiTietDoan = ChiTietDoan.findElementById(id, id2);
            if (chiTietDoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiTietDoan.MaDoan);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", chiTietDoan.MaKH);
            return View(chiTietDoan);
        }

        // POST: ChiTietDoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoan,MaKH,Ghichu")] ChiTietDoan chiTietDoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietDoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiTietDoan.MaDoan);
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", chiTietDoan.MaKH);
            return View(chiTietDoan);
        }

        // GET: ChiTietDoans/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDoan chiTietDoan = db.ChiTietDoans.Find(id);
            if (chiTietDoan == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDoan);
        }

        // POST: ChiTietDoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiTietDoan chiTietDoan = db.ChiTietDoans.Find(id);
            db.ChiTietDoans.Remove(chiTietDoan);
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
