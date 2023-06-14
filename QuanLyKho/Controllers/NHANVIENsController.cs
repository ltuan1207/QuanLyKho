using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using QuanLyKho.Models;



namespace QuanLyKho.Controllers
{
    public class NHANVIENsController : Controller
    {
        private QLKhoDBContext db = new QLKhoDBContext();

        // GET: NHANVIENs
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        public ActionResult Index(String chucVu, int? page)
        {
            if (Session["Taikhoan"] != null )
            {
                var nhanVien = db.NHANVIENs.AsQueryable();
                if (!string.IsNullOrEmpty(chucVu))
                {
                    nhanVien = nhanVien.Where(nv => nv.CHUCVU.TenCV == chucVu);
                }
                nhanVien = nhanVien.OrderBy(nv => nv.MaNV);
                int pageSize = 10;
                int pageNumber = (page ?? 1);
                return View(nhanVien.ToPagedList(pageNumber, pageSize));
                
            }else 
                return RedirectToAction("Dangnhap", "Login"); 
            
            
        }

        // GET: NHANVIENs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Create
        public ActionResult Create()
        {
            ViewBag.MaCV = new SelectList(db.CHUCVUs, "MaCV", "TenCV");
            return View();
        }

        // POST: NHANVIENs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,TenNV,Email,MatKhau,ImgUrl,MaCV")] NHANVIEN nHANVIEN, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    nHANVIEN.ImgUrl = fileName;
                }
                nHANVIEN.MatKhau = GetMD5(nHANVIEN.MatKhau);
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();

                if (file != null && file.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/images"), nHANVIEN.ImgUrl);
                    file.SaveAs(path);
                }

                return RedirectToAction("Index");
            }

            ViewBag.MaCV = new SelectList(db.CHUCVUs, "MaCV", "TenCV", nHANVIEN.MaCV);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaCV = new SelectList(db.CHUCVUs, "MaCV", "TenCV", nHANVIEN.MaCV);
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,TenNV,Email,MatKhau,ImgUrl,MaCV")] NHANVIEN nHANVIEN, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    nHANVIEN.ImgUrl = fileName;

                    var path = Path.Combine(Server.MapPath("~/images/"), fileName);
                    file.SaveAs(path);
                }
                else
                {
                    var nhanVienCu = db.NHANVIENs.Find(nHANVIEN.MaNV);
                    nHANVIEN.ImgUrl = nhanVienCu.ImgUrl;
                }
                nHANVIEN.MatKhau = GetMD5(nHANVIEN.MatKhau);
                db.NHANVIENs.AddOrUpdate(nHANVIEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaCV = new SelectList(db.CHUCVUs, "MaCV", "TenCV", nHANVIEN.MaCV);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            db.NHANVIENs.Remove(nHANVIEN);
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
                    if (int.TryParse(id, out int nhanVienId))
                    {
                        var nhanVien = db.NHANVIENs.Find(nhanVienId);
                        if (nhanVien != null)
                        {
                            db.NHANVIENs.Remove(nhanVien);
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
