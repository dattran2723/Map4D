using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Map4D.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "RequiredEmailLogin")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EnterPassword")]
        [StringLength(32, MinimumLength = 6, ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ToiThieu"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "GhiNhớMậtKhẩu", ResourceType = typeof(Map4D.Resources.My_texts))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EnterDisplayName")]
        public string DisplayName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "RegisterEnterUserName")]
        [Remote("CheckExistUserName", HttpMethod = "get", ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "RegisterExistUserName")]
        public string UserName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EnterEmail")]
        [EmailAddress(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EmailDinhDang")]
        [Remote("checkExistEmail", HttpMethod = "POST", ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EmailTontai")]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EnterPassword")]
        [StringLength(32, MinimumLength = 6, ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "ToiThieu"), DataType(DataType.Password)]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "XacNhanMatKhauValidate")]        
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EnterEmail")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessageResourceType = typeof(Map4D.Resources.My_texts), ErrorMessageResourceName = "EmailDinhDang")]
        public string Email { get; set; }
    }
}
