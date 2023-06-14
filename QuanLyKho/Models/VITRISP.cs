namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VITRISP")]
    public partial class VITRISP
    {
        [Key]
        [Display(Name = "Mã vị trí sản phẩm")]
        public int MaVTSP { get; set; }
        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
        [Display(Name = "Số lượng")]

        public int SoLuong { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public int MaSP { get; set; }

        [Display(Name = "Mã vị trí kho")]
        public int MaVTK { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual VITRIKHO VITRIKHO { get; set; }
    }
}
