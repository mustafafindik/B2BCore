using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models.Identity
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Mail Alanı Zorunludur.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Zorunludur.")]
        [StringLength(100, ErrorMessage = "Şifre En Az 6 Uzunluğunda Olmadı.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmedi")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
