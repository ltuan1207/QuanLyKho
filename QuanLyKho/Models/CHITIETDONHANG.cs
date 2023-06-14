namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [Display(Name = "Mã chi tiết đơn hàng")]
        public int MaCTDH { get; set; }


        public int MaSP { get; set; }
        [Display(Name = "Mã sản phẩm")]

        public int MaDH { get; set; }
        [Required(ErrorMessage = "Đơn giá không được để trống !")]
        [Range(0, 1000000, ErrorMessage = "Đơn giá phải nằm trong khoảng từ 0 đến 1 triệu")]
        [Display(Name = "Đơn giá")]

        public double DonGia { get; set; }
        [Required(ErrorMessage = "Mời nhập số lượng > 0.")]
        [Display(Name = "Số lượng")]

        public int SoLuong { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
