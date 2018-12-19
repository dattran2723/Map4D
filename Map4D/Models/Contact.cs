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
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ContactEnterName")]
        [MaxLength(255)]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ContactEnterEmail")]
        [EmailAddress(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EmailDinhDang")]
        public string Email { get; set; }

        [DisplayName("Tiêu đề")]
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ContactEnterSubject")]
        public string Subject { get; set; }

        [DisplayName("Tin nhắn")]
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ContactEnterMessage")]
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