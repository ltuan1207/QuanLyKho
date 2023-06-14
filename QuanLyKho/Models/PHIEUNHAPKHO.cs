namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPKHO")]
    public partial class PHIEUNHAPKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPKHO()
        {
            CTPHIEUNHAPKHOes = new HashSet<CTPHIEUNHAPKHO>();
        }

        [Key]
        [Display(Name = "Mã phiếu nhập kho")]
        public int MaPNK { get; set; }
        [Required(ErrorMessage = "Ngày nhập kho không được để trống")]
        [Display(Name = "Ngày nhập kho")]

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }
        [Required(ErrorMessage = "Tổng tiền không được để trống")]
        [Display(Name = "Tổng tiền ")]

        public long TongGTNhap { get; set; }
        [Display(Name ="Tổng giá trị nhập")]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUNHAPKHO> CTPHIEUNHAPKHOes { get; set; }
    }
}
