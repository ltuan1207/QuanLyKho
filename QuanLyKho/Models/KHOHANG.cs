namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOHANG")]
    public partial class KHOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOHANG()
        {
            VITRIKHOes = new HashSet<VITRIKHO>();
        }

        [Key]
        [Display(Name ="Mã kho hàng")]
        public int MaKhoHang { get; set; }

        [Display(Name ="Loại kho")]
        public String LoaiKho { get; set; }


        [Required(ErrorMessage = "Tên kho hàng không được để trống")]
        [Display(Name = "Tên kho hàng")]
        [StringLength(255)]
        public string TenKhohang { get; set; }

        [Required(ErrorMessage = "Địa chỉ kho hàng không được để trống.")]
        [Display(Name = "Địa chỉ")]
        [StringLength(255)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Số điện thoại đơn hàng không được để trống")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số điện thoại kho hàng")]
        [StringLength(20)]
        public string SDTKho { get; set; }

        [Required(ErrorMessage ="Sức chứa không được để trống")]
        [Display(Name ="Sức chứa")]
        public int Succhua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VITRIKHO> VITRIKHOes { get; set; }
    }
}
