﻿using QuanLyKho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace QuanLyKho.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        QLKhoDBContext data = new QLKhoDBContext();


        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection f)
        {
            var tendn = f["username"];
            var matkhau = (f["password"]);
            var ad = data.NHANVIENs.SingleOrDefault(n => n.Email == tendn && n.MatKhau == matkhau);
            if (ad != null)
            {
                Session["Taikhoan"] = ad;
                Session["Chucvu"] = ad.CHUCVU.TenCV;
                Session["anhNV"] = ad.ImgUrl;
                Session["Ten"] = ad.TenNV;
                Session["MaNv"] = ad.MaNV;
                return RedirectToAction("Index", "Dasboard");
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