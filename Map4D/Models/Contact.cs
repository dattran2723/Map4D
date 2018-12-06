using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Map4D.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Họ & tên")]
        [Required(ErrorMessage = "Vui lòng nhập vào tên của bạn")]
        [MinLength(4, ErrorMessage = "Ít nhất 4 ký tự")]
        [MaxLength(255)]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        [EmailAddress(ErrorMessage = "Bạn hãy nhập chính xác địa chỉ email của mình")]
        public string Email { get; set; }

        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage = "Mời nhập vào tiêu đề")]
        public string Subject { get; set; }

        [DisplayName("Tin nhắn")]
        [Required(ErrorMessage = "Mời bạn nhập vào ý kiến của mình")]
        public string Message { get; set; }

        [DisplayName("Ngày tạo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime CreatedDate { get; set; }

        [DisplayName("Trạng thái")]
        [DefaultValue(false)]
        public bool Status { get; set; }

    }
}