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
    public class PHIEUNHAPKHOesController : Controller
    {
        private QLKhoDBContext db = new QLKhoDBContext();

        // GET: PHIEUNHAPKHOes
        public ActionResult Index()
        {
            if (Session["Taikhoan"] != null)
            {
                return View(db.PHIEUNHAPKHOes.ToList());
            }
            else
                return RedirectToAction("Dangnhap", "Login");
        }

        // GET: PHIEUNHAPKHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUNHAPKHO pHIEUNHAPKHO = db.PHIEUNHAPKHOes.Find(id);
            if (pHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUNHAPKHO);
        }

        // GET: PHIEUNHAPKHOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHIEUNHAPKHOes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPNK,NgayNhap,TongGTNhap")] PHIEUNHAPKHO pHIEUNHAPKHO)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUNHAPKHOes.Add(pHIEUNHAPKHO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEUNHAPKHO);
        }

        // GET: PHIEUNHAPKHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUNHAPKHO pHIEUNHAPKHO = db.PHIEUNHAPKHOes.Find(id);
            if (pHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUNHAPKHO);
        }

        // POST: PHIEUNHAPKHOes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPNK,NgayNhap,,TongGTNhap")] PHIEUNHAPKHO pHIEUNHAPKHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUNHAPKHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEUNHAPKHO);
        }

        // GET: PHIEUNHAPKHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUNHAPKHO pHIEUNHAPKHO = db.PHIEUNHAPKHOes.Find(id);
            if (pHIEUNHAPKHO == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUNHAPKHO);
        }

        // POST: PHIEUNHAPKHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEUNHAPKHO pHIEUNHAPKHO = db.PHIEUNHAPKHOes.Find(id);
            db.PHIEUNHAPKHOes.Remove(pHIEUNHAPKHO);
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
                        var xoa = db.PHIEUNHAPKHOes.Find(Id);
                        if (xoa != null)
                        {
                            db.PHIEUNHAPKHOes.Remove(xoa);
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
