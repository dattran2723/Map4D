using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Map4D.Models
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ và tên!")]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("Tên công ty")]
        [Required(ErrorMessage = "Vui lòng nhập tên công ty!")]
        public string Company { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại liên hệ!")]
        [RegularExpression("^0[0-9]+$", ErrorMessage = "Vui lòng nhập đúng định dạng!")]
        [StringLength(13, ErrorMessage = "Số điên thoại gồm 6-13 ký tự số!", MinimumLength = 6)]

        public string Phone { get; set; }

        [DisplayName("Địa chỉ Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        public string Email { get; set; }

        [DisplayName("Ngày đăng ký")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }

        [DisplayName("Ghi chú")]
        public string Description { get; set; }

        [DefaultValue(false)]
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

    }
}