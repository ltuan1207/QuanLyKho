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
        public int MaCTPXK { get; set; }

        public int MaSP { get; set; }

        public int MaPXK { get; set; }

        public double DonGia { get; set; }

        public int SoLuongXuat { get; set; }

        [StringLength(20)]
        public string DoviTinh { get; set; }

        public double? Khoiluong { get; set; }

        public int MaVTK { get; set; }

        public virtual PHIEUXUATKHO PHIEUXUATKHO { get; set; }

        public virtual VITRIKHO VITRIKHO { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
