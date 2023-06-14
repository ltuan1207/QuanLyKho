namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Linq;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        [Display(Name="Mã nhà cung cấp ")]
        public int MaNCC { get; set; }

        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống")]
        [Display(Name = "Tên nhà cung cấp")]
        [StringLength(255)]
        public string TenNCC { get; set; }

        [Required(ErrorMessage = "Địa chỉ nhà cung cấp không được để trống")]
        [Display(Name = "Địa chỉ nhà cung cấp")]
        [StringLength(255)]
        public string DiachiNCC { get; set; }

        [Required(ErrorMessage = "Mời nhập số điện thoại nhà cung cấp")]
        [Display(Name = "Số điện thoại nhà cung cấp")]
        [StringLength(20)]
        public string SDTNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
