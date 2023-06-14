using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyKho.Models;

namespace QuanLyKho.Controllers
{
    public class CTPHIEUNHAPKHOesController : Controller
    {
        private QLKhoDBContext db = new QLKhoDBContext();

        // GET: CTPHIEUNHAPKHOes
        public ActionResult Index()
        {
            if (Session["Taikhoan"] != null)
            {
                var cTPHIEUNHAPKHOes = db.CTPHIEUNHAPKHOes.Include(c => c.PHIEUNHAPKHO).Include(c => c.SANPHAM);
                return View(cTPHIEUNHAPKHOes.ToList());
            }
            else
                return RedirectToAction("Dangnhap", "Login");
        }

        // GET: CTPHIEUNHAPKHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUNHAPKHO cTPHIEUNHAPKHO = db.CTPHIEUNHAPKHOes.Find(id);
            if (cTPHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(cTPHIEUNHAPKHO);
        }

        // GET: CTPHIEUNHAPKHOes/Create
        public ActionResult Create()
        {
            ViewBag.MaVTK = new SelectList(db.VITRIKHOes, "MaVTK", "TenVTK");
            ViewBag.MaPNK = new SelectList(db.PHIEUNHAPKHOes, "MaPNK", "MaPNK");
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP");
            return View();
        }

        // POST: CTPHIEUNHAPKHOes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTPNK,MaSP,MaPNK,MaVTK,DonGiaN,DonviTinh,Khoiluong,SoLuongNhap")] CTPHIEUNHAPKHO cTPHIEUNHAPKHO)
        {
            if (ModelState.IsValid)
            {
                var phieuNhapKho = db.PHIEUNHAPKHOes.Find(cTPHIEUNHAPKHO.MaPNK);
                    db.CTPHIEUNHAPKHOes.Add(cTPHIEUNHAPKHO);
                    db.SaveChanges();
                    return RedirectToAction("Index");
            }
            ViewBag.MaVTK = new SelectList(db.VITRIKHOes, "MaVTK", "TenVTK", cTPHIEUNHAPKHO.MaVTK);
            ViewBag.MaPNK = new SelectList(db.PHIEUNHAPKHOes, "MaPNK", "MaPNK", cTPHIEUNHAPKHO.MaPNK);
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cTPHIEUNHAPKHO.MaSP);
            return View(cTPHIEUNHAPKHO);
        }

        // GET: CTPHIEUNHAPKHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUNHAPKHO cTPHIEUNHAPKHO = db.CTPHIEUNHAPKHOes.Find(id);
            if (cTPHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }

            ViewBag.MaVTK = new SelectList(db.VITRIKHOes, "MaVTK", "TenVTK", cTPHIEUNHAPKHO.MaVTK);
            ViewBag.MaPNK = new SelectList(db.PHIEUNHAPKHOes, "MaPNK", "MaPNK", cTPHIEUNHAPKHO.MaPNK);
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cTPHIEUNHAPKHO.MaSP);
            return View(cTPHIEUNHAPKHO);
        }

        // POST: CTPHIEUNHAPKHOes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTPNK,MaSP,MaPNK,DonGia,SoLuongNhap")] CTPHIEUNHAPKHO cTPHIEUNHAPKHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTPHIEUNHAPKHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaVTK = new SelectList(db.VITRIKHOes, "MaVTK", "TenVTK", cTPHIEUNHAPKHO.MaVTK);
            ViewBag.MaPNK = new SelectList(db.PHIEUNHAPKHOes, "MaPNK", "MaPNK", cTPHIEUNHAPKHO.MaPNK);
            ViewBag.MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cTPHIEUNHAPKHO.MaSP);
            return View(cTPHIEUNHAPKHO);
        }

        // GET: CTPHIEUNHAPKHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUNHAPKHO cTPHIEUNHAPKHO = db.CTPHIEUNHAPKHOes.Find(id);
            if (cTPHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(cTPHIEUNHAPKHO);
        }

        // POST: CTPHIEUNHAPKHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CTPHIEUNHAPKHO cTPHIEUNHAPKHO = db.CTPHIEUNHAPKHOes.Find(id);
            db.CTPHIEUNHAPKHOes.Remove(cTPHIEUNHAPKHO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteSelected(string[] selectedIds)
        {
            if (selectedIds != null && selectedIds.Length > 0)
            {
                foreach (var id in selectedIds)
                {
                    if (int.TryParse(id, out int Id))
                    {
                        var xoa = db.CTPHIEUNHAPKHOes.Find(Id);
                        if (xoa != null)
                        {
                            db.CTPHIEUNHAPKHOes.Remove(xoa);
                        }
                    }
                }
                db.SaveChanges();
            }

            return new EmptyResult();
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
