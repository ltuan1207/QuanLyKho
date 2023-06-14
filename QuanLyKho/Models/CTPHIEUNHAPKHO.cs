namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPHIEUNHAPKHO")]
    public partial class CTPHIEUNHAPKHO
    {
        [Key]
        [Display(Name = "Mã chi tiết phiếu nhập kho")]
        public int MaCTPNK { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public int MaSP { get; set; }

        public int MaPNK { get; set; }
        [Required(ErrorMessage = "Đơn giá không được để trống")]
        [Range(0, 1000000, ErrorMessage = "Đơn giá phải nằm trong khoảng từ 0 đến 1 triệu")]
        [Display(Name = "Đơn giá")]

        public double DonGiaN { get; set; }
        [Required(ErrorMessage = "Mời nhập số lượng nhập > 0.")]
        [Display(Name = "Số lượng nhập")]
        public int SoLuongNhap { get; set; }

        [StringLength(20)]

        [Required(ErrorMessage ="Đơn vị tính không được để trống")]
        [Display(Name ="Đơn vị tính")]
        public string DonviTinh { get; set; }

        [Required(ErrorMessage ="Khối lượng nhập không được để trống")]
        [Display(Name ="Khối lượng nhập")]
        public double? KhoiluongNhap { get; set; }

        [Display(Name ="Mã vị trí kho")]
        public int MaVTK { get; set; }

        public virtual PHIEUNHAPKHO PHIEUNHAPKHO { get; set; }

        public virtual VITRIKHO VITRIKHO { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
