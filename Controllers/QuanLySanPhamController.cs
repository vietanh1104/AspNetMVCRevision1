using Revision1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision1.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        private static List<SanPham> danhsach = new List<SanPham>()
        {
            new SanPham {masp = "S01", tensanpham = "Sản phẩm 1", soluong = 10, giatien = 100, giamgia = 0},
            new SanPham {masp = "S02", tensanpham = "Sản phẩm 2", soluong = 20, giatien = 120, giamgia = 1},
            new SanPham {masp = "S03", tensanpham = "Sản phẩm 3", soluong = 15, giatien = 200, giamgia = 1 },
            new SanPham { masp = "S04", tensanpham = "Sản phẩm 4", soluong = 30, giatien = 150, giamgia = 0 },
            new SanPham { masp = "S05", tensanpham = "Sản phẩm 5", soluong = 20, giatien = 50, giamgia = 1 }
        };
        public QuanLySanPhamController()
        {
          
        }
        // GET: QuanLySanPham
        public ActionResult DanhSachSanPham()
        {
            return View(danhsach);
        }
        
        public ActionResult XemSanPham(SanPham sanPham)
        {
            return View(sanPham);
        }   
        public ActionResult ThemSanPham()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemSanPham(SanPham sanPham)
        {
            danhsach.Add(sanPham);
            return View("XemSanPham", sanPham);
        }
    }
}