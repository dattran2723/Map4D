using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Map4D.Models
{
    public class CustomerEditViewModels
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
        [Remote("IsPhoneExist", "Customers", "Admin", HttpMethod = "POST", ErrorMessage = "Số điện thoại đã tồn tại !")]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại liên hệ!")]
        [RegularExpression("[0-9]+$", ErrorMessage = "Vui lòng nhập đúng định dạng!")]
        [StringLength(13, ErrorMessage = "Số điên thoại gồm 6-13 ký tự số!", MinimumLength = 6)]

        public string Phone { get; set; }

        [DisplayName("Ghi chú")]
        public string Description { get; set; }

        [DefaultValue(false)]
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    }

    public class CustomerRegisterViewModels
    {

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
    }
}