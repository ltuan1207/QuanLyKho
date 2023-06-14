namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHOMSANPHAM")]
    public partial class NHOMSANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOMSANPHAM()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        [Display(Name = "Mã nhóm sản phẩm")]
        public int MaNhomSP { get; set; }

        [Required(ErrorMessage = "Tên nhóm sản phẩm không được để trống")]
        [Display(Name = "Tên nhóm sản phẩm")]
        [StringLength(255)]
        public string TenNhomSP { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [Display(Name = "Mô tả")]

        [StringLength(255)]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
