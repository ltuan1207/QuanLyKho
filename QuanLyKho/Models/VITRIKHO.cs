namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VITRIKHO")]
    public partial class VITRIKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VITRIKHO()
        {
            CTPHIEUNHAPKHOes = new HashSet<CTPHIEUNHAPKHO>();
            CTPHIEUXUATKHOes = new HashSet<CTPHIEUXUATKHO>();
            VITRISPs = new HashSet<VITRISP>();
        }

        [Key]
        [Display(Name = "Mã vị trí kho")]
        public int MaVTK { get; set; }

        [Required(ErrorMessage = "Tên vị trí kho không được bỏ trống")]
        [Display(Name = "Tên vị trí kho")]
        [StringLength(255)]
        public string TenVTK { get; set; }


        [Required(ErrorMessage = "Mời nhập mô tả ")]
        [Display(Name = "Mô tả")]
        [StringLength(255)]
        public string MoTa { get; set; }

        [Display(Name = "Mã kho hàng")]
        public int MaKhoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUNHAPKHO> CTPHIEUNHAPKHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUXUATKHO> CTPHIEUXUATKHOes { get; set; }

        public virtual KHOHANG KHOHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VITRISP> VITRISPs { get; set; }
    }
}
