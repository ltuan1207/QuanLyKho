using QuanLyKho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;



namespace QuanLyKho.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        QLKhoDBContext data = new QLKhoDBContext();

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
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection f)
        {
            var tendn = f["username"];
            var matkhau = GetMD5(f["password"]);
            var ad = data.NHANVIENs.SingleOrDefault(n => n.Email == tendn && n.MatKhau == matkhau);
            if (ad != null)
            {
                Session["Taikhoan"] = ad;
                Session["Chucvu"] = ad.CHUCVU.TenCV;
                Session["anhNV"] = ad.ImgUrl;
                Session["Ten"] = ad.TenNV;
                Session["MaNv"] = ad.MaNV;
                return RedirectToAction("Index", "SANPHAMs");
            }else{ 

                ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
            }                   
            return View();
        }

        public ActionResult Logout()
        {
            // Xóa session và cookie của user
            Session.Clear();

            // Redirect về trang đăng nhập
            return RedirectToAction("Dangnhap", "Login");
        }
    }
}