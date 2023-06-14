namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            CTPHIEUNHAPKHOes = new HashSet<CTPHIEUNHAPKHO>();
            CTPHIEUXUATKHOes = new HashSet<CTPHIEUXUATKHO>();
            VITRISPs = new HashSet<VITRISP>();
        }
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public int MaSP { get; set; }


        [StringLength(255)]
        [Required(ErrorMessage = "Mời nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]

        public string TenSP { get; set; }

        [Required(ErrorMessage = "Mời nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [Required(ErrorMessage = "Mời nhập đơn giá")]
        [Display(Name = "Đơn giá ")]
        public double DonGia { get; set; }

        
        [StringLength(50)]
        [Required(ErrorMessage = "Mời nhập đơn vị tính (Kg,Cái,..) ")]
        [Display(Name = "Đơn vị tính")]
        public string DonViTinh { get; set; }

        [Required(ErrorMessage = "Mời nhập số lượng tồn > 0 ")]
        [Display(Name = "Số lượng tồn")]
        public int SoLuongTon { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }


        [Required(ErrorMessage = "Khối lượng không được để trống")]
        [Range(1, double.MaxValue, ErrorMessage = "Khối lượng phải phải lớn hơn 0")]
        public double? KhoiLuong { get; set; }


        [Display(Name = "Mã nhà cung cấp")]
        public int MaNCC { get; set; }

        [Display(Name = "Mã nhóm sản phẩm")]
        public int MaNhomSP { get; set; }

        //[Key]
        //[Display(Name = "Mã sản phẩm")]
        //public int MaSP { get; set; }

        //[Required(ErrorMessage = "Mời nhập tên sản phẩm")]
        //[Display(Name = "Tên sản phẩm")]
        //[StringLength(255)]
        //public string TenSP { get; set; }
        //[Required(ErrorMessage = "Mời nhập mô tả")]
        //[Display(Name = "Mô tả")]

        //[StringLength(255)]
        //public string Mota { get; set; }

        //[Required(ErrorMessage = "Mời nhập đơn giá")]
        //[Display(Name = "Đơn giá ")]
        //public double DonGia { get; set; }

        //[Required(ErrorMessage = "Mời nhập đơn vị tính (Kg,Cái,..) ")]
        //[Display(Name = "Đơn vị tính")]
        //[StringLength(50)]
        //public string DonViTinh { get; set; }
        //[Required(ErrorMessage = "Mời nhập số lượng tồn > 0 ")]
        //[Display(Name = "Số lượng tồn")]

        //public int SoLuongTon { get; set; }
        //[Display(Name = "Hình ảnh")]

        //[StringLength(255)]
        //public string HinhAnh { get; set; }

        //[Required(ErrorMessage ="Khối lượng không được để trống")]
        //[Range(1, double.MaxValue, ErrorMessage = "Khối lượng phải phải lớn hơn 0")]
        //public double KhoiLuong { get; set; }

        //[Display(Name = "Mã nhà cung cấp")]
        //public int MaNCC { get; set; }

        //[Display(Name = "Mã nhóm sản phẩm")]
        //public int MaNhomSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUNHAPKHO> CTPHIEUNHAPKHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUXUATKHO> CTPHIEUXUATKHOes { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual NHOMSANPHAM NHOMSANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VITRISP> VITRISPs { get; set; }
    }
}
