namespace QuanLyKho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int MaNV { get; set; }

        [Required(ErrorMessage = "Mời nhập tên nhân viên")]
        [Display(Name = "Tên nhân viên")]
        [StringLength(255)]
        public string TenNV { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        [Display(Name = "Nhập Email")]
        [StringLength(255)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*\d)[@a-zA-Z\d]{8,}$", ErrorMessage = "Mật khẩu phải có độ dài tối thiểu là 8 ký tự và chứa ít nhất một ký tự đặc biệt @")]
        [Display(Name = "Mật khẩu")]
        [StringLength(50)]
        public string MatKhau { get; set; }


        [Display(Name = "Hình ảnh")]
        [Column(TypeName = "text")]
        public string ImgUrl { get; set; }

        [Display(Name = "Mã chức vụ")]
        public int MaCV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }

}
