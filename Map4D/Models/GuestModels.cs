using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Map4D.Models
{
    public class GuestModels
    {
        [Key]
        public int IdGuest { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập vào tên của bạn")]
        [MinLength(4, ErrorMessage = "Ít nhất 4 ký tự")]
        [MaxLength(255)]
        public string GuestName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        [EmailAddress(ErrorMessage = "Bạn hãy nhập chính xác địa chỉ email của mình")]
        public string GuestEmail { get; set; }
        [Required(ErrorMessage ="Mời nhập vào tiêu đề")]       
        public string GuestSubject { get; set; }
        [Required(ErrorMessage = "Mời bạn nhập vào ý kiến của mình")]
        public string Message { get; set; }
        public System.DateTime DateUp { get; set; }

    }
}