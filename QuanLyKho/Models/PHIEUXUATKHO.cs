namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUATKHO")]
    public partial class PHIEUXUATKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUXUATKHO()
        {
            CTPHIEUXUATKHOes = new HashSet<CTPHIEUXUATKHO>();
        }

        [Key]
        [Display(Name = "Mã phiếu xuất kho")]
        public int MaPXK { get; set; }
        [Required(ErrorMessage = "Ngày xuất kho không được để trống")]
        [Display(Name = "Ngày xuất kho ")]

        public DateTime NgayXuat { get; set; }
        [Display(Name = "Tổng giá trị xuất ")]


        public long TongGTXuat { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUXUATKHO> CTPHIEUXUATKHOes { get; set; }
    }
}
