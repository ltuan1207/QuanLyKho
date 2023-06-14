namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPHIEUXUATKHO")]
    public partial class CTPHIEUXUATKHO
    {
        [Key]
        [Display(Name = "Mã chi tiết phiếu xuất kho")]
        public int MaCTPXK { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public int MaSP { get; set; }

        [Display(Name = "Mã phiếu xuất kho")]
        public int MaPXK { get; set; }
        [Required(ErrorMessage = "Đơn giá không được để trống")]
        [Range(0, 1000000, ErrorMessage = "Đơn giá phải nằm trong khoảng từ 0 đến 1 triệu")]
        [Display(Name = "Đơn giá")]

        public double DonGia { get; set; }
        [Required(ErrorMessage = "Số lượng xuất không được bỏ trông")]
        [Range(1, 10000, ErrorMessage = "Số lượng xuất phải nằm trong khoảng từ 1 đến 10000")]
        [Display(Name = "Số lượng xuất")]

        public int SoLuongXuat { get; set; }

        [Required(ErrorMessage ="Đơn vị tính không được để trống")]
        [Display(Name ="Đơn vị tính")]
        [StringLength(20)]

        public string DonviTinh { get; set; }

        [Required(ErrorMessage ="Khối lượng xuất không được để trống")]
        [Display(Name ="Khối lượng xuất")]
        public double? KhoiluongXuat { get; set; }

        [Display(Name ="Mã vị trí kho")]
        public int MaVTK { get; set; }

        public virtual PHIEUXUATKHO PHIEUXUATKHO { get; set; }

        public virtual VITRIKHO VITRIKHO { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
