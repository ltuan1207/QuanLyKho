namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        [Display(Name = "Mã đơn hàng")]
        public int MaDH { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        [Display(Name = "Khách hàng")]
        [StringLength(255)]
        public string KhachHang { get; set; }

        [Required(ErrorMessage = "Địa chỉ khách hàng không được để trống")]
        [Display(Name = "Địa chỉ")]
        [StringLength(255)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số điện thoại")]
        [StringLength(20)]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Ngày lập đơn hàng không được để trống")]
        [Display(Name = "Ngày lập đơn hàng")]

        [Column(TypeName = "date")]
        public DateTime NgayLapDonHang { get; set; }
        [Required(ErrorMessage = "Tổng giá trị đơn hàng không được để trống")]
        [Display(Name = "Tổng giá trị đơn hàng")]

        public double GiaTriDH { get; set; }
        [Display(Name = "Giá trị đơn hàng")]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
    }
}
