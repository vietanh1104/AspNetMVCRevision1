namespace Revision1.Models
{
    public class SanPham
    {
        public string masp { get; set; }
        public string tensanpham { get; set; }
        public int soluong { get; set; }
        public long giatien { get; set; }
        public int giamgia { get; set; }
        public double thanhtien
        {
            get
            {
                var tongtien = soluong * giatien;
                return giamgia == 0 ? tongtien : tongtien * 0.9;
            }
        }
    }
}